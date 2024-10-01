namespace _20_Project_My_Secret_Folder
{
    partial class NewTextFileForm
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
            label1 = new Label();
            label2 = new Label();
            textBoxFileName = new TextBox();
            label3 = new Label();
            buttonSave = new Button();
            richTextBoxFileContent = new RichTextBox();
            errorProviderText = new ErrorProvider(components);
            errorProviderFileName = new ErrorProvider(components);
            labelErrorFileName = new Label();
            labelErrorContent = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProviderText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFileName).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            label1.Font = new Font("Segoe UI", 24F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(8, 5);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(578, 58);
            label1.TabIndex = 0;
            label1.Text = "Upload your new secret text file";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(23, 261);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(89, 15);
            label2.TabIndex = 1;
            label2.Text = "Enter file name:";
            label2.TextAlign = ContentAlignment.MiddleRight;
            // 
            // textBoxFileName
            // 
            textBoxFileName.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            textBoxFileName.Location = new Point(23, 277);
            textBoxFileName.Margin = new Padding(2, 2, 2, 2);
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(467, 23);
            textBoxFileName.TabIndex = 2;
            textBoxFileName.Validating += ValidateFileName;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(23, 48);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(100, 15);
            label3.TabIndex = 3;
            label3.Text = "Enter file content:";
            label3.TextAlign = ContentAlignment.MiddleRight;
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonSave.Location = new Point(494, 280);
            buttonSave.Margin = new Padding(2, 2, 2, 2);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(78, 20);
            buttonSave.TabIndex = 4;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // richTextBoxFileContent
            // 
            richTextBoxFileContent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            richTextBoxFileContent.Location = new Point(23, 65);
            richTextBoxFileContent.Margin = new Padding(2, 2, 2, 2);
            richTextBoxFileContent.Name = "richTextBoxFileContent";
            richTextBoxFileContent.Size = new Size(549, 179);
            richTextBoxFileContent.TabIndex = 5;
            richTextBoxFileContent.Text = "";
            richTextBoxFileContent.Validating += ValidateText;
            // 
            // errorProviderText
            // 
            errorProviderText.ContainerControl = this;
            // 
            // errorProviderFileName
            // 
            errorProviderFileName.ContainerControl = this;
            // 
            // labelErrorFileName
            // 
            labelErrorFileName.AutoSize = true;
            labelErrorFileName.Location = new Point(23, 302);
            labelErrorFileName.Margin = new Padding(2, 0, 2, 0);
            labelErrorFileName.Name = "labelErrorFileName";
            labelErrorFileName.Size = new Size(12, 15);
            labelErrorFileName.TabIndex = 6;
            labelErrorFileName.Text = "*";
            labelErrorFileName.TextAlign = ContentAlignment.MiddleRight;
            // 
            // labelErrorContent
            // 
            labelErrorContent.AutoSize = true;
            labelErrorContent.Location = new Point(23, 246);
            labelErrorContent.Margin = new Padding(2, 0, 2, 0);
            labelErrorContent.Name = "labelErrorContent";
            labelErrorContent.Size = new Size(12, 15);
            labelErrorContent.TabIndex = 7;
            labelErrorContent.Text = "*";
            labelErrorContent.TextAlign = ContentAlignment.MiddleRight;
            // 
            // NewTextFileForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(595, 324);
            Controls.Add(labelErrorContent);
            Controls.Add(labelErrorFileName);
            Controls.Add(richTextBoxFileContent);
            Controls.Add(buttonSave);
            Controls.Add(label3);
            Controls.Add(textBoxFileName);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2, 2, 2, 2);
            Name = "NewTextFileForm";
            Text = "New Text File";
            ((System.ComponentModel.ISupportInitialize)errorProviderText).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFileName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox textBoxFileName;
        private Label label3;
        private Button buttonSave;
        private RichTextBox richTextBoxFileContent;
        private ErrorProvider errorProviderText;
        private ErrorProvider errorProviderFileName;
        private Label labelErrorFileName;
        private Label labelErrorContent;
    }
}