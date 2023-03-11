namespace _10_RichTextBox
{
    public partial class Form1 : Form
    {
        public string DesktopPath => Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionFont = new Font(FontFamily.GenericMonospace, 30, FontStyle.Bold);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionColor = Color.Cyan;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBackColor = Color.Blue;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionIndent++;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionRightIndent++;    
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = checkBox1.Checked;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            richTextBox1.SaveFile(DesktopPath + @"\document.rtf", RichTextBoxStreamType.RichText);
            MessageBox.Show("Save to file");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            richTextBox1.LoadFile(DesktopPath + @"\document.rtf", RichTextBoxStreamType.RichText);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if( dialog.ShowDialog()== DialogResult.OK )
                richTextBox1.SelectionFont = dialog.Font;   
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bulletToolStripMenuItem_Click(object sender, EventArgs e)
        {
            richTextBox1.SelectionBullet = bulletToolStripMenuItem.Checked;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog dialog = new FontDialog();
            if (dialog.ShowDialog() == DialogResult.OK)
                richTextBox1.SelectionFont = dialog.Font;
        }
    }
}