namespace MySecretFolder
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
            buttonSave = new Button();
            labelWelcome = new Label();
            labelEnterFileContetn = new Label();
            labelFileName = new Label();
            richTextBoxContent = new RichTextBox();
            textBoxFileName = new TextBox();
            errorProviderText = new ErrorProvider(components);
            errorProvider1 = new ErrorProvider(components);
            errorProviderFileName = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProviderText).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFileName).BeginInit();
            SuspendLayout();
            // 
            // buttonSave
            // 
            buttonSave.BackColor = Color.Teal;
            buttonSave.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            buttonSave.Location = new Point(511, 300);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(139, 81);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Save";
            buttonSave.UseVisualStyleBackColor = false;
            // 
            // labelWelcome
            // 
            labelWelcome.AutoSize = true;
            labelWelcome.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelWelcome.Location = new Point(214, 45);
            labelWelcome.Name = "labelWelcome";
            labelWelcome.Size = new Size(351, 38);
            labelWelcome.TabIndex = 5;
            labelWelcome.Text = "Upload your secret file text";
            // 
            // labelEnterFileContetn
            // 
            labelEnterFileContetn.AutoSize = true;
            labelEnterFileContetn.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelEnterFileContetn.Location = new Point(52, 113);
            labelEnterFileContetn.Name = "labelEnterFileContetn";
            labelEnterFileContetn.Size = new Size(133, 23);
            labelEnterFileContetn.TabIndex = 9;
            labelEnterFileContetn.Text = "Enter file contex";
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            labelFileName.Location = new Point(511, 113);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(125, 23);
            labelFileName.TabIndex = 10;
            labelFileName.Text = "Enter file name";
            // 
            // richTextBoxContent
            // 
            richTextBoxContent.BackColor = Color.PeachPuff;
            richTextBoxContent.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point);
            richTextBoxContent.Location = new Point(52, 139);
            richTextBoxContent.Name = "richTextBoxContent";
            richTextBoxContent.Size = new Size(386, 242);
            richTextBoxContent.TabIndex = 11;
            richTextBoxContent.Text = "";
            // 
            // textBoxFileName
            // 
            textBoxFileName.BackColor = Color.PeachPuff;
            textBoxFileName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFileName.Location = new Point(511, 139);
            textBoxFileName.Multiline = true;
            textBoxFileName.Name = "textBoxFileName";
            textBoxFileName.Size = new Size(139, 92);
            textBoxFileName.TabIndex = 8;
            // 
            // errorProviderText
            // 
            errorProviderText.ContainerControl = this;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProviderFileName
            // 
            errorProviderFileName.ContainerControl = this;
            // 
            // NewTextFileForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(richTextBoxContent);
            Controls.Add(labelFileName);
            Controls.Add(labelEnterFileContetn);
            Controls.Add(textBoxFileName);
            Controls.Add(buttonSave);
            Controls.Add(labelWelcome);
            Name = "NewTextFileForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProviderText).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderFileName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonSave;
        private Label labelWelcome;
        private TextBox textBox1;
        private Label labelEnterFileContetn;
        private Label labelFileName;
        private RichTextBox richTextBoxContent;
        private TextBox textBoxFileName;
        private ErrorProvider errorProviderText;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProviderFileName;
    }
}