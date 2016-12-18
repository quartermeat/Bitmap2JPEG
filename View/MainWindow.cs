using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using B2J.Model;

namespace B2J.View
{
    public partial class MainWindow : Form
    {
        
        public MainWindow()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            textBoxLoadedFiles.Clear();

            foreach(var fileName in openFileDialog.FileNames)
            {
                textBoxLoadedFiles.AppendText(fileName + "\n");
            }

            saveButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            textBoxSavedFiles.Clear();

            if (folderBrowserDialog.ShowDialog() != DialogResult.OK) return;

            //MessageBox.Show(folderBrowserDialog.SelectedPath);

            foreach(var fileName in openFileDialog.FileNames)
            {
                using (var image = Image.FromFile(fileName))
                {
                    string saveName = folderBrowserDialog.SelectedPath + @"\" + Path.GetFileNameWithoutExtension(fileName) + ".jpeg";
                    image.SaveJpeg(saveName, 100);
                    textBoxSavedFiles.AppendText(saveName + "\n");
                }
            }
            
            openFileDialog.Dispose();
            saveButton.Enabled = false;
        }

    }
}
