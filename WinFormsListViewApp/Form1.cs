namespace WinFormsListViewApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSmall_Click(object sender, EventArgs e)
        {
            listViewDirs.View = View.SmallIcon;
        }

        private void btnLarge_Click(object sender, EventArgs e)
        {
            listViewDirs.View = View.LargeIcon;
        }

        private void btnDetail_Click(object sender, EventArgs e)
        {
            listViewDirs.View = View.Details;
        }

        private void btnList_Click(object sender, EventArgs e)
        {
            listViewDirs.View = View.List;
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text;
            string[] folders = Directory.GetDirectories(path);
            string[] files = Directory.GetFiles(path);
            foreach(string dir in folders)
            {
                ListViewItem item = new ListViewItem();
                item.Text = dir.Remove(0, dir.LastIndexOf(@"\") + 1);
                item.ImageIndex = 0;
                listViewDirs.Items.Add(item);
            }
            foreach (string file in files) 
            {
                ListViewItem item = new ListViewItem();
                item.Text = file.Remove(0, file.LastIndexOf(@"\") + 1);
                string extens = file.Remove(0, file.LastIndexOf(".") + 1);
                switch (extens)
                {
                    case "txt": item.ImageIndex = 2; break;
                    case "pdf": item.ImageIndex = 3; break;
                    case "docx": item.ImageIndex = 4; break;
                    case "jpg": item.ImageIndex = 5; break;
                    case "png": item.ImageIndex = 6; break;
                    default:
                        item.ImageIndex = 1;
                        break;
                }
                
                listViewDirs.Items.Add(item);
            }
        }
    }
}