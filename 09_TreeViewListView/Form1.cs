namespace _09_TreeViewListView
{
    public partial class Form1 : Form
    {
        public Form1()
        {
           
            InitializeComponent();
            dirTree.Nodes.Clear();
            LoadImageList();
            LoadDirectories(Environment.GetFolderPath(Environment.SpecialFolder.Desktop), dirTree.Nodes);
            fileList.View = View.Details;
            fileList.Columns.Add("Name").Width = 300;
            fileList.Columns.Add("Extencion").Width = 300;
            fileList.Columns.Add("Create date").Width = 300;
        }
        void LoadImageList()
        {
            ImageList list = new ImageList();
            list.Images.Add(new Bitmap("Images/close_foder.png"));
            list.Images.Add(new Bitmap("Images/open_folder.png"));
            list.Images.Add(new Bitmap("Images/select.png"));
            dirTree.ImageList = list;
            dirTree.ImageList.ImageSize = new Size(50, 50);
        }

        void LoadDirectories(string dirPath, TreeNodeCollection nodes)
        {
            
            DirectoryInfo dir = new DirectoryInfo(dirPath);
            foreach (var subDir in dir.GetDirectories())
            {
                TreeNode newNode = new TreeNode(subDir.Name,0,2);
                newNode.Tag = subDir.FullName;
                nodes.Add(newNode);

                //dirTree.Nodes.Add(subDir.Name);
                if (subDir.GetDirectories().Length > 0)
                    LoadDirectories(subDir.FullName , newNode.Nodes);

               
            }
        }
        private void dirTree_AfterExpand(object sender, TreeViewEventArgs e)
        {
            e.Node.ImageIndex = 1;
        }

        private void dirTree_BeforeCollapse(object sender, TreeViewCancelEventArgs e)
        {
            e.Node.ImageIndex = 0;
        }

        private void dirTree_AfterSelect(object sender, TreeViewEventArgs e)
        {
            fileList.Items.Clear();
            DirectoryInfo dir = new DirectoryInfo(e.Node.Tag.ToString());
            foreach (var file in dir.GetFiles())
            {
                ListViewItem item = new ListViewItem(file.Name);
                item.SubItems.Add(file.Extension);
                item.SubItems.Add(file.CreationTime.ToString());
                //item.ImageIndex = 0;
                fileList.Items.Add(item);
            }

            
        }
    }
}