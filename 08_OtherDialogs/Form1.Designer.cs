namespace _08_OtherDialogs
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
            this.OpenBtn = new System.Windows.Forms.Button();
            this.SaveBtn = new System.Windows.Forms.Button();
            this.BtnOpen = new System.Windows.Forms.Button();
            this.BackColorBtn = new System.Windows.Forms.Button();
            this.FontBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // OpenBtn
            // 
            this.OpenBtn.Location = new System.Drawing.Point(69, 71);
            this.OpenBtn.Name = "OpenBtn";
            this.OpenBtn.Size = new System.Drawing.Size(188, 58);
            this.OpenBtn.TabIndex = 0;
            this.OpenBtn.Text = "Open";
            this.OpenBtn.UseVisualStyleBackColor = true;
            this.OpenBtn.Click += new System.EventHandler(this.OpenBtn_Click);
            // 
            // SaveBtn
            // 
            this.SaveBtn.Location = new System.Drawing.Point(340, 71);
            this.SaveBtn.Name = "SaveBtn";
            this.SaveBtn.Size = new System.Drawing.Size(188, 58);
            this.SaveBtn.TabIndex = 1;
            this.SaveBtn.Text = "Save";
            this.SaveBtn.UseVisualStyleBackColor = true;
            this.SaveBtn.Click += new System.EventHandler(this.SaveBtn_Click);
            // 
            // BtnOpen
            // 
            this.BtnOpen.Location = new System.Drawing.Point(1119, 71);
            this.BtnOpen.Name = "BtnOpen";
            this.BtnOpen.Size = new System.Drawing.Size(263, 58);
            this.BtnOpen.TabIndex = 2;
            this.BtnOpen.Text = "Open Folder";
            this.BtnOpen.UseVisualStyleBackColor = true;
            this.BtnOpen.Click += new System.EventHandler(this.BtnOpen_Click);
            // 
            // BackColorBtn
            // 
            this.BackColorBtn.Location = new System.Drawing.Point(60, 756);
            this.BackColorBtn.Name = "BackColorBtn";
            this.BackColorBtn.Size = new System.Drawing.Size(318, 58);
            this.BackColorBtn.TabIndex = 3;
            this.BackColorBtn.Text = "Background Color";
            this.BackColorBtn.UseVisualStyleBackColor = true;
            this.BackColorBtn.Click += new System.EventHandler(this.BackColorBtn_Click);
            // 
            // FontBtn
            // 
            this.FontBtn.Location = new System.Drawing.Point(527, 756);
            this.FontBtn.Name = "FontBtn";
            this.FontBtn.Size = new System.Drawing.Size(188, 58);
            this.FontBtn.TabIndex = 4;
            this.FontBtn.Text = "Font";
            this.FontBtn.UseVisualStyleBackColor = true;
            this.FontBtn.Click += new System.EventHandler(this.FontBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(69, 201);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.textBox1.Size = new System.Drawing.Size(729, 509);
            this.textBox1.TabIndex = 5;
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 41;
            this.listBox1.Location = new System.Drawing.Point(823, 198);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(933, 496);
            this.listBox1.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1793, 917);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.FontBtn);
            this.Controls.Add(this.BackColorBtn);
            this.Controls.Add(this.BtnOpen);
            this.Controls.Add(this.SaveBtn);
            this.Controls.Add(this.OpenBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button OpenBtn;
        private System.Windows.Forms.Button SaveBtn;
        private System.Windows.Forms.Button BtnOpen;
        private System.Windows.Forms.Button BackColorBtn;
        private System.Windows.Forms.Button FontBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ListBox listBox1;
    }
}
