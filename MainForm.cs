using System;
using System.Drawing;
using System.Windows.Forms;

namespace ZeeK
{
    public partial class MainForm : Form
    {
        private Point _dragStart;

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Opacity = 0;
            var timer = new Timer { Interval = 15 };
            double opacity = 0;
            timer.Tick += (s, ev) =>
            {
                opacity += 0.06;
                if (opacity >= 1) { opacity = 1; timer.Stop(); }
                this.Opacity = opacity;
            };
            timer.Start();
        }

        private void btnEmployees_Click(object sender, EventArgs e)
        {
            new EmployeeForm().ShowDialog();
        }

        private void btnProjects_Click(object sender, EventArgs e)
        {
            new ProjectsForm().ShowDialog();
        }

        private void btnRevenue_Click(object sender, EventArgs e)
        {
            new RevenueForm().ShowDialog();
        }

        private void btnClients_Click(object sender, EventArgs e)
        {
            new ClientsForm().ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void TopBar_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _dragStart = e.Location;
                topBar.MouseMove += TopBar_MouseMove;
                topBar.MouseUp += TopBar_MouseUp;
            }
        }

        private void TopBar_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var p = this.Location;
                p.X += e.X - _dragStart.X;
                p.Y += e.Y - _dragStart.Y;
                this.Location = p;
            }
        }

        private void TopBar_MouseUp(object sender, MouseEventArgs e)
        {
            topBar.MouseMove -= TopBar_MouseMove;
            topBar.MouseUp -= TopBar_MouseUp;
        }
    }
}