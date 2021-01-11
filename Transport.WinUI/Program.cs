using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Transport.WinUI.Vozaci;
using System.Windows.Forms;

namespace Transport.WinUI
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            var frmLogin = new frmLogin();
            if (frmLogin.ShowDialog() == DialogResult.OK)
                Application.Run(new frmIndex());
        }
    }
}
