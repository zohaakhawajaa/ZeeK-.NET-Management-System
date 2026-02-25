namespace ZeeK
{
    partial class ProjectsForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtClient;
        private System.Windows.Forms.TextBox txtBudget;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label lblFormTitle;
        private System.Windows.Forms.Label lblTopTitle;
        private System.Windows.Forms.Label lblTitleLbl;
        private System.Windows.Forms.Label lblClientLbl;
        private System.Windows.Forms.Label lblBudgetLbl;
        private System.Windows.Forms.Label lblStatusLbl;
        private System.Windows.Forms.Label lblSearchLbl;
        private System.Windows.Forms.Label lblCount;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Panel topStrip;
        private System.Windows.Forms.Panel rightPanel;

        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtClient = new System.Windows.Forms.TextBox();
            this.txtBudget = new System.Windows.Forms.TextBox();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.lblTitleLbl = new System.Windows.Forms.Label();
            this.lblClientLbl = new System.Windows.Forms.Label();
            this.lblBudgetLbl = new System.Windows.Forms.Label();
            this.lblStatusLbl = new System.Windows.Forms.Label();
            this.lblSearchLbl = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.topStrip = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.topStrip.SuspendLayout();
            this.rightPanel.SuspendLayout();
            this.SuspendLayout();

            // topStrip
            this.topStrip.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.topStrip.Controls.Add(this.lblTopTitle);
            this.topStrip.Controls.Add(this.btnClose);
            this.topStrip.Dock = System.Windows.Forms.DockStyle.Top;
            this.topStrip.Height = 60;
            this.topStrip.Name = "topStrip";
            this.topStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopStrip_MouseDown);

            this.lblTopTitle.AutoSize = true;
            this.lblTopTitle.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.lblTopTitle.ForeColor = System.Drawing.Color.FromArgb(240, 240, 255);
            this.lblTopTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTopTitle.Text = "Projects Management";
            this.lblTopTitle.Name = "lblTopTitle";

            this.btnClose.BackColor = System.Drawing.Color.FromArgb(160, 40, 40);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1052, 16);
            this.btnClose.Size = new System.Drawing.Size(38, 28);
            this.btnClose.Text = "X";
            this.btnClose.Name = "btnClose";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // rightPanel
            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.rightPanel.Controls.Add(this.lblFormTitle);
            this.rightPanel.Controls.Add(this.lblTitleLbl);
            this.rightPanel.Controls.Add(this.txtTitle);
            this.rightPanel.Controls.Add(this.lblClientLbl);
            this.rightPanel.Controls.Add(this.txtClient);
            this.rightPanel.Controls.Add(this.lblBudgetLbl);
            this.rightPanel.Controls.Add(this.txtBudget);
            this.rightPanel.Controls.Add(this.lblStatusLbl);
            this.rightPanel.Controls.Add(this.cmbStatus);
            this.rightPanel.Controls.Add(this.btnAdd);
            this.rightPanel.Controls.Add(this.btnUpdate);
            this.rightPanel.Controls.Add(this.btnDelete);
            this.rightPanel.Controls.Add(this.btnClear);
            this.rightPanel.Controls.Add(this.lblStatus);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightPanel.Width = 320;
            this.rightPanel.Name = "rightPanel";

            this.lblFormTitle.AutoSize = true;
            this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(250, 204, 21);
            this.lblFormTitle.Location = new System.Drawing.Point(20, 20);
            this.lblFormTitle.Text = "Project Details";
            this.lblFormTitle.Name = "lblFormTitle";

            this.lblTitleLbl.AutoSize = true;
            this.lblTitleLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblTitleLbl.ForeColor = System.Drawing.Color.FromArgb(100, 100, 160);
            this.lblTitleLbl.Location = new System.Drawing.Point(20, 65);
            this.lblTitleLbl.Text = "PROJECT TITLE";
            this.lblTitleLbl.Name = "lblTitleLbl";

            this.txtTitle.BackColor = System.Drawing.Color.FromArgb(20, 20, 34);
            this.txtTitle.ForeColor = System.Drawing.Color.FromArgb(220, 220, 245);
            this.txtTitle.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTitle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtTitle.Location = new System.Drawing.Point(20, 85);
            this.txtTitle.Size = new System.Drawing.Size(280, 30);
            this.txtTitle.Name = "txtTitle";

            this.lblClientLbl.AutoSize = true;
            this.lblClientLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblClientLbl.ForeColor = System.Drawing.Color.FromArgb(100, 100, 160);
            this.lblClientLbl.Location = new System.Drawing.Point(20, 130);
            this.lblClientLbl.Text = "CLIENT";
            this.lblClientLbl.Name = "lblClientLbl";

            this.txtClient.BackColor = System.Drawing.Color.FromArgb(20, 20, 34);
            this.txtClient.ForeColor = System.Drawing.Color.FromArgb(220, 220, 245);
            this.txtClient.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtClient.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtClient.Location = new System.Drawing.Point(20, 150);
            this.txtClient.Size = new System.Drawing.Size(280, 30);
            this.txtClient.Name = "txtClient";

            this.lblBudgetLbl.AutoSize = true;
            this.lblBudgetLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblBudgetLbl.ForeColor = System.Drawing.Color.FromArgb(100, 100, 160);
            this.lblBudgetLbl.Location = new System.Drawing.Point(20, 195);
            this.lblBudgetLbl.Text = "BUDGET (PKR)";
            this.lblBudgetLbl.Name = "lblBudgetLbl";

            this.txtBudget.BackColor = System.Drawing.Color.FromArgb(20, 20, 34);
            this.txtBudget.ForeColor = System.Drawing.Color.FromArgb(220, 220, 245);
            this.txtBudget.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBudget.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtBudget.Location = new System.Drawing.Point(20, 215);
            this.txtBudget.Size = new System.Drawing.Size(280, 30);
            this.txtBudget.Name = "txtBudget";

            this.lblStatusLbl.AutoSize = true;
            this.lblStatusLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblStatusLbl.ForeColor = System.Drawing.Color.FromArgb(100, 100, 160);
            this.lblStatusLbl.Location = new System.Drawing.Point(20, 260);
            this.lblStatusLbl.Text = "STATUS";
            this.lblStatusLbl.Name = "lblStatusLbl";

            this.cmbStatus.BackColor = System.Drawing.Color.FromArgb(20, 20, 34);
            this.cmbStatus.ForeColor = System.Drawing.Color.FromArgb(220, 220, 245);
            this.cmbStatus.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.cmbStatus.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStatus.Location = new System.Drawing.Point(20, 280);
            this.cmbStatus.Size = new System.Drawing.Size(280, 30);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Items.AddRange(new object[] { "Ongoing", "Completed", "Pending", "On Hold", "Cancelled" });

            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(250, 204, 21);
            this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0;
            this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(10, 10, 18);
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(20, 328);
            this.btnAdd.Size = new System.Drawing.Size(280, 42);
            this.btnAdd.Text = "Add Project";
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(37, 99, 80);
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderSize = 0;
            this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(20, 380);
            this.btnUpdate.Size = new System.Drawing.Size(134, 38);
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Enabled = false;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(120, 30, 30);
            this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(162, 380);
            this.btnDelete.Size = new System.Drawing.Size(138, 38);
            this.btnDelete.Text = "Delete";
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Enabled = false;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(35, 35, 55);
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.ForeColor = System.Drawing.Color.FromArgb(180, 180, 220);
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnClear.Location = new System.Drawing.Point(20, 428);
            this.btnClear.Size = new System.Drawing.Size(280, 34);
            this.btnClear.Text = "Clear Form";
            this.btnClear.Name = "btnClear";
            this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(52, 211, 153);
            this.lblStatus.Location = new System.Drawing.Point(20, 475);
            this.lblStatus.Size = new System.Drawing.Size(280, 40);
            this.lblStatus.Text = "";
            this.lblStatus.Name = "lblStatus";

            // Search
            this.lblSearchLbl.AutoSize = true;
            this.lblSearchLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchLbl.ForeColor = System.Drawing.Color.FromArgb(148, 148, 180);
            this.lblSearchLbl.Location = new System.Drawing.Point(20, 80);
            this.lblSearchLbl.Text = "Search:";
            this.lblSearchLbl.Name = "lblSearchLbl";

            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(20, 20, 34);
            this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(220, 220, 245);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(80, 76);
            this.txtSearch.Size = new System.Drawing.Size(340, 28);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.lblCount.AutoSize = true;
            this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(148, 148, 180);
            this.lblCount.Location = new System.Drawing.Point(440, 80);
            this.lblCount.Text = "Total: 0";
            this.lblCount.Name = "lblCount";

            // DataGrid
            this.dataGrid.AllowUserToAddRows = false;
            this.dataGrid.AllowUserToDeleteRows = false;
            this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(26, 26, 42);
            this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(40, 40, 65);
            this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.ColumnHeadersHeight = 44;
            this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(250, 204, 21);
            this.dataGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dataGrid.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 26, 42);
            this.dataGrid.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(240, 240, 255);
            this.dataGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(70, 250, 204, 21);
            this.dataGrid.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dataGrid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 36);
            this.dataGrid.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(240, 240, 255);
            this.dataGrid.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(70, 250, 204, 21);
            this.dataGrid.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dataGrid.Location = new System.Drawing.Point(16, 118);
            this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true;
            this.dataGrid.RowHeadersVisible = false;
            this.dataGrid.RowTemplate.Height = 40;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(740, 530);
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 10, 18);
            this.ClientSize = new System.Drawing.Size(1100, 700);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ProjectsForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ZeeK - Projects";
            this.Controls.Add(this.dataGrid);
            this.Controls.Add(this.lblSearchLbl);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCount);
            this.Controls.Add(this.rightPanel);
            this.Controls.Add(this.topStrip);
            this.Load += new System.EventHandler(this.ProjectsForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.topStrip.ResumeLayout(false);
            this.topStrip.PerformLayout();
            this.rightPanel.ResumeLayout(false);
            this.rightPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}