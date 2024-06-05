namespace MySecretFolder
{
    partial class NewFileForm
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
            components = new System.ComponentModel.Container();
            buttonSave = new Button();
            labelWellcome = new Label();
            buttonOpenFileManager = new Button();
            richTextBoxContent = new RichTextBox();
            label1 = new Label();
            errorProvider = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Teal;
            buttonSave.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(527, 147);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(160, 81);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // labelWellcome
            // 
            labelWellcome.AutoSize = true;
            labelWellcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelWellcome.Location = new Point(67, 52);
            labelWellcome.Name = "labelWellcome";
            labelWellcome.Size = new Size(351, 38);
            labelWellcome.TabIndex = 8;
            labelWellcome.Text = "Upload your secret file text";
            // 
            // buttonOpenFileManager
            // 
            buttonOpenFileManager.BackColor = Color.Teal;
            buttonOpenFileManager.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point);
            buttonOpenFileManager.Location = new Point(527, 308);
            buttonOpenFileManager.Name = "buttonOpenFileManager";
            buttonOpenFileManager.Size = new Size(160, 81);
            buttonOpenFileManager.TabIndex = 10;
            buttonOpenFileManager.Text = "Open File Manager";
            buttonOpenFileManager.UseVisualStyleBackColor = false;
            // 
            // richTextBoxContent
            // 
            richTextBoxContent.BackColor = SystemColors.ActiveBorder;
            richTextBoxContent.EnableAutoDragDrop = true;
            richTextBoxContent.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxContent.Location = new Point(67, 147);
            richTextBoxContent.Name = "richTextBoxContent";
            richTextBoxContent.Size = new Size(386, 242);
            richTextBoxContent.TabIndex = 12;
            richTextBoxContent.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 124);
            label1.Name = "label1";
            label1.Size = new Size(224, 20);
            label1.TabIndex = 13;
            label1.Text = "Attach files by drag and droping";
            // 
            // errorProvider
            // 
            errorProvider.ContainerControl = this;
            // 
            // NewFileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(richTextBoxContent);
            Controls.Add(buttonOpenFileManager);
            Controls.Add(buttonSave);
            Controls.Add(labelWellcome);
            Name = "NewFileForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProvider).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label labelWellcome;
        private Button buttonOpenFileManager;
        private RichTextBox richTextBoxContent;
        private Label label1;
        private ErrorProvider errorProvider;
    }
}