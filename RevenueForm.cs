using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZeeK
{
    public partial class RevenueForm : Form
    {
        private int selectedId = -1;
        private Point _dragStart;

        public RevenueForm() { InitializeComponent(); }
        private void RevenueForm_Load(object sender, EventArgs e) => LoadRevenue();

        private void LoadRevenue(string search = "")
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();
                    string query = string.IsNullOrEmpty(search)
                        ? "SELECT id, month, amount, source FROM revenue ORDER BY id DESC"
                        : "SELECT id, month, amount, source FROM revenue WHERE month LIKE @s OR source LIKE @s ORDER BY id DESC";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(search)) cmd.Parameters.AddWithValue("@s", "%" + search + "%");
                        var dt = new DataTable();
                        new MySqlDataAdapter(cmd).Fill(dt);
                        dataGrid.DataSource = dt;
                    }
                }
                if (dataGrid.Columns.Contains("id")) { dataGrid.Columns["id"].Width = 50; dataGrid.Columns["id"].HeaderText = "ID"; }
                if (dataGrid.Columns.Contains("month")) { dataGrid.Columns["month"].HeaderText = "Month"; }
                if (dataGrid.Columns.Contains("amount")) { dataGrid.Columns["amount"].HeaderText = "Amount (PKR)"; dataGrid.Columns["amount"].DefaultCellStyle.Format = "N2"; }
                if (dataGrid.Columns.Contains("source")) { dataGrid.Columns["source"].HeaderText = "Source"; }
                lblCount.Text = "Total entries: " + dataGrid.Rows.Count;
            }
            catch (Exception ex) { ShowError("Load Error: " + ex.Message); }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0) return;
            var row = dataGrid.SelectedRows[0];
            selectedId = Convert.ToInt32(row.Cells["id"].Value);
            txtMonth.Text = row.Cells["month"].Value?.ToString();
            txtAmount.Text = row.Cells["amount"].Value?.ToString();
            txtSource.Text = row.Cells["source"].Value?.ToString();
            btnUpdate.Enabled = btnDelete.Enabled = true;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand("INSERT INTO revenue (month, amount, source) VALUES (@m,@a,@s)", conn);
                    cmd.Parameters.AddWithValue("@m", txtMonth.Text.Trim());
                    cmd.Parameters.AddWithValue("@a", decimal.Parse(txtAmount.Text.Trim()));
                    cmd.Parameters.AddWithValue("@s", txtSource.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                ShowSuccess("Revenue added!"); ClearFields(); LoadRevenue(txtSearch.Text);
            }
            catch (Exception ex) { ShowError("Add Error: " + ex.Message); }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId < 0 || !ValidateInputs()) return;
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand("UPDATE revenue SET month=@m, amount=@a, source=@s WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@m", txtMonth.Text.Trim());
                    cmd.Parameters.AddWithValue("@a", decimal.Parse(txtAmount.Text.Trim()));
                    cmd.Parameters.AddWithValue("@s", txtSource.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                }
                ShowSuccess("Revenue updated!"); ClearFields(); LoadRevenue(txtSearch.Text);
            }
            catch (Exception ex) { ShowError("Update Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId < 0) return;
            if (MessageBox.Show("Delete this revenue entry?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand("DELETE FROM revenue WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                }
                ShowSuccess("Entry deleted."); ClearFields(); LoadRevenue(txtSearch.Text);
            }
            catch (Exception ex) { ShowError("Delete Error: " + ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadRevenue(txtSearch.Text);

        private void ClearFields()
        {
            selectedId = -1; txtMonth.Text = ""; txtAmount.Text = ""; txtSource.Text = "";
            btnUpdate.Enabled = btnDelete.Enabled = false; dataGrid.ClearSelection();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtMonth.Text)) { ShowError("Month is required."); return false; }
            if (!decimal.TryParse(txtAmount.Text.Trim(), out _)) { ShowError("Enter a valid amount."); return false; }
            if (string.IsNullOrWhiteSpace(txtSource.Text)) { ShowError("Source is required."); return false; }
            return true;
        }

        private void ShowSuccess(string msg)
        {
            lblStatus.Text = "✔  " + msg; lblStatus.ForeColor = Color.FromArgb(52, 211, 153);
            var t = new Timer { Interval = 3000 }; t.Tick += (s, ev) => { lblStatus.Text = ""; t.Stop(); }; t.Start();
        }
        private void ShowError(string msg) { lblStatus.Text = "✖  " + msg; lblStatus.ForeColor = Color.FromArgb(248, 113, 113); }

        private void TopStrip_MouseDown(object sender, MouseEventArgs e)
        { if (e.Button == MouseButtons.Left) { _dragStart = e.Location; topStrip.MouseMove += TopStrip_MouseMove; topStrip.MouseUp += TopStrip_MouseUp; } }
        private void TopStrip_MouseMove(object sender, MouseEventArgs e)
        { if (e.Button == MouseButtons.Left) { var p = Location; p.X += e.X - _dragStart.X; p.Y += e.Y - _dragStart.Y; Location = p; } }
        private void TopStrip_MouseUp(object sender, MouseEventArgs e) { topStrip.MouseMove -= TopStrip_MouseMove; topStrip.MouseUp -= TopStrip_MouseUp; }
    }
}