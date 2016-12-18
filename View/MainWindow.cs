using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using B2J.Model;

namespace B2J
{
    public partial class MainWindow : Form
    {
        private List<string> fileNamesList;
        private List<PictureBox> pictureBoxList; 

        public MainWindow()
        {
            InitializeComponent();
        }

        private void openFileButton_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;
            
            fileNamesList = new List<string>();
            pictureBoxList = new List<PictureBox>();

            int index = 0;
            foreach (var currentFile in openFileDialog.FileNames)
            {
                using (var image = new Bitmap(currentFile))
                {
                    fileNamesList.Add(currentFile);
                    var currentPictureBox = new PictureBox();
                    currentPictureBox.Name = "pictureBox" + index;
                    currentPictureBox.Size = new Size(49, 33);
                    currentPictureBox.TabIndex = index;
                    currentPictureBox.TabStop = false;
                    currentPictureBox.SizeMode = PictureBoxSizeMode.Zoom;
                    currentPictureBox.Image = image;
                    
                    pictureBoxList.Add(currentPictureBox);
                    flowLayoutPanel.Controls.Add(currentPictureBox);
                    index++;
                }    
            }

            saveButton.Enabled = true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            string fileNameStringList = "";

            for(int i = 0; i < fileNamesList.Count; i++)
            {
                string saveName = Path.GetDirectoryName(fileNamesList[i]) + @"\" + Path.GetFileNameWithoutExtension(fileNamesList[i]) + ".jpeg";
                pictureBoxList[i].Image.SaveJpeg(saveName, 100);
                fileNameStringList += saveName + "\n";
            }
            
            MessageBox.Show("Saved images as: \n" + fileNameStringList);
        }

    }
}
