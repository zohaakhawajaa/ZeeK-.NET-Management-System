namespace ZeeK
{
    partial class MainForm
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel topBar;
        private System.Windows.Forms.Label lblLogo;
        private System.Windows.Forms.Label lblTagline;
        private System.Windows.Forms.Label lblWelcome;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblNav;
        private System.Windows.Forms.Label lblDashTitle;
        private System.Windows.Forms.Label lblDashSub;
        private System.Windows.Forms.Button btnEmployees;
        private System.Windows.Forms.Button btnProjects;
        private System.Windows.Forms.Button btnRevenue;
        private System.Windows.Forms.Button btnClients;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnMinimize;
        private System.Windows.Forms.Panel cardEmp;
        private System.Windows.Forms.Panel cardProj;
        private System.Windows.Forms.Panel cardRev;
        private System.Windows.Forms.Label lblEmpVal;
        private System.Windows.Forms.Label lblEmpLbl;
        private System.Windows.Forms.Label lblProjVal;
        private System.Windows.Forms.Label lblProjLbl;
        private System.Windows.Forms.Label lblRevVal;
        private System.Windows.Forms.Label lblRevLbl;

        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.topBar = new System.Windows.Forms.Panel();
            this.lblLogo = new System.Windows.Forms.Label();
            this.lblTagline = new System.Windows.Forms.Label();
            this.lblWelcome = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblNav = new System.Windows.Forms.Label();
            this.lblDashTitle = new System.Windows.Forms.Label();
            this.lblDashSub = new System.Windows.Forms.Label();
            this.btnEmployees = new System.Windows.Forms.Button();
            this.btnProjects = new System.Windows.Forms.Button();
            this.btnRevenue = new System.Windows.Forms.Button();
            this.btnClients = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnMinimize = new System.Windows.Forms.Button();
            this.cardEmp = new System.Windows.Forms.Panel();
            this.cardProj = new System.Windows.Forms.Panel();
            this.cardRev = new System.Windows.Forms.Panel();
            this.lblEmpVal = new System.Windows.Forms.Label();
            this.lblEmpLbl = new System.Windows.Forms.Label();
            this.lblProjVal = new System.Windows.Forms.Label();
            this.lblProjLbl = new System.Windows.Forms.Label();
            this.lblRevVal = new System.Windows.Forms.Label();
            this.lblRevLbl = new System.Windows.Forms.Label();

            this.sidePanel.SuspendLayout();
            this.topBar.SuspendLayout();
            this.cardEmp.SuspendLayout();
            this.cardProj.SuspendLayout();
            this.cardRev.SuspendLayout();
            this.SuspendLayout();

            // sidePanel
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Width = 250;
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Controls.Add(this.lblLogo);
            this.sidePanel.Controls.Add(this.lblTagline);
            this.sidePanel.Controls.Add(this.lblNav);
            this.sidePanel.Controls.Add(this.btnEmployees);
            this.sidePanel.Controls.Add(this.btnProjects);
            this.sidePanel.Controls.Add(this.btnRevenue);
            this.sidePanel.Controls.Add(this.btnClients);
            this.sidePanel.Controls.Add(this.lblStatus);

            this.lblLogo.AutoSize = true;
            this.lblLogo.Font = new System.Drawing.Font("Segoe UI Black", 26F, System.Drawing.FontStyle.Bold);
            this.lblLogo.ForeColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.lblLogo.Location = new System.Drawing.Point(24, 30);
            this.lblLogo.Text = "ZeeK";
            this.lblLogo.Name = "lblLogo";

            this.lblTagline.AutoSize = true;
            this.lblTagline.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblTagline.ForeColor = System.Drawing.Color.FromArgb(148, 148, 180);
            this.lblTagline.Location = new System.Drawing.Point(26, 78);
            this.lblTagline.Text = "Enterprise Solutions";
            this.lblTagline.Name = "lblTagline";

            this.lblNav.AutoSize = true;
            this.lblNav.Font = new System.Drawing.Font("Segoe UI", 7.5F, System.Drawing.FontStyle.Bold);
            this.lblNav.ForeColor = System.Drawing.Color.FromArgb(70, 70, 100);
            this.lblNav.Location = new System.Drawing.Point(26, 120);
            this.lblNav.Text = "MODULES";
            this.lblNav.Name = "lblNav";

            this.btnEmployees.BackColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.btnEmployees.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployees.FlatAppearance.BorderSize = 0;
            this.btnEmployees.ForeColor = System.Drawing.Color.White;
            this.btnEmployees.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnEmployees.Location = new System.Drawing.Point(14, 146);
            this.btnEmployees.Size = new System.Drawing.Size(222, 42);
            this.btnEmployees.Text = "Employees";
            this.btnEmployees.Name = "btnEmployees";
            this.btnEmployees.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployees.Click += new System.EventHandler(this.btnEmployees_Click);

            this.btnProjects.BackColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.btnProjects.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProjects.FlatAppearance.BorderSize = 0;
            this.btnProjects.ForeColor = System.Drawing.Color.FromArgb(200, 200, 230);
            this.btnProjects.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnProjects.Location = new System.Drawing.Point(14, 196);
            this.btnProjects.Size = new System.Drawing.Size(222, 42);
            this.btnProjects.Text = "Projects";
            this.btnProjects.Name = "btnProjects";
            this.btnProjects.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProjects.Click += new System.EventHandler(this.btnProjects_Click);

            this.btnRevenue.BackColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.btnRevenue.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRevenue.FlatAppearance.BorderSize = 0;
            this.btnRevenue.ForeColor = System.Drawing.Color.FromArgb(200, 200, 230);
            this.btnRevenue.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnRevenue.Location = new System.Drawing.Point(14, 246);
            this.btnRevenue.Size = new System.Drawing.Size(222, 42);
            this.btnRevenue.Text = "Revenue";
            this.btnRevenue.Name = "btnRevenue";
            this.btnRevenue.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRevenue.Click += new System.EventHandler(this.btnRevenue_Click);

            this.btnClients.BackColor = System.Drawing.Color.FromArgb(30, 30, 50);
            this.btnClients.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClients.FlatAppearance.BorderSize = 0;
            this.btnClients.ForeColor = System.Drawing.Color.FromArgb(200, 200, 230);
            this.btnClients.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.btnClients.Location = new System.Drawing.Point(14, 296);
            this.btnClients.Size = new System.Drawing.Size(222, 42);
            this.btnClients.Text = "Clients";
            this.btnClients.Name = "btnClients";
            this.btnClients.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClients.Click += new System.EventHandler(this.btnClients_Click);

            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Segoe UI", 8.5F);
            this.lblStatus.ForeColor = System.Drawing.Color.FromArgb(52, 211, 153);
            this.lblStatus.Location = new System.Drawing.Point(20, 640);
            this.lblStatus.Text = "Connected to zeekdb";
            this.lblStatus.Name = "lblStatus";

            // topBar
            this.topBar.BackColor = System.Drawing.Color.FromArgb(18, 18, 30);
            this.topBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBar.Height = 56;
            this.topBar.Name = "topBar";
            this.topBar.Controls.Add(this.lblWelcome);
            this.topBar.Controls.Add(this.btnMinimize);
            this.topBar.Controls.Add(this.btnClose);
            this.topBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.TopBar_MouseDown);

            this.lblWelcome.AutoSize = true;
            this.lblWelcome.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.lblWelcome.ForeColor = System.Drawing.Color.FromArgb(240, 240, 255);
            this.lblWelcome.Location = new System.Drawing.Point(270, 16);
            this.lblWelcome.Text = "Welcome back — Dashboard";
            this.lblWelcome.Name = "lblWelcome";

            this.btnMinimize.BackColor = System.Drawing.Color.FromArgb(40, 40, 60);
            this.btnMinimize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMinimize.FlatAppearance.BorderSize = 0;
            this.btnMinimize.ForeColor = System.Drawing.Color.White;
            this.btnMinimize.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnMinimize.Location = new System.Drawing.Point(1112, 14);
            this.btnMinimize.Size = new System.Drawing.Size(38, 28);
            this.btnMinimize.Text = "_";
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);

            this.btnClose.BackColor = System.Drawing.Color.FromArgb(160, 40, 40);
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.ForeColor = System.Drawing.Color.White;
            this.btnClose.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            this.btnClose.Location = new System.Drawing.Point(1152, 14);
            this.btnClose.Size = new System.Drawing.Size(38, 28);
            this.btnClose.Text = "X";
            this.btnClose.Name = "btnClose";
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);

            // Stat Cards
            this.cardEmp.BackColor = System.Drawing.Color.FromArgb(26, 26, 42);
            this.cardEmp.Location = new System.Drawing.Point(280, 90);
            this.cardEmp.Size = new System.Drawing.Size(240, 100);
            this.cardEmp.Name = "cardEmp";
            this.cardEmp.Controls.Add(this.lblEmpLbl);
            this.cardEmp.Controls.Add(this.lblEmpVal);

            this.lblEmpLbl.AutoSize = true;
            this.lblEmpLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblEmpLbl.ForeColor = System.Drawing.Color.FromArgb(148, 148, 180);
            this.lblEmpLbl.Location = new System.Drawing.Point(14, 14);
            this.lblEmpLbl.Text = "Employees";
            this.lblEmpLbl.Name = "lblEmpLbl";

            this.lblEmpVal.AutoSize = true;
            this.lblEmpVal.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold);
            this.lblEmpVal.ForeColor = System.Drawing.Color.FromArgb(99, 102, 241);
            this.lblEmpVal.Location = new System.Drawing.Point(14, 38);
            this.lblEmpVal.Text = "3";
            this.lblEmpVal.Name = "lblEmpVal";

            this.cardProj.BackColor = System.Drawing.Color.FromArgb(26, 26, 42);
            this.cardProj.Location = new System.Drawing.Point(540, 90);
            this.cardProj.Size = new System.Drawing.Size(240, 100);
            this.cardProj.Name = "cardProj";
            this.cardProj.Controls.Add(this.lblProjLbl);
            this.cardProj.Controls.Add(this.lblProjVal);

            this.lblProjLbl.AutoSize = true;
            this.lblProjLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblProjLbl.ForeColor = System.Drawing.Color.FromArgb(148, 148, 180);
            this.lblProjLbl.Location = new System.Drawing.Point(14, 14);
            this.lblProjLbl.Text = "Projects";
            this.lblProjLbl.Name = "lblProjLbl";

            this.lblProjVal.AutoSize = true;
            this.lblProjVal.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold);
            this.lblProjVal.ForeColor = System.Drawing.Color.FromArgb(250, 204, 21);
            this.lblProjVal.Location = new System.Drawing.Point(14, 38);
            this.lblProjVal.Text = "1";
            this.lblProjVal.Name = "lblProjVal";

            this.cardRev.BackColor = System.Drawing.Color.FromArgb(26, 26, 42);
            this.cardRev.Location = new System.Drawing.Point(800, 90);
            this.cardRev.Size = new System.Drawing.Size(240, 100);
            this.cardRev.Name = "cardRev";
            this.cardRev.Controls.Add(this.lblRevLbl);
            this.cardRev.Controls.Add(this.lblRevVal);

            this.lblRevLbl.AutoSize = true;
            this.lblRevLbl.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblRevLbl.ForeColor = System.Drawing.Color.FromArgb(148, 148, 180);
            this.lblRevLbl.Location = new System.Drawing.Point(14, 14);
            this.lblRevLbl.Text = "Revenue";
            this.lblRevLbl.Name = "lblRevLbl";

            this.lblRevVal.AutoSize = true;
            this.lblRevVal.Font = new System.Drawing.Font("Segoe UI Black", 24F, System.Drawing.FontStyle.Bold);
            this.lblRevVal.ForeColor = System.Drawing.Color.FromArgb(52, 211, 153);
            this.lblRevVal.Location = new System.Drawing.Point(14, 38);
            this.lblRevVal.Text = "50K";
            this.lblRevVal.Name = "lblRevVal";

            this.lblDashTitle = new System.Windows.Forms.Label();
            this.lblDashTitle.AutoSize = true;
            this.lblDashTitle.Font = new System.Drawing.Font("Segoe UI Black", 18F, System.Drawing.FontStyle.Bold);
            this.lblDashTitle.ForeColor = System.Drawing.Color.FromArgb(240, 240, 255);
            this.lblDashTitle.Location = new System.Drawing.Point(280, 20);
            this.lblDashTitle.Text = "Dashboard Overview";
            this.lblDashTitle.Name = "lblDashTitle";

            this.lblDashSub = new System.Windows.Forms.Label();
            this.lblDashSub.AutoSize = true;
            this.lblDashSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.lblDashSub.ForeColor = System.Drawing.Color.FromArgb(148, 148, 180);
            this.lblDashSub.Location = new System.Drawing.Point(282, 52);
            this.lblDashSub.Text = "ZeeK Enterprise — All systems operational";
            this.lblDashSub.Name = "lblDashSub";

            // Form
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(10, 10, 18);
            this.ClientSize = new System.Drawing.Size(1200, 720);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimumSize = new System.Drawing.Size(1000, 600);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ZeeK — Enterprise Dashboard";
            this.Controls.Add(this.lblDashTitle);
            this.Controls.Add(this.lblDashSub);
            this.Controls.Add(this.cardEmp);
            this.Controls.Add(this.cardProj);
            this.Controls.Add(this.cardRev);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.topBar);
            this.Load += new System.EventHandler(this.MainForm_Load);

            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.topBar.ResumeLayout(false);
            this.topBar.PerformLayout();
            this.cardEmp.ResumeLayout(false);
            this.cardEmp.PerformLayout();
            this.cardProj.ResumeLayout(false);
            this.cardProj.PerformLayout();
            this.cardRev.ResumeLayout(false);
            this.cardRev.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}