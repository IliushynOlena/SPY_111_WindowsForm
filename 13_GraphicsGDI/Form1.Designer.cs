namespace _13_GraphicsGDI
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
            this.DrawBtn = new System.Windows.Forms.Button();
            this.colorCb = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // DrawBtn
            // 
            this.DrawBtn.Location = new System.Drawing.Point(1361, 89);
            this.DrawBtn.Name = "DrawBtn";
            this.DrawBtn.Size = new System.Drawing.Size(321, 129);
            this.DrawBtn.TabIndex = 0;
            this.DrawBtn.Text = "Draw";
            this.DrawBtn.UseVisualStyleBackColor = true;
            this.DrawBtn.Click += new System.EventHandler(this.DrawBtn_Click);
            // 
            // colorCb
            // 
            this.colorCb.FormattingEnabled = true;
            this.colorCb.Location = new System.Drawing.Point(5, 8);
            this.colorCb.Name = "colorCb";
            this.colorCb.Size = new System.Drawing.Size(350, 49);
            this.colorCb.TabIndex = 1;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(395, 11);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(376, 49);
            this.comboBox1.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1827, 915);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.colorCb);
            this.Controls.Add(this.DrawBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseDown);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button DrawBtn;
        private System.Windows.Forms.ComboBox colorCb;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}
