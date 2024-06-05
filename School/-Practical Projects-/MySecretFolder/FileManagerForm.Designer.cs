namespace MySecretFolder
{
    partial class FileManagerForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox textBoxFilePath;
        private System.Windows.Forms.Button backBtn;
        private System.Windows.Forms.Button uploadFileBtn;
        private System.Windows.Forms.Button createFolderBtn;
        private System.Windows.Forms.Button createTextFileBtn;
        private System.Windows.Forms.Label labelInfo;
        private System.Windows.Forms.ListView listViewFiles;
        private System.Windows.Forms.Label labelFileName;
        private System.Windows.Forms.Label labelFileType;
        private System.Windows.Forms.Label labelInfoForFile;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            textBoxFilePath = new TextBox();
            backBtn = new Button();
            uploadFileBtn = new Button();
            createFolderBtn = new Button();
            createTextFileBtn = new Button();
            labelInfo = new Label();
            listViewFiles = new ListView();
            labelFileName = new Label();
            labelFileType = new Label();
            labelInfoForFile = new Label();
            backDirButton = new Button();
            SuspendLayout();
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.BackColor = Color.PeachPuff;
            textBoxFilePath.Location = new Point(83, 42);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.Size = new Size(575, 27);
            textBoxFilePath.TabIndex = 0;
            // 
            // backBtn
            // 
            backBtn.BackColor = Color.Teal;
            backBtn.Location = new Point(664, 40);
            backBtn.Name = "backBtn";
            backBtn.Size = new Size(32, 30);
            backBtn.TabIndex = 1;
            backBtn.Text = "↺";
            backBtn.UseVisualStyleBackColor = false;
            // 
            // uploadFileBtn
            // 
            uploadFileBtn.BackColor = Color.Teal;
            uploadFileBtn.Location = new Point(376, 463);
            uploadFileBtn.Name = "uploadFileBtn";
            uploadFileBtn.Size = new Size(100, 30);
            uploadFileBtn.TabIndex = 2;
            uploadFileBtn.Text = "Upload File";
            uploadFileBtn.UseVisualStyleBackColor = false;
            // 
            // createFolderBtn
            // 
            createFolderBtn.BackColor = Color.Teal;
            createFolderBtn.Location = new Point(486, 463);
            createFolderBtn.Name = "createFolderBtn";
            createFolderBtn.Size = new Size(100, 30);
            createFolderBtn.TabIndex = 3;
            createFolderBtn.Text = "Create Folder";
            createFolderBtn.UseVisualStyleBackColor = false;
            // 
            // createTextFileBtn
            // 
            createTextFileBtn.BackColor = Color.Teal;
            createTextFileBtn.Location = new Point(596, 463);
            createTextFileBtn.Name = "createTextFileBtn";
            createTextFileBtn.Size = new Size(100, 30);
            createTextFileBtn.TabIndex = 4;
            createTextFileBtn.Text = "Create Text File";
            createTextFileBtn.UseVisualStyleBackColor = false;
            // 
            // labelInfo
            // 
            labelInfo.Location = new Point(50, 370);
            labelInfo.Name = "labelInfo";
            labelInfo.Size = new Size(650, 20);
            labelInfo.TabIndex = 5;
            labelInfo.Visible = false;
            // 
            // listViewFiles
            // 
            listViewFiles.BackColor = Color.PeachPuff;
            listViewFiles.Location = new Point(46, 76);
            listViewFiles.Name = "listViewFiles";
            listViewFiles.Size = new Size(650, 300);
            listViewFiles.TabIndex = 6;
            listViewFiles.UseCompatibleStateImageBehavior = false;
            listViewFiles.View = View.Details;
            // 
            // labelFileName
            // 
            labelFileName.Location = new Point(50, 531);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(100, 20);
            labelFileName.TabIndex = 7;
            labelFileName.Text = "File Name: --";
            // 
            // labelFileType
            // 
            labelFileType.Location = new Point(600, 531);
            labelFileType.Name = "labelFileType";
            labelFileType.Size = new Size(100, 20);
            labelFileType.TabIndex = 8;
            labelFileType.Text = "File Type: --";
            // 
            // labelInfoForFile
            // 
            labelInfoForFile.Location = new Point(50, 433);
            labelInfoForFile.Name = "labelInfoForFile";
            labelInfoForFile.Size = new Size(300, 60);
            labelInfoForFile.TabIndex = 9;
            labelInfoForFile.Text = "[DELETE] - deletes a file\n[BACKSPACE] - moves the file backwards\n[DRAG-DROP] - moves files into each other";
            // 
            // backDirButton
            // 
            backDirButton.BackColor = Color.Teal;
            backDirButton.Location = new Point(46, 39);
            backDirButton.Name = "backDirButton";
            backDirButton.Size = new Size(31, 30);
            backDirButton.TabIndex = 10;
            backDirButton.Text = "←";
            backDirButton.UseVisualStyleBackColor = false;
            // 
            // FileManagerForm
            // 
            ClientSize = new Size(750, 600);
            Controls.Add(backDirButton);
            Controls.Add(textBoxFilePath);
            Controls.Add(backBtn);
            Controls.Add(uploadFileBtn);
            Controls.Add(createFolderBtn);
            Controls.Add(createTextFileBtn);
            Controls.Add(labelInfo);
            Controls.Add(listViewFiles);
            Controls.Add(labelFileName);
            Controls.Add(labelFileType);
            Controls.Add(labelInfoForFile);
            Name = "FileManagerForm";
            Text = "File Manager";
            ResumeLayout(false);
            PerformLayout();
        }

        private Button backDirButton;
    }
}
