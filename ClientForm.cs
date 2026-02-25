using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZeeK
{
    public partial class ClientsForm : Form
    {
        private int selectedId = -1;
        private Point _dragStart;

        public ClientsForm() { InitializeComponent(); }
        private void ClientsForm_Load(object sender, EventArgs e) => LoadClients();

        private void LoadClients(string search = "")
        {
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();
                    string query = string.IsNullOrEmpty(search)
                        ? "SELECT id, name, company, email FROM clients ORDER BY id DESC"
                        : "SELECT id, name, company, email FROM clients WHERE name LIKE @s OR company LIKE @s OR email LIKE @s ORDER BY id DESC";
                    using (var cmd = new MySqlCommand(query, conn))
                    {
                        if (!string.IsNullOrEmpty(search)) cmd.Parameters.AddWithValue("@s", "%" + search + "%");
                        var dt = new DataTable();
                        new MySqlDataAdapter(cmd).Fill(dt);
                        dataGrid.DataSource = dt;
                    }
                }
                if (dataGrid.Columns.Contains("id")) { dataGrid.Columns["id"].Width = 50; dataGrid.Columns["id"].HeaderText = "ID"; }
                if (dataGrid.Columns.Contains("name")) { dataGrid.Columns["name"].HeaderText = "Full Name"; }
                if (dataGrid.Columns.Contains("company")) { dataGrid.Columns["company"].HeaderText = "Company"; }
                if (dataGrid.Columns.Contains("email")) { dataGrid.Columns["email"].HeaderText = "Email Address"; }
                lblCount.Text = "Total clients: " + dataGrid.Rows.Count;
            }
            catch (Exception ex) { ShowError("Load Error: " + ex.Message); }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0) return;
            var row = dataGrid.SelectedRows[0];
            selectedId = Convert.ToInt32(row.Cells["id"].Value);
            txtName.Text = row.Cells["name"].Value?.ToString();
            txtCompany.Text = row.Cells["company"].Value?.ToString();
            txtEmail.Text = row.Cells["email"].Value?.ToString();
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
                    var cmd = new MySqlCommand("INSERT INTO clients (name, company, email) VALUES (@n,@c,@e)", conn);
                    cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@c", txtCompany.Text.Trim());
                    cmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());
                    cmd.ExecuteNonQuery();
                }
                ShowSuccess("Client added!"); ClearFields(); LoadClients(txtSearch.Text);
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
                    var cmd = new MySqlCommand("UPDATE clients SET name=@n, company=@c, email=@e WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@n", txtName.Text.Trim());
                    cmd.Parameters.AddWithValue("@c", txtCompany.Text.Trim());
                    cmd.Parameters.AddWithValue("@e", txtEmail.Text.Trim());
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                }
                ShowSuccess("Client updated!"); ClearFields(); LoadClients(txtSearch.Text);
            }
            catch (Exception ex) { ShowError("Update Error: " + ex.Message); }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId < 0) return;
            if (MessageBox.Show("Delete client \"" + txtName.Text + "\"?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) != DialogResult.Yes) return;
            try
            {
                using (var conn = DB.GetConnection())
                {
                    conn.Open();
                    var cmd = new MySqlCommand("DELETE FROM clients WHERE id=@id", conn);
                    cmd.Parameters.AddWithValue("@id", selectedId);
                    cmd.ExecuteNonQuery();
                }
                ShowSuccess("Client deleted."); ClearFields(); LoadClients(txtSearch.Text);
            }
            catch (Exception ex) { ShowError("Delete Error: " + ex.Message); }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();
        private void btnClose_Click(object sender, EventArgs e) => this.Close();
        private void txtSearch_TextChanged(object sender, EventArgs e) => LoadClients(txtSearch.Text);

        private void ClearFields()
        {
            selectedId = -1; txtName.Text = ""; txtCompany.Text = ""; txtEmail.Text = "";
            btnUpdate.Enabled = btnDelete.Enabled = false; dataGrid.ClearSelection();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text)) { ShowError("Name is required."); return false; }
            if (string.IsNullOrWhiteSpace(txtCompany.Text)) { ShowError("Company is required."); return false; }
            if (string.IsNullOrWhiteSpace(txtEmail.Text)) { ShowError("Email is required."); return false; }
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