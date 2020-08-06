using System;
using System.IO;
using System.Windows.Forms;

namespace filewatcher
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void fileSystemWatcher2_Changed(object sender, System.IO.FileSystemEventArgs e)
        {
            MessageBox.Show(string.Format("File_Changed {0} {1}", e.FullPath, e.Name));
        }

        private void fileSystemWatcher2_Created(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show(string.Format("File_Created {0} {1}", e.FullPath, e.Name));

        }

        private void fileSystemWatcher2_Deleted(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show(string.Format("File_Deleted {0} {1}", e.FullPath, e.Name));

        }

        private void fileSystemWatcher2_Renamed(object sender, RenamedEventArgs e)
        {
            MessageBox.Show(string.Format("File_Renamed {0} {1}", e.FullPath, e.Name));

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
