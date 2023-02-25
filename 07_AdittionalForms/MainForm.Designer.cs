namespace _07_AdittionalForms
{
    partial class MainForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.LoginBtn = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.loginLb = new System.Windows.Forms.Label();
            this.passwordLb = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(376, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(391, 116);
            this.label1.TabIndex = 0;
            this.label1.Text = "Main form";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(39, 563);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(441, 104);
            this.button1.TabIndex = 1;
            this.button1.Text = "Open second Form";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(230, 228);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(188, 71);
            this.label2.TabIndex = 2;
            this.label2.Text = "Name:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(453, 253);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(369, 47);
            this.nameTB.TabIndex = 3;
            // 
            // LoginBtn
            // 
            this.LoginBtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LoginBtn.Location = new System.Drawing.Point(625, 563);
            this.LoginBtn.Name = "LoginBtn";
            this.LoginBtn.Size = new System.Drawing.Size(441, 104);
            this.LoginBtn.TabIndex = 4;
            this.LoginBtn.Text = "Open Login Form";
            this.LoginBtn.UseVisualStyleBackColor = true;
            this.LoginBtn.Click += new System.EventHandler(this.LoginBtn_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(248, 361);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(107, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Login :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(257, 458);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(158, 41);
            this.label4.TabIndex = 6;
            this.label4.Text = "Password :";
            // 
            // loginLb
            // 
            this.loginLb.AutoSize = true;
            this.loginLb.Location = new System.Drawing.Point(453, 361);
            this.loginLb.Name = "loginLb";
            this.loginLb.Size = new System.Drawing.Size(53, 41);
            this.loginLb.TabIndex = 7;
            this.loginLb.Text = ".....";
            // 
            // passwordLb
            // 
            this.passwordLb.AutoSize = true;
            this.passwordLb.Location = new System.Drawing.Point(453, 458);
            this.passwordLb.Name = "passwordLb";
            this.passwordLb.Size = new System.Drawing.Size(60, 41);
            this.passwordLb.TabIndex = 8;
            this.passwordLb.Text = "......";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 770);
            this.Controls.Add(this.passwordLb);
            this.Controls.Add(this.loginLb);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.LoginBtn);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.Button LoginBtn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label loginLb;
        private System.Windows.Forms.Label passwordLb;
    }
}
