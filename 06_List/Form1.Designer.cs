namespace _06_List
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.showBtn = new System.Windows.Forms.Button();
            this.ordersComboBox = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.AddBtn = new System.Windows.Forms.Button();
            this.DelBtn = new System.Windows.Forms.Button();
            this.InfoBtn = new System.Windows.Forms.Button();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.checkedListBox1 = new System.Windows.Forms.CheckedListBox();
            this.plusBtn = new System.Windows.Forms.Button();
            this.MoveRightBtn = new System.Windows.Forms.Button();
            this.moveLeftBtn = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.showListInfoBtn = new System.Windows.Forms.Button();
            this.removeItemBtn = new System.Windows.Forms.Button();
            this.delCheckedBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Rivne",
            "Lviv",
            "Kyiv",
            "Odessa",
            "Kharkiv"});
            this.comboBox1.Location = new System.Drawing.Point(43, 71);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(302, 254);
            this.comboBox1.TabIndex = 0;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "Rivne",
            "Lviv",
            "Kyiv",
            "Odessa",
            "Kharkiv"});
            this.comboBox2.Location = new System.Drawing.Point(407, 71);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(302, 49);
            this.comboBox2.TabIndex = 1;
            // 
            // comboBox3
            // 
            this.comboBox3.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Items.AddRange(new object[] {
            "Rivne",
            "Lviv",
            "Kyiv",
            "Odessa",
            "Kharkiv"});
            this.comboBox3.Location = new System.Drawing.Point(761, 71);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(302, 49);
            this.comboBox3.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(52, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "Select your city :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(407, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(234, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Select your city :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(761, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(234, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select your city :";
            // 
            // showBtn
            // 
            this.showBtn.Location = new System.Drawing.Point(414, 155);
            this.showBtn.Name = "showBtn";
            this.showBtn.Size = new System.Drawing.Size(295, 116);
            this.showBtn.TabIndex = 6;
            this.showBtn.Text = "Show";
            this.showBtn.UseVisualStyleBackColor = true;
            this.showBtn.Click += new System.EventHandler(this.showBtn_Click);
            // 
            // ordersComboBox
            // 
            this.ordersComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ordersComboBox.FormattingEnabled = true;
            this.ordersComboBox.Location = new System.Drawing.Point(43, 372);
            this.ordersComboBox.Name = "ordersComboBox";
            this.ordersComboBox.Size = new System.Drawing.Size(459, 49);
            this.ordersComboBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(43, 313);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(192, 41);
            this.label4.TabIndex = 8;
            this.label4.Text = "Select order :";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(570, 372);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            20,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(129, 47);
            this.numericUpDown1.TabIndex = 9;
            // 
            // AddBtn
            // 
            this.AddBtn.Location = new System.Drawing.Point(398, 459);
            this.AddBtn.Name = "AddBtn";
            this.AddBtn.Size = new System.Drawing.Size(311, 107);
            this.AddBtn.TabIndex = 10;
            this.AddBtn.Text = "Add New Order";
            this.AddBtn.UseVisualStyleBackColor = true;
            this.AddBtn.Click += new System.EventHandler(this.AddBtn_Click);
            // 
            // DelBtn
            // 
            this.DelBtn.Location = new System.Drawing.Point(398, 610);
            this.DelBtn.Name = "DelBtn";
            this.DelBtn.Size = new System.Drawing.Size(311, 107);
            this.DelBtn.TabIndex = 11;
            this.DelBtn.Text = "Remove Select Order";
            this.DelBtn.UseVisualStyleBackColor = true;
            this.DelBtn.Click += new System.EventHandler(this.DelBtn_Click);
            // 
            // InfoBtn
            // 
            this.InfoBtn.Location = new System.Drawing.Point(398, 772);
            this.InfoBtn.Name = "InfoBtn";
            this.InfoBtn.Size = new System.Drawing.Size(311, 107);
            this.InfoBtn.TabIndex = 12;
            this.InfoBtn.Text = "Show Select Order";
            this.InfoBtn.UseVisualStyleBackColor = true;
            this.InfoBtn.Click += new System.EventHandler(this.InfoBtn_Click);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 41;
            this.listBox1.Items.AddRange(new object[] {
            "red",
            "green",
            "blue",
            "yellow"});
            this.listBox1.Location = new System.Drawing.Point(1149, 80);
            this.listBox1.Name = "listBox1";
            this.listBox1.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.listBox1.Size = new System.Drawing.Size(527, 496);
            this.listBox1.TabIndex = 13;
            // 
            // checkedListBox1
            // 
            this.checkedListBox1.FormattingEnabled = true;
            this.checkedListBox1.Items.AddRange(new object[] {
            "red",
            "green",
            "blue",
            "puprle"});
            this.checkedListBox1.Location = new System.Drawing.Point(1840, 85);
            this.checkedListBox1.Name = "checkedListBox1";
            this.checkedListBox1.Size = new System.Drawing.Size(497, 488);
            this.checkedListBox1.TabIndex = 14;
            // 
            // plusBtn
            // 
            this.plusBtn.Location = new System.Drawing.Point(1560, 610);
            this.plusBtn.Name = "plusBtn";
            this.plusBtn.Size = new System.Drawing.Size(116, 68);
            this.plusBtn.TabIndex = 15;
            this.plusBtn.Text = "+";
            this.plusBtn.UseVisualStyleBackColor = true;
            this.plusBtn.Click += new System.EventHandler(this.plusBtn_Click);
            // 
            // MoveRightBtn
            // 
            this.MoveRightBtn.Location = new System.Drawing.Point(1698, 276);
            this.MoveRightBtn.Name = "MoveRightBtn";
            this.MoveRightBtn.Size = new System.Drawing.Size(116, 78);
            this.MoveRightBtn.TabIndex = 16;
            this.MoveRightBtn.Text = "=>";
            this.MoveRightBtn.UseVisualStyleBackColor = true;
            this.MoveRightBtn.Click += new System.EventHandler(this.MoveRightBtn_Click);
            // 
            // moveLeftBtn
            // 
            this.moveLeftBtn.Location = new System.Drawing.Point(1698, 408);
            this.moveLeftBtn.Name = "moveLeftBtn";
            this.moveLeftBtn.Size = new System.Drawing.Size(116, 78);
            this.moveLeftBtn.TabIndex = 17;
            this.moveLeftBtn.Text = "<=";
            this.moveLeftBtn.UseVisualStyleBackColor = true;
            this.moveLeftBtn.Click += new System.EventHandler(this.moveLeftBtn_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(1152, 619);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(383, 47);
            this.textBox1.TabIndex = 18;
            // 
            // showListInfoBtn
            // 
            this.showListInfoBtn.Location = new System.Drawing.Point(1152, 786);
            this.showListInfoBtn.Name = "showListInfoBtn";
            this.showListInfoBtn.Size = new System.Drawing.Size(268, 107);
            this.showListInfoBtn.TabIndex = 19;
            this.showListInfoBtn.Text = "Show Selection";
            this.showListInfoBtn.UseVisualStyleBackColor = true;
            this.showListInfoBtn.Click += new System.EventHandler(this.showListInfoBtn_Click);
            // 
            // removeItemBtn
            // 
            this.removeItemBtn.Location = new System.Drawing.Point(1493, 786);
            this.removeItemBtn.Name = "removeItemBtn";
            this.removeItemBtn.Size = new System.Drawing.Size(268, 107);
            this.removeItemBtn.TabIndex = 20;
            this.removeItemBtn.Text = "Remove Selected Item";
            this.removeItemBtn.UseVisualStyleBackColor = true;
            this.removeItemBtn.Click += new System.EventHandler(this.removeItemBtn_Click);
            // 
            // delCheckedBtn
            // 
            this.delCheckedBtn.Location = new System.Drawing.Point(2069, 639);
            this.delCheckedBtn.Name = "delCheckedBtn";
            this.delCheckedBtn.Size = new System.Drawing.Size(268, 107);
            this.delCheckedBtn.TabIndex = 21;
            this.delCheckedBtn.Text = "Delete Checked Item";
            this.delCheckedBtn.UseVisualStyleBackColor = true;
            this.delCheckedBtn.Click += new System.EventHandler(this.delCheckedBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2365, 966);
            this.Controls.Add(this.delCheckedBtn);
            this.Controls.Add(this.removeItemBtn);
            this.Controls.Add(this.showListInfoBtn);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.moveLeftBtn);
            this.Controls.Add(this.MoveRightBtn);
            this.Controls.Add(this.plusBtn);
            this.Controls.Add(this.checkedListBox1);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.InfoBtn);
            this.Controls.Add(this.DelBtn);
            this.Controls.Add(this.AddBtn);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ordersComboBox);
            this.Controls.Add(this.showBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button showBtn;
        private System.Windows.Forms.ComboBox ordersComboBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button AddBtn;
        private System.Windows.Forms.Button DelBtn;
        private System.Windows.Forms.Button InfoBtn;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.CheckedListBox checkedListBox1;
        private System.Windows.Forms.Button plusBtn;
        private System.Windows.Forms.Button MoveRightBtn;
        private System.Windows.Forms.Button moveLeftBtn;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button showListInfoBtn;
        private System.Windows.Forms.Button removeItemBtn;
        private System.Windows.Forms.Button delCheckedBtn;
    }
}
