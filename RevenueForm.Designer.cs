namespace ZeeK
{
    partial class RevenueForm
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing) { if (disposing && components != null) components.Dispose(); base.Dispose(disposing); }

        private System.Windows.Forms.DataGridView dataGrid;
        private System.Windows.Forms.TextBox txtMonth, txtAmount, txtSource, txtSearch;
        private System.Windows.Forms.Button btnAdd, btnUpdate, btnDelete, btnClear, btnClose;
        private System.Windows.Forms.Label lblFormTitle, lblTopTitle, lblMonthLbl, lblAmountLbl, lblSourceLbl, lblSearchLbl, lblCount, lblStatus;
        private System.Windows.Forms.Panel topStrip, rightPanel;

        private void InitializeComponent()
        {
            this.dataGrid = new System.Windows.Forms.DataGridView();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.txtSource = new System.Windows.Forms.TextBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.lblFormTitle = new System.Windows.Forms.Label();
            this.lblTopTitle = new System.Windows.Forms.Label();
            this.lblMonthLbl = new System.Windows.Forms.Label();
            this.lblAmountLbl = new System.Windows.Forms.Label();
            this.lblSourceLbl = new System.Windows.Forms.Label();
            this.lblSearchLbl = new System.Windows.Forms.Label();
            this.lblCount = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.topStrip = new System.Windows.Forms.Panel();
            this.rightPanel = new System.Windows.Forms.Panel();

            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).BeginInit();
            this.topStrip.SuspendLayout(); this.rightPanel.SuspendLayout(); this.SuspendLayout();

            this.topStrip.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.topStrip.Controls.Add(this.lblTopTitle); this.topStrip.Controls.Add(this.btnClose);
            this.topStrip.Dock = System.Windows.Forms.DockStyle.Top; this.topStrip.Height = 60; this.topStrip.Name = "topStrip";
            this.topStrip.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopStrip_MouseDown);

            this.lblTopTitle.AutoSize = true; this.lblTopTitle.Font = new System.Drawing.Font("Segoe UI Black", 14F, System.Drawing.FontStyle.Bold);
            this.lblTopTitle.ForeColor = System.Drawing.Color.FromArgb(240, 240, 255); this.lblTopTitle.Location = new System.Drawing.Point(20, 14);
            this.lblTopTitle.Text = "Revenue Tracker"; this.lblTopTitle.Name = "lblTopTitle";

            this.btnClose.BackColor = System.Drawing.Color.FromArgb(160, 40, 40); this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0; this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1052, 16); this.btnClose.Size = new System.Drawing.Size(38, 28);
            this.btnClose.Text = "X"; this.btnClose.Name = "btnClose"; this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            this.rightPanel.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.rightPanel.Controls.Add(this.lblFormTitle); this.rightPanel.Controls.Add(this.lblMonthLbl);
            this.rightPanel.Controls.Add(this.txtMonth); this.rightPanel.Controls.Add(this.lblAmountLbl);
            this.rightPanel.Controls.Add(this.txtAmount); this.rightPanel.Controls.Add(this.lblSourceLbl);
            this.rightPanel.Controls.Add(this.txtSource); this.rightPanel.Controls.Add(this.btnAdd);
            this.rightPanel.Controls.Add(this.btnUpdate); this.rightPanel.Controls.Add(this.btnDelete);
            this.rightPanel.Controls.Add(this.btnClear); this.rightPanel.Controls.Add(this.lblStatus);
            this.rightPanel.Dock = System.Windows.Forms.DockStyle.Right; this.rightPanel.Width = 320; this.rightPanel.Name = "rightPanel";

            this.lblFormTitle.AutoSize = true; this.lblFormTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblFormTitle.ForeColor = System.Drawing.Color.FromArgb(52, 211, 153); this.lblFormTitle.Location = new System.Drawing.Point(20, 20);
            this.lblFormTitle.Text = "Revenue Entry"; this.lblFormTitle.Name = "lblFormTitle";

            this.lblMonthLbl.AutoSize = true; this.lblMonthLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblMonthLbl.ForeColor = System.Drawing.Color.FromArgb(100, 100, 160); this.lblMonthLbl.Location = new System.Drawing.Point(20, 65);
            this.lblMonthLbl.Text = "MONTH"; this.lblMonthLbl.Name = "lblMonthLbl";

            this.txtMonth.BackColor = System.Drawing.Color.FromArgb(20, 20, 34); this.txtMonth.ForeColor = System.Drawing.Color.FromArgb(220, 220, 245);
            this.txtMonth.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.txtMonth.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtMonth.Location = new System.Drawing.Point(20, 85); this.txtMonth.Size = new System.Drawing.Size(280, 30); this.txtMonth.Name = "txtMonth";

            this.lblAmountLbl.AutoSize = true; this.lblAmountLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblAmountLbl.ForeColor = System.Drawing.Color.FromArgb(100, 100, 160); this.lblAmountLbl.Location = new System.Drawing.Point(20, 130);
            this.lblAmountLbl.Text = "AMOUNT (PKR)"; this.lblAmountLbl.Name = "lblAmountLbl";

            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(20, 20, 34); this.txtAmount.ForeColor = System.Drawing.Color.FromArgb(220, 220, 245);
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.txtAmount.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtAmount.Location = new System.Drawing.Point(20, 150); this.txtAmount.Size = new System.Drawing.Size(280, 30); this.txtAmount.Name = "txtAmount";

            this.lblSourceLbl.AutoSize = true; this.lblSourceLbl.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold);
            this.lblSourceLbl.ForeColor = System.Drawing.Color.FromArgb(100, 100, 160); this.lblSourceLbl.Location = new System.Drawing.Point(20, 195);
            this.lblSourceLbl.Text = "SOURCE"; this.lblSourceLbl.Name = "lblSourceLbl";

            this.txtSource.BackColor = System.Drawing.Color.FromArgb(20, 20, 34); this.txtSource.ForeColor = System.Drawing.Color.FromArgb(220, 220, 245);
            this.txtSource.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.txtSource.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.txtSource.Location = new System.Drawing.Point(20, 215); this.txtSource.Size = new System.Drawing.Size(280, 30); this.txtSource.Name = "txtSource";

            this.btnAdd.BackColor = System.Drawing.Color.FromArgb(52, 211, 153); this.btnAdd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdd.FlatAppearance.BorderSize = 0; this.btnAdd.ForeColor = System.Drawing.Color.FromArgb(10, 10, 18);
            this.btnAdd.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnAdd.Location = new System.Drawing.Point(20, 265); this.btnAdd.Size = new System.Drawing.Size(280, 42);
            this.btnAdd.Text = "Add Revenue"; this.btnAdd.Name = "btnAdd"; this.btnAdd.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(37, 99, 80); this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.FlatAppearance.BorderSize = 0; this.btnUpdate.ForeColor = System.Drawing.Color.White;
            this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnUpdate.Location = new System.Drawing.Point(20, 318); this.btnUpdate.Size = new System.Drawing.Size(134, 38);
            this.btnUpdate.Text = "Update"; this.btnUpdate.Name = "btnUpdate"; this.btnUpdate.Enabled = false;
            this.btnUpdate.Cursor = System.Windows.Forms.Cursors.Hand; this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);

            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(120, 30, 30); this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDelete.FlatAppearance.BorderSize = 0; this.btnDelete.ForeColor = System.Drawing.Color.White;
            this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnDelete.Location = new System.Drawing.Point(162, 318); this.btnDelete.Size = new System.Drawing.Size(138, 38);
            this.btnDelete.Text = "Delete"; this.btnDelete.Name = "btnDelete"; this.btnDelete.Enabled = false;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand; this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);

            this.btnClear.BackColor = System.Drawing.Color.FromArgb(35, 35, 55); this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.FlatAppearance.BorderSize = 0; this.btnClear.ForeColor = System.Drawing.Color.FromArgb(180, 180, 220);
            this.btnClear.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.btnClear.Location = new System.Drawing.Point(20, 368); this.btnClear.Size = new System.Drawing.Size(280, 34);
            this.btnClear.Text = "Clear Form"; this.btnClear.Name = "btnClear"; this.btnClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);

            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(52, 211, 153);
            this.lblStatus.Location = new System.Drawing.Point(20, 415); this.lblStatus.Size = new System.Drawing.Size(280, 40);
            this.lblStatus.Text = ""; this.lblStatus.Name = "lblStatus";

            this.lblSearchLbl.AutoSize = true; this.lblSearchLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblSearchLbl.ForeColor = System.Drawing.Color.FromArgb(148, 148, 180); this.lblSearchLbl.Location = new System.Drawing.Point(20, 80);
            this.lblSearchLbl.Text = "Search:"; this.lblSearchLbl.Name = "lblSearchLbl";

            this.txtSearch.BackColor = System.Drawing.Color.FromArgb(20, 20, 34); this.txtSearch.ForeColor = System.Drawing.Color.FromArgb(220, 220, 245);
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle; this.txtSearch.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.txtSearch.Location = new System.Drawing.Point(80, 76); this.txtSearch.Size = new System.Drawing.Size(340, 28);
            this.txtSearch.Name = "txtSearch"; this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);

            this.lblCount.AutoSize = true; this.lblCount.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(148, 148, 180); this.lblCount.Location = new System.Drawing.Point(440, 80);
            this.lblCount.Text = "Total: 0"; this.lblCount.Name = "lblCount";

            this.dataGrid.AllowUserToAddRows = false; this.dataGrid.AllowUserToDeleteRows = false; this.dataGrid.AllowUserToResizeRows = false;
            this.dataGrid.BackgroundColor = System.Drawing.Color.FromArgb(26, 26, 42); this.dataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dataGrid.GridColor = System.Drawing.Color.FromArgb(40, 40, 65); this.dataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGrid.ColumnHeadersHeight = 44; this.dataGrid.EnableHeadersVisualStyles = false;
            this.dataGrid.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.dataGrid.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(52, 211, 153);
            this.dataGrid.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            this.dataGrid.DefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(26, 26, 42);
            this.dataGrid.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(240, 240, 255);
            this.dataGrid.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(70, 52, 211, 153);
            this.dataGrid.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.DefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dataGrid.AlternatingRowsDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(22, 22, 36);
            this.dataGrid.AlternatingRowsDefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(240, 240, 255);
            this.dataGrid.AlternatingRowsDefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(70, 52, 211, 153);
            this.dataGrid.AlternatingRowsDefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dataGrid.Font = new System.Drawing.Font("Segoe UI", 9.5F);
            this.dataGrid.Location = new System.Drawing.Point(16, 118); this.dataGrid.Name = "dataGrid";
            this.dataGrid.ReadOnly = true; this.dataGrid.RowHeadersVisible = false; this.dataGrid.RowTemplate.Height = 40;
            this.dataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGrid.Size = new System.Drawing.Size(740, 530);
            this.dataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGrid.SelectionChanged += new System.EventHandler(this.dataGrid_SelectionChanged);

            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F); this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 10, 18); this.ClientSize = new System.Drawing.Size(1100, 700);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None; this.Name = "RevenueForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent; this.Text = "ZeeK - Revenue";
            this.Controls.Add(this.dataGrid); this.Controls.Add(this.lblSearchLbl); this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblCount); this.Controls.Add(this.rightPanel); this.Controls.Add(this.topStrip);
            this.Load += new System.EventHandler(this.RevenueForm_Load);

            ((System.ComponentModel.ISupportInitialize)(this.dataGrid)).EndInit();
            this.topStrip.ResumeLayout(false); this.topStrip.PerformLayout();
            this.rightPanel.ResumeLayout(false); this.rightPanel.PerformLayout();
            this.ResumeLayout(false); this.PerformLayout();
        }
    }
}