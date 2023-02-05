using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _02_GuessNumber
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text = "Guess my number!";
            BackColor = Color.Yellow;
            ForeColor = Color.Green;
            Size = new Size(1600, 1600);

            button1.Text = "Start!";
            button1.BackColor = Color.Blue;
            button1.Location = new Point(560, 560);
            button1.Size = new Size(300, 300);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int numberMin = 0;
            int numberMax = 1000;
            int quantity = 0;
            while(true)
            {
                quantity++;
                DialogResult res = MessageBox.Show("Your number is more than " + ((numberMin + numberMax) / 2),
                    "Guess number",MessageBoxButtons.YesNoCancel);
                if(res == DialogResult.Yes)
                {
                    numberMin = (numberMin + numberMax) / 2  + 1;
                }
                else
                {
                    numberMax = (numberMin + numberMax) / 2;
                }
                if (numberMin == numberMax)
                    break;
                if(res == DialogResult.Cancel)
                {
                    this.Close();
                }
            }
            MessageBox.Show("Your number " + numberMin + "Quantity" + quantity,
                "Guess number", MessageBoxButtons.OK);
        }
    }
}
