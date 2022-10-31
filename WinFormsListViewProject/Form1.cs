namespace WinFormsListViewProject
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            string path = txtPath.Text;
            string[] files = Directory.GetFiles(path);
            string extension;

            foreach (string file in files)
            {
                ListViewItem item = new();
                item.Text = file;
                extension = file.Substring(file.LastIndexOf('.') + 1);
                if (extension == "txt")
                    item.ImageIndex = 1;
                else
                    item.ImageIndex = 0;

                lstViewDirectory.Items.Add(item);
            }
        }
    }
}