using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;

namespace MySecretFolder
{
    public partial class NewFolderForm : Form
    {
        private string currentFilePath;
        public string FolderName { get; private set; }

        public NewFolderForm(string path)
        {
            InitializeComponent();
            currentFilePath = path;
        }

        private void enterBtn_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                FolderName = textBoxFolderName.Text.Trim();
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void validateTextBoxFolderName(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFolderName.Text) || Directory.Exists(Path.Combine(currentFilePath, textBoxFolderName.Text)))
            {
                e.Cancel = true;
                SetErrorMessage("Invalid folder name or folder already exists.");
            }
            else
            {
                errorProviderForFolderName.SetError(textBoxFolderName, string.Empty);
                labelErrorMessage.Text = string.Empty;
            }
        }

        private void SetErrorMessage(string message)
        {
            errorProviderForFolderName.SetError(textBoxFolderName, message);
            labelErrorMessage.Text = message;
        }
    }
}
