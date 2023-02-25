using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _07_AdittionalForms
{
    public partial class LoginForm : Form
    {
        public LoginInfo LoginInfo { get; set; }
        public LoginForm()
        {
            InitializeComponent();
            LoginInfo = new LoginInfo();
        }
        public LoginForm(LoginInfo info)
        {
            InitializeComponent();
            LoginInfo = info;
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //2
            if(string.IsNullOrWhiteSpace(loginTb.Text)||string.IsNullOrWhiteSpace(passwordTb.Text) )
            {
                MessageBox.Show("Enter login and password!!!");
                return;
            }
            LoginInfo.Login = loginTb.Text;
            LoginInfo.Password = passwordTb.Text;
            this.DialogResult = DialogResult.OK;
            this.Close();
            //1
            //LoginInfo = new LoginInfo()
            //{
            //    Login = loginTb.Text,
            //    Password = passwordTb.Text
            //};
            //this.DialogResult = DialogResult.OK;
            //this.Close();
        }
    }
}
