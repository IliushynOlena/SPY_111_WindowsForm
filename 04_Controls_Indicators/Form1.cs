﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _04_Controls_Indicators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            foreach (var rb in groupBox1.Controls.OfType<RadioButton>())
            {
                rb.CheckedChanged += Rb_CheckedChanged;
            }
            foreach (var rb in groupBox2.Controls.OfType<RadioButton>())
            {
                rb.CheckedChanged += Rb_CheckedChanged;
            }
        }

        private void Rb_CheckedChanged(object? sender, EventArgs e)
        {
            bool isFirstGroupChecked = false;
            bool isSecondGroupChecked = false;
            foreach (var rb in groupBox1.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    isFirstGroupChecked = true;
                    break;
                }
            }
            foreach (var rb in groupBox2.Controls.OfType<RadioButton>())
            {
                if (rb.Checked)
                {
                    isSecondGroupChecked = true;
                    break;
                }

            }

            button1.Enabled = isFirstGroupChecked && isSecondGroupChecked;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float total = 0;
            foreach (var rb in groupBox1.Controls.OfType<RadioButton>().Union(groupBox2.Controls.OfType<RadioButton>()))
            {
                if (rb.Checked)
                {
                    total += float.Parse( rb.Tag.ToString());
                }
            }
            MessageBox.Show($"Ordered! \n Total Price : {total} $");
            textBox1.Text += $"#123 {DateTime.Now.ToShortDateString()}  {total} $ {Environment.NewLine}";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var rb in groupBox1.Controls.OfType<RadioButton>().Union(groupBox2.Controls.OfType<RadioButton>()))
            {
               rb.Checked = false;
            }
        }
    }
}
