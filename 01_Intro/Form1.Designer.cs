namespace _01_Intro
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ClickBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MoveLeftBtn = new System.Windows.Forms.Button();
            this.CSharpBtn = new System.Windows.Forms.Button();
            this.MoveRightBtn = new System.Windows.Forms.Button();
            this.TestBtn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ClickBtn
            // 
            this.ClickBtn.BackColor = System.Drawing.Color.Lime;
            this.ClickBtn.Location = new System.Drawing.Point(235, 269);
            this.ClickBtn.Name = "ClickBtn";
            this.ClickBtn.Size = new System.Drawing.Size(323, 132);
            this.ClickBtn.TabIndex = 0;
            this.ClickBtn.Text = "Натисни";
            this.ClickBtn.UseVisualStyleBackColor = false;
            this.ClickBtn.Click += new System.EventHandler(this.ClickBtn_Click);
            this.ClickBtn.MouseEnter += new System.EventHandler(this.ClickBtn_MouseEnter);
            this.ClickBtn.MouseLeave += new System.EventHandler(this.ClickBtn_MouseLeave);
            // 
            // ExitBtn
            // 
            this.ExitBtn.BackColor = System.Drawing.Color.Cyan;
            this.ExitBtn.Location = new System.Drawing.Point(857, 269);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(337, 132);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Вихід";
            this.ExitBtn.UseVisualStyleBackColor = false;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Display", 48F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(109, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1484, 231);
            this.label1.TabIndex = 2;
            this.label1.Text = "Hello Windows Forms";
            // 
            // MoveLeftBtn
            // 
            this.MoveLeftBtn.Location = new System.Drawing.Point(294, 525);
            this.MoveLeftBtn.Name = "MoveLeftBtn";
            this.MoveLeftBtn.Size = new System.Drawing.Size(188, 58);
            this.MoveLeftBtn.TabIndex = 3;
            this.MoveLeftBtn.Text = "Move Left";
            this.MoveLeftBtn.UseVisualStyleBackColor = true;
            this.MoveLeftBtn.Click += new System.EventHandler(this.MoveLeftBtn_Click);
            // 
            // CSharpBtn
            // 
            this.CSharpBtn.Location = new System.Drawing.Point(701, 528);
            this.CSharpBtn.Name = "CSharpBtn";
            this.CSharpBtn.Size = new System.Drawing.Size(188, 58);
            this.CSharpBtn.TabIndex = 4;
            this.CSharpBtn.Text = "C#";
            this.CSharpBtn.UseVisualStyleBackColor = true;
            this.CSharpBtn.Click += new System.EventHandler(this.CSharpBtn_Click);
            // 
            // MoveRightBtn
            // 
            this.MoveRightBtn.Location = new System.Drawing.Point(1062, 525);
            this.MoveRightBtn.Name = "MoveRightBtn";
            this.MoveRightBtn.Size = new System.Drawing.Size(226, 61);
            this.MoveRightBtn.TabIndex = 5;
            this.MoveRightBtn.Text = "Move Right";
            this.MoveRightBtn.UseVisualStyleBackColor = true;
            this.MoveRightBtn.Click += new System.EventHandler(this.MoveRightBtn_Click);
            // 
            // TestBtn
            // 
            this.TestBtn.Location = new System.Drawing.Point(659, 675);
            this.TestBtn.Name = "TestBtn";
            this.TestBtn.Size = new System.Drawing.Size(230, 87);
            this.TestBtn.TabIndex = 6;
            this.TestBtn.Text = "Test";
            this.TestBtn.UseVisualStyleBackColor = true;
            this.TestBtn.Click += new System.EventHandler(this.TestBtn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 41);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1651, 870);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.TestBtn);
            this.Controls.Add(this.MoveRightBtn);
            this.Controls.Add(this.CSharpBtn);
            this.Controls.Add(this.MoveLeftBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.ClickBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseMove);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ClickBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button MoveLeftBtn;
        private System.Windows.Forms.Button CSharpBtn;
        private System.Windows.Forms.Button MoveRightBtn;
        private System.Windows.Forms.Button TestBtn;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
    }
}
