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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //1
            //SecondForm form = new SecondForm();
            //form.Show();//in nonmodal mode
            //form.ShowDialog();//in modal mode
            //2 using constructor
            //Open second Form
            //
            //SecondForm form = new SecondForm(name);            
            //form.Show();//in nonmodal mode                      

            //3 - using property
            //string name = nameTB.Text;
            //SecondForm form = new SecondForm();
            //form.UserName = name;
            //form.Show();

            //4 using custom Show()/ShowDialog methos
            string name = nameTB.Text;
            SecondForm form = new SecondForm();
            form.Show(name);

        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            //LoginInfo info = null;
            //LoginForm form = new LoginForm();
            //if (form.ShowDialog() == DialogResult.OK)
            //{
            //    //using child form property
            //    info = form.LoginInfo;
            //    loginLb.Text = info.Login;
            //    passwordLb.Text = info.Password;
            //}
            LoginInfo info = new LoginInfo();
            LoginForm form = new LoginForm(info);
            if (form.ShowDialog() == DialogResult.OK)
            {
                //using child form property             
                loginLb.Text = info.Login;
                passwordLb.Text = info.Password;
            }


        }
    }
}
