using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using Models;


namespace LibraryManagerPro
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            // show login window
            FrmAdminLogin frmAdminLogin = new FrmAdminLogin();
            DialogResult result = frmAdminLogin.ShowDialog();
            if (result == DialogResult.OK) Application.Run(new FrmMain());
            else Application.Exit();
        }
        // create a global variable for storing current admin information
        public static SysAdmin currentAdmin = null;
    }
}
