using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace LibraryManagerPro
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();


        }
     
        private void btnAddBook_Click(object sender, EventArgs e)
        {
            FrmAddBook frm = new FrmAddBook();
            OpenForm(frm);
            lblOperationName.Text = frm.Text;
        }

        private void OpenForm(Form objFrm)
        {
            foreach (Control item in this.spContainer.Panel2.Controls)
            {
                if (item is Form) ((Form)item).Close();
            }

            objFrm.TopLevel = false;
            objFrm.FormBorderStyle = FormBorderStyle.None;
            objFrm.Parent = this.spContainer.Panel2;
            objFrm.Dock = DockStyle.Fill;
            objFrm.Show();
        }

        private void btnBookManage_Click(object sender, EventArgs e)
        {
           
        }

        private void btnBorrowBook_Click(object sender, EventArgs e)
        {
         
        }

        private void btnBookNew_Click(object sender, EventArgs e)
        {
          
        }

        private void btnReturnBook_Click(object sender, EventArgs e)
        {
        }

        private void btnReaderManager_Click(object sender, EventArgs e)
        {
        }

        private void btnModifyPwd_Click(object sender, EventArgs e)
        {
          
        }
        //退出系统
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
