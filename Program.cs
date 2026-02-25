using System;
using System.Windows.Forms;

namespace ZeeK
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (!DB.TestConnection())
            {
                MessageBox.Show(
                    "Cannot connect to the database.\n\nPlease make sure:\n• MySQL server is running\n• Database 'zeekdb' exists\n• Credentials in DB.cs are correct",
                    "ZeeK — Connection Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                return;
            }

            Application.Run(new MainForm());
        }
    }
}