using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using BLL;
using Models;



namespace LibraryManagerPro
{
    public partial class FrmAdminLogin : Form
    {
      
        public FrmAdminLogin()
        {
            InitializeComponent();

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
           SysAdmin sysAdmin = new SysAdmin();
           sysAdmin.AdminId = Convert.ToInt32(this.txtAdminId.Text.Trim());
            sysAdmin.LoginPwd = this.txtLoginPwd.Text.Trim();
            SysAdminManager sysAdminManager = new SysAdminManager();
            sysAdmin = sysAdminManager.AdminLogin(sysAdmin);
            
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
