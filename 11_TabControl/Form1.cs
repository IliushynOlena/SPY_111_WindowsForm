namespace _11_TabControl
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.TabPages.Clear();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void ClearBtn_Click(object sender, EventArgs e)
        {
            nameTb.Clear();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            TabPage page = new TabPage($"New page {tabControl1.TabPages.Count + 1}");
            
            // label1
            // 
            Label mainLabel = new Label();
            mainLabel.AutoSize = true;
            mainLabel.Font = new System.Drawing.Font("Segoe UI Black", 26.1F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            mainLabel.Location = new System.Drawing.Point(546, 256);
            mainLabel.Size = new System.Drawing.Size(487, 116);
            mainLabel.TabIndex = 0;
            mainLabel.Text = "Hello User";
            // 
            // label2
            // 
            Label namelabel = new Label();
            namelabel.AutoSize = true;
            namelabel.Location = new System.Drawing.Point(257, 476);
            namelabel.Name = "label2";
            namelabel.Size = new System.Drawing.Size(120, 41);
            namelabel.TabIndex = 1;
            namelabel.Text = "Name : ";
            // 
            // nameTb
            // 
            TextBox textBox = new TextBox();
            textBox.Location = new System.Drawing.Point(465, 476);
            textBox.Name = "nameTextBox";
            textBox.Size = new System.Drawing.Size(625, 47);
            textBox.TabIndex = 2;
            // 
            // ClearBtn
            // 
            Button clearButton = new Button();
            clearButton.Location = new System.Drawing.Point(696, 620);
            clearButton.Name = "ClearBtn";
            clearButton.Size = new System.Drawing.Size(243, 117);
            clearButton.TabIndex = 3;
            clearButton.Text = "Clear";
            clearButton.UseVisualStyleBackColor = true;
            clearButton.Click += (s, args) => { textBox.Clear(); };

            page.Controls.Add(mainLabel);
            page.Controls.Add(namelabel);
            page.Controls.Add(textBox);
            page.Controls.Add(clearButton);
            // 
            // page.Controls.
            tabControl1.TabPages.Add(page); 
        }
        TextBox GetSelectedTb()
        {
            foreach (var item in tabControl1.SelectedTab.Controls.OfType<TextBox>())
            {
                if (item.Name == "nameTextBox")
                    return item;
            }
            return null;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if(tabControl1.SelectedIndex != -1)
                tabControl1.TabPages.RemoveAt(tabControl1.SelectedIndex);
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"Name  {GetSelectedTb().Text}");
        }
    }
}