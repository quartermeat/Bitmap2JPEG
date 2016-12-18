using System.Windows.Forms;

namespace B2J.View
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.saveButton = new System.Windows.Forms.Button();
            this.flowLayoutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxLoadedFiles = new System.Windows.Forms.TextBox();
            this.textBoxSavedFiles = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileButton
            // 
            this.openFileButton.Location = new System.Drawing.Point(12, 8);
            this.openFileButton.Name = "openFileButton";
            this.openFileButton.Size = new System.Drawing.Size(102, 33);
            this.openFileButton.TabIndex = 0;
            this.openFileButton.Text = "Open Files";
            this.openFileButton.UseVisualStyleBackColor = true;
            this.openFileButton.Click += new System.EventHandler(this.openFileButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.FileName = "openFileDialog";
            this.openFileDialog.Filter = "BITMAP Files (*.bmp)|*.bmp";
            this.openFileDialog.Multiselect = true;
            this.openFileDialog.Title = "Please select an bitmap file to encode to jpeg.";
            // 
            // saveButton
            // 
            this.saveButton.Enabled = false;
            this.saveButton.Location = new System.Drawing.Point(12, 150);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(102, 33);
            this.saveButton.TabIndex = 2;
            this.saveButton.Text = "Save Files";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // flowLayoutPanel
            // 
            this.flowLayoutPanel.AutoSize = true;
            this.flowLayoutPanel.Location = new System.Drawing.Point(148, 12);
            this.flowLayoutPanel.Name = "flowLayoutPanel";
            this.flowLayoutPanel.Size = new System.Drawing.Size(114, 29);
            this.flowLayoutPanel.TabIndex = 3;
            // 
            // textBoxLoadedFiles
            // 
            this.textBoxLoadedFiles.Location = new System.Drawing.Point(12, 47);
            this.textBoxLoadedFiles.Multiline = true;
            this.textBoxLoadedFiles.Name = "textBoxLoadedFiles";
            this.textBoxLoadedFiles.ReadOnly = true;
            this.textBoxLoadedFiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxLoadedFiles.Size = new System.Drawing.Size(354, 97);
            this.textBoxLoadedFiles.TabIndex = 4;
            // 
            // textBoxSavedFiles
            // 
            this.textBoxSavedFiles.Location = new System.Drawing.Point(12, 189);
            this.textBoxSavedFiles.Multiline = true;
            this.textBoxSavedFiles.Name = "textBoxSavedFiles";
            this.textBoxSavedFiles.ReadOnly = true;
            this.textBoxSavedFiles.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxSavedFiles.Size = new System.Drawing.Size(354, 97);
            this.textBoxSavedFiles.TabIndex = 5;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(378, 303);
            this.Controls.Add(this.textBoxSavedFiles);
            this.Controls.Add(this.textBoxLoadedFiles);
            this.Controls.Add(this.flowLayoutPanel);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.openFileButton);
            this.Name = "MainWindow";
            this.Text = "B2J";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button openFileButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private Button saveButton;
        private FlowLayoutPanel flowLayoutPanel;
        private TextBox textBoxLoadedFiles;
        private TextBox textBoxSavedFiles;
    }
}

