namespace MySecretFolder
{
    partial class NewFolderForm
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
            enterFileNameLabel = new Label();
            textBoxFolderName = new TextBox();
            enterButton = new Button();
            errorProviderForFolderName = new ErrorProvider(components);
            labelErrorMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProviderForFolderName).BeginInit();
            SuspendLayout();
            // 
            // enterFileNameLabel
            // 
            enterFileNameLabel.AutoSize = true;
            enterFileNameLabel.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point);
            enterFileNameLabel.Location = new Point(110, 71);
            enterFileNameLabel.Name = "enterFileNameLabel";
            enterFileNameLabel.Size = new Size(292, 38);
            enterFileNameLabel.TabIndex = 0;
            enterFileNameLabel.Text = "Please enter file name";
            // 
            // textBoxFolderName
            // 
            textBoxFolderName.BackColor = Color.PeachPuff;
            textBoxFolderName.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            textBoxFolderName.Location = new Point(136, 112);
            textBoxFolderName.Name = "textBoxFolderName";
            textBoxFolderName.Size = new Size(227, 34);
            textBoxFolderName.TabIndex = 1;
            // 
            // enterButton
            // 
            enterButton.BackColor = Color.Teal;
            enterButton.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point);
            enterButton.Location = new Point(196, 181);
            enterButton.Name = "enterButton";
            enterButton.Size = new Size(100, 34);
            enterButton.TabIndex = 4;
            enterButton.Text = "Enter";
            enterButton.UseVisualStyleBackColor = false;
            enterButton.Click += this.enterBtn_Click;
            // 
            // errorProviderForFolderName
            // 
            errorProviderForFolderName.ContainerControl = this;
            // 
            // labelErrorMessage
            // 
            labelErrorMessage.AutoSize = true;
            labelErrorMessage.Location = new Point(136, 149);
            labelErrorMessage.Name = "labelErrorMessage";
            labelErrorMessage.Size = new Size(0, 20);
            labelErrorMessage.TabIndex = 5;
            // 
            // NewFolderForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 284);
            Controls.Add(labelErrorMessage);
            Controls.Add(enterButton);
            Controls.Add(textBoxFolderName);
            Controls.Add(enterFileNameLabel);
            Name = "NewFolderForm";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)errorProviderForFolderName).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label enterFileNameLabel;
        private TextBox textBoxFolderName;
        private Button enterButton;
        private ErrorProvider errorProviderForFolderName;
        private Label labelErrorMessage;
    }
}