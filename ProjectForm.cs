using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZeeK
{
    public partial class ProjectsForm : Form
    {
        private int selectedId = -1;
        private Point _dragStart;

        public ProjectsForm() { InitializeComponent(); }

        private void ProjectsForm_Load(object sender, EventArgs e) => LoadProjects();

        private void LoadProjects(string search = "")
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();
                    string query = string.IsNullOrEmpty(search)
                        ? "SELECT id, title, client, budget, status FROM projects ORDER BY id DESC"
                        : "SELECT id, title, client, budget, status FROM projects WHERE title LIKE @s OR client LIKE @s OR status LIKE @s ORDER BY id DESC";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(search)) cmd.Parameters.AddWithValue("@s", "%" + search + "%");
                        var dt = new DataTable();
                        new MySqlDataAdapter(cmd).Fill(dt);
                        dataGrid.DataSource = dt;
                    }
                }
                if (dataGrid.Columns.Contains("id")) { dataGrid.Columns["id"].Width = 50; dataGrid.Columns["id"].HeaderText = "ID"; }
                if (dataGrid.Columns.Contains("title")) { dataGrid.Columns["title"].HeaderText = "Title"; }
                if (dataGrid.Columns.Contains("client")) { dataGrid.Columns["client"].HeaderText = "Client"; }
                if (dataGrid.Columns.Contains("budget")) { dataGrid.Columns["budget"].HeaderText = "Budget (PKR)"; dataGrid.Columns["budget"].DefaultCellStyle.Format = "N2"; }
                if (dataGrid.Columns.Contains("status")) { dataGrid.Columns["status"].HeaderText = "Status"; dataGrid.Columns["status"].Width = 110; }
                lblCount.Text = "Total projects: " + dataGrid.Rows.Count;
            }
            catch (Exception ex) { ShowError("Load Error: " + ex.Message); }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0) return;
            var row = dataGrid.SelectedRows[0];
            selectedId = Convert.ToInt32(row.Cells["id"].Value);
            txtTitle.Text = row.Cells["title"].Value?.ToString();
            txtClient.Text = row.Cells["client"].Value?.ToString();
            txtBudget.Text = row.Cells["budget"].Value?.ToString();
            cmbStatus.SelectedItem = row.Cells["status"].Value?.ToString();
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
                    var cmd = new MySqlCommand("INSERT INTO projects (title, client, budget, status) VALUES (@t,@c,@b,@s)", conn);
                    cmd.Parameters.AddWithValue("@t", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@c", txtClient.Text.Trim());
                    cmd.Parameters.AddWithValue("@b", decimal.Parse(txtBudget.Text.Trim()));
                    cmd.Parameters.AddWithValue("@s", cmbStatus.SelectedItem?.ToString() ?? "Pending");
                    cmd.ExecuteNonQuery();
                }
                ShowSuccess("Project added!"); ClearFields(); LoadProjects(txtSearch.Text);
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
                    var cmd = new MySqlCommand("UPDATE projects SET title=@t, client=@c, budget=@b, status=@s WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@t", txtTitle.Text.Trim());
                    cmd.Parameters.AddWithValue("@c", txtClient.Text.Trim());
                    cmd.Parameters.AddWithValue("@b", decimal.Parse(txtBudget.Text.Trim()));
                    cmd.Parameters.AddWithValue("@s", cmbStatus.SelectedItem?.ToString() ?? "Pending");
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                }
                ShowSuccess("Project updated!"); ClearFields(); LoadProjects(txtSearch.Text);
            }
            catch (Exception ex) { ShowError("Update Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId < 0) return;
            if (MessageBox.Show("Delete project \"" + txtTitle.Text + "\"?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand("DELETE FROM projects WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                }
                ShowSuccess("Project deleted."); ClearFields(); LoadProjects(txtSearch.Text);
            }
            catch (Exception ex) { ShowError("Delete Error: " + ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadProjects(txtSearch.Text);

        private void ClearFields()
        {
            selectedId = -1; txtTitle.Text = ""; txtClient.Text = ""; txtBudget.Text = "";
            cmbStatus.SelectedIndex = -1; btnUpdate.Enabled = btnDelete.Enabled = false;
            dataGrid.ClearSelection();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtTitle.Text)) { ShowError("Title is required."); return false; }
            if (string.IsNullOrWhiteSpace(txtClient.Text)) { ShowError("Client is required."); return false; }
            if (!decimal.TryParse(txtBudget.Text.Trim(), out _)) { ShowError("Enter a valid budget."); return false; }
            if (cmbStatus.SelectedIndex < 0) { ShowError("Select a status."); return false; }
            return true;
        }

        private void ShowSuccess(string msg)
        {
            lblStatus.Text = "✔  " + msg; lblStatus.ForeColor = Color.FromArgb(52, 211, 153);
            var t = new Timer { Interval = 3000 };
            t.Tick += (s, ev) => { lblStatus.Text = ""; t.Stop(); };
            t.Start();
        }
        private void ShowError(string msg) { lblStatus.Text = "✖  " + msg; lblStatus.ForeColor = Color.FromArgb(248, 113, 113); }

        private void TopStrip_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { _dragStart = e.Location; topStrip.MouseMove += TopStrip_MouseMove; topStrip.MouseUp += TopStrip_MouseUp; }
        }
        private void TopStrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left) { var p = Location; p.X += e.X - _dragStart.X; p.Y += e.Y - _dragStart.Y; Location = p; }
        }
        private void TopStrip_MouseUp(object sender, MouseEventArgs e) { topStrip.MouseMove -= TopStrip_MouseMove; topStrip.MouseUp -= TopStrip_MouseUp; }
    }
}