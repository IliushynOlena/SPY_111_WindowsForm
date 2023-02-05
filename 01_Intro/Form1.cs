using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _01_Intro
{
    public partial class Form1 : Form
    {
        int sec = 0;
        Random random;
        Point startLocation;
        public Form1()
        {
            random = new Random();
            InitializeComponent();
            startLocation = CSharpBtn.Location;
        }          

        private void ClickBtn_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello WF","Congratulation", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
        }

        private void ClickBtn_MouseEnter(object sender, EventArgs e)
        {
            ClickBtn.BackColor = Color.Yellow;
        }

        private void ClickBtn_MouseLeave(object sender, EventArgs e)
        {
            ClickBtn.BackColor = Color.Lime;
        }

        private void ExitBtn_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Do you want to exit ? ", "Exit window", MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning)== DialogResult.Yes)
                this.Close();
        }

        private void MoveRightBtn_Click(object sender, EventArgs e)
        {
            CSharpBtn.Location = new Point(CSharpBtn.Location.X - 2, CSharpBtn.Location.Y);
        }

        private void MoveLeftBtn_Click(object sender, EventArgs e)
        {
            CSharpBtn.Location = new Point(CSharpBtn.Location.X + 2, CSharpBtn.Location.Y);
        }

        private void CSharpBtn_Click(object sender, EventArgs e)
        {
            CSharpBtn.Location = startLocation;
        }



        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            this.Text = $"Mouse Position : {e.X} : {e.Y}";
            Point mouse = e.Location;
            if(mouse.X >=  TestBtn.Left - 20 && (mouse.X <= TestBtn.Left + TestBtn.Width + 20))
            {
                if(mouse.X >= TestBtn.Left )
                {
                    TestBtn.Left = TestBtn.Left - 20;
                }
                else
                {
                    TestBtn.Left = TestBtn.Left + 20;
                }
            }

            if(TestBtn.Left < 0)
            {
                TestBtn.Location = new Point(random.Next(this.Width),random.Next(this.Height)); 

               // this.ClientSize.Width
            }

        }

        private void TestBtn_Click(object sender, EventArgs e)
        {
            TestBtn.Text = "You are winner!";
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label2.Text=  (++sec).ToString();
            if(sec == 10)
            {
                TestBtn.BackColor = Color.Red;
                TestBtn.Text = "Catch me!";
                timer1.Stop();
                sec = 0;
            }
        }
    }

 
}
