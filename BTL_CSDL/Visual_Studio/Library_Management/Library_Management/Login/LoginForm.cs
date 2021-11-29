using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using Bussiness;

namespace Library_Management.Login
{
    public partial class frmLogin : Form
    {
        private UserBusiness userBusiness = new UserBusiness();
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {

            List<User> lstUser = userBusiness.getUser(txtUserName.Text, txtPassWord.Text);
            if(lstUser == null || lstUser.Count <= 0)
            {
                MessageBox.Show("Tai khoan mat khau khong chinh xac");
            } else
            {
                Start startForm = new Start();
                startForm.Show();
                this.Hide();
            }
        }

        private void txtPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;
                btnLogin.PerformClick();
            }
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtPassWord.Focus();
            }
        }
    }
}
