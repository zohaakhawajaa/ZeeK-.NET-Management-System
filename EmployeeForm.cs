using System;
using System.Data;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace ZeeK
{
    public partial class EmployeeForm : Form
    {
        private int selectedId = -1;
        private Point _dragStart;

        public EmployeeForm()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
        }

        private async void EmployeeForm_Load(object sender, EventArgs e)
        {
            await LoadEmployeesAsync();
        }

        private async Task LoadEmployeesAsync(string search = "")
        {
            SetLoading(true);
            try
            {
                var dt = await Task.Run(() =>
                {
                    using (var conn = DB.GetConnection())
                    {
                        conn.Open();
                        string query = string.IsNullOrEmpty(search)
                            ? "SELECT id, name, role, salary FROM employees ORDER BY id DESC"
                            : "SELECT id, name, role, salary FROM employees WHERE name LIKE @s OR role LIKE @s ORDER BY id DESC";

                        using (var cmd = new MySqlCommand(query, conn))
                        {
                            if (!string.IsNullOrEmpty(search))
                                cmd.Parameters.AddWithValue("@s", "%" + search + "%");

                            var adapter = new MySqlDataAdapter(cmd);
                            var table = new DataTable();
                            adapter.Fill(table);
                            return table;
                        }
                    }
                });

                dataGrid.DataSource = dt;

                if (dataGrid.Columns.Contains("id")) { dataGrid.Columns["id"].Width = 50; dataGrid.Columns["id"].HeaderText = "ID"; }
                if (dataGrid.Columns.Contains("name")) { dataGrid.Columns["name"].Width = 200; dataGrid.Columns["name"].HeaderText = "Full Name"; }
                if (dataGrid.Columns.Contains("role")) { dataGrid.Columns["role"].Width = 160; dataGrid.Columns["role"].HeaderText = "Role"; }
                if (dataGrid.Columns.Contains("salary")) { dataGrid.Columns["salary"].HeaderText = "Salary (PKR)"; dataGrid.Columns["salary"].DefaultCellStyle.Format = "N2"; }

                lblCount.Text = "Total employees: " + dataGrid.Rows.Count;
            }
            catch (Exception ex)
            {
                ShowError("Load Error: " + ex.Message);
            }
            finally
            {
                SetLoading(false);
            }
        }

        private void dataGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGrid.SelectedRows.Count == 0) return;
            var row = dataGrid.SelectedRows[0];
            selectedId = Convert.ToInt32(row.Cells["id"].Value);
            txtName.Text = row.Cells["name"].Value?.ToString();
            txtRole.Text = row.Cells["role"].Value?.ToString();
            txtSalary.Text = row.Cells["salary"].Value?.ToString();
            btnUpdate.Enabled = true;
            btnDelete.Enabled = true;
        }

        private async void btnAdd_Click(object sender, EventArgs e)
        {
            if (!ValidateInputs()) return;
            SetLoading(true);
            try
            {
                string name = txtName.Text.Trim();
                string role = txtRole.Text.Trim();
                decimal salary = decimal.Parse(txtSalary.Text.Trim());

                await Task.Run(() =>
                {
                    using (var conn = DB.GetConnection())
                    {
                        conn.Open();
                        var cmd = new MySqlCommand(
                            "INSERT INTO employees (name, role, salary) VALUES (@n, @r, @s)", conn);
                        cmd.Parameters.AddWithValue("@n", name);
                        cmd.Parameters.AddWithValue("@r", role);
                        cmd.Parameters.AddWithValue("@s", salary);
                        cmd.ExecuteNonQuery();
                    }
                });

                ShowSuccess("Employee added successfully!");
                ClearFields();
                await LoadEmployeesAsync(txtSearch.Text);
            }
            catch (Exception ex) { ShowError("Add Error: " + ex.Message); }
            finally { SetLoading(false); }
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            if (selectedId < 0 || !ValidateInputs()) return;
            SetLoading(true);
            try
            {
                int id = selectedId;
                string name = txtName.Text.Trim();
                string role = txtRole.Text.Trim();
                decimal salary = decimal.Parse(txtSalary.Text.Trim());

                await Task.Run(() =>
                {
                    using (var conn = DB.GetConnection())
                    {
                        conn.Open();
                        var cmd = new MySqlCommand(
                            "UPDATE employees SET name=@n, role=@r, salary=@s WHERE id=@id", conn);
                        cmd.Parameters.AddWithValue("@n", name);
                        cmd.Parameters.AddWithValue("@r", role);
                        cmd.Parameters.AddWithValue("@s", salary);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                });

                ShowSuccess("Employee updated successfully!");
                ClearFields();
                await LoadEmployeesAsync(txtSearch.Text);
            }
            catch (Exception ex) { ShowError("Update Error: " + ex.Message); }
            finally { SetLoading(false); }
        }

        private async void btnDelete_Click(object sender, EventArgs e)
        {
            if (selectedId < 0) return;
            var confirm = MessageBox.Show(
                "Delete employee \"" + txtName.Text + "\"?\nThis cannot be undone.",
                "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (confirm != DialogResult.Yes) return;

            SetLoading(true);
            try
            {
                int id = selectedId;
                await Task.Run(() =>
                {
                    using (var conn = DB.GetConnection())
                    {
                        conn.Open();
                        var cmd = new MySqlCommand("DELETE FROM employees WHERE id=@id", conn);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                });

                ShowSuccess("Employee deleted.");
                ClearFields();
                await LoadEmployeesAsync(txtSearch.Text);
            }
            catch (Exception ex) { ShowError("Delete Error: " + ex.Message); }
            finally { SetLoading(false); }
        }

        private void btnClear_Click(object sender, EventArgs e) => ClearFields();

        private void btnClose_Click(object sender, EventArgs e) => this.Close();

        private async void txtSearch_TextChanged(object sender, EventArgs e)
        {
            await LoadEmployeesAsync(txtSearch.Text);
        }

        // ── Helpers ──────────────────────────────────────────────────────────
        private void SetLoading(bool loading)
        {
            btnAdd.Enabled = !loading;
            btnClear.Enabled = !loading;
            txtSearch.Enabled = !loading;
            dataGrid.Enabled = !loading;
            if (loading)
            {
                lblStatus.Text = "Loading...";
                lblStatus.ForeColor = Color.FromArgb(148, 148, 180);
                this.Cursor = Cursors.WaitCursor;
            }
            else
            {
                if (lblStatus.Text == "Loading...") lblStatus.Text = "";
                this.Cursor = Cursors.Default;
            }
        }

        private void ClearFields()
        {
            selectedId = -1;
            txtName.Text = "";
            txtRole.Text = "";
            txtSalary.Text = "";
            btnUpdate.Enabled = false;
            btnDelete.Enabled = false;
            dataGrid.ClearSelection();
        }

        private bool ValidateInputs()
        {
            if (string.IsNullOrWhiteSpace(txtName.Text))
            { ShowError("Name is required."); txtName.Focus(); return false; }
            if (string.IsNullOrWhiteSpace(txtRole.Text))
            { ShowError("Role is required."); txtRole.Focus(); return false; }
            if (!decimal.TryParse(txtSalary.Text.Trim(), out _))
            { ShowError("Enter a valid salary (numbers only)."); txtSalary.Focus(); return false; }
            return true;
        }

        private void ShowSuccess(string msg)
        {
            lblStatus.Text = "✔  " + msg;
            lblStatus.ForeColor = Color.FromArgb(52, 211, 153);
            var t = new Timer { Interval = 3000 };
            t.Tick += (s, ev) => { lblStatus.Text = ""; t.Stop(); };
            t.Start();
        }

        private void ShowError(string msg)
        {
            lblStatus.Text = "✖  " + msg;
            lblStatus.ForeColor = Color.FromArgb(248, 113, 113);
        }

        // ── Drag window ──────────────────────────────────────────────────────
        private void TopStrip_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragStart = e.Location;
                topStrip.MouseMove += TopStrip_MouseMove;
                topStrip.MouseUp += TopStrip_MouseUp;
            }
        }
        private void TopStrip_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var p = this.Location;
                p.X += e.X - _dragStart.X;
                p.Y += e.Y - _dragStart.Y;
                this.Location = p;
            }
        }
        private void TopStrip_MouseUp(object sender, MouseEventArgs e)
        {
            topStrip.MouseMove -= TopStrip_MouseMove;
            topStrip.MouseUp -= TopStrip_MouseUp;
        }
    }
}