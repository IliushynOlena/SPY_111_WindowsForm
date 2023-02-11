using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _03__Base_Controls_Buttons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
          
        }
        private bool IsSelectedMeal()
        {
            return (checkBox1.Checked || checkBox2.Checked || checkBox3.Checked);
        }
        private void ClearTextBox()
        {
            foreach (var item in this.Controls.OfType<TextBoxBase>())
            {
                item.Text = "";
            }
            foreach (var item in this.Controls.OfType<CheckBox>())
            {
                item.Checked = false;
            }
        }
        private void OrderBtn_Click(object sender, EventArgs e)
        {
            if (!IsSelectedMeal())
            {
                MessageBox.Show("Select at least one meal!");
                return;
            }
            StringBuilder res = new StringBuilder("===========ORDER==========");
            res.Append("Meals : ");
            if (checkBox1.Checked)
                res.Append(checkBox1.Text);
            if (checkBox2.Checked)
                res.Append(checkBox2.Text);
            if (checkBox3.Checked)
                res.Append(checkBox3.Text);
            res.AppendLine(); res.Append("Delivery : ");
            if (radioButton1.Checked)
                res.Append(radioButton1.Text);
            if (radioButton2.Checked)
                res.Append(radioButton2.Text);
            if (radioButton3.Checked)
                res.Append(radioButton3.Text);
            res.AppendLine(); res.Append("Login : " + textBox1.Text); res.AppendLine();
            res.Append("Passord : " + textBox2.Text); res.AppendLine();
            res.Append("Phone : " + maskedTextBox1.Text); res.AppendLine(); res.Append("Date : " + dateTimePicker1.Value.ToString()); res.AppendLine();
            res.Append("From : " + monthCalendar1.SelectionStart); res.AppendLine();
            res.Append("To : " + monthCalendar1.SelectionEnd); res.AppendLine(); res.Append("Count : " + numericUpDown1.Value); res.AppendLine(); 
            MessageBox.Show(res.ToString(), "Order"); 
            ClearTextBox();
        }
    }
}
