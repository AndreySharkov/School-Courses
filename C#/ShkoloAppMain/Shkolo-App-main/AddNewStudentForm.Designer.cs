namespace Shkolo_App
{
    partial class AddNewStudentForm
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
            buttonAdd = new Button();
            labelAddNewStudent = new Label();
            labelName = new Label();
            labelGrade = new Label();
            textBoxName = new TextBox();
            textBoxGrade = new TextBox();
            errorProviderName = new ErrorProvider(components);
            errorProviderGrade = new ErrorProvider(components);
            labelNameValidation = new Label();
            labelGradeValidation = new Label();
            ((System.ComponentModel.ISupportInitialize)errorProviderName).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderGrade).BeginInit();
            SuspendLayout();
            // 
            // buttonAdd
            // 
            buttonAdd.Anchor = AnchorStyles.Bottom;
            buttonAdd.BackColor = Color.FromArgb(1, 25, 54);
            buttonAdd.ForeColor = SystemColors.HighlightText;
            buttonAdd.Location = new Point(201, 215);
            buttonAdd.Name = "buttonAdd";
            buttonAdd.Size = new Size(135, 54);
            buttonAdd.TabIndex = 3;
            buttonAdd.Text = "Add";
            buttonAdd.UseVisualStyleBackColor = false;
            buttonAdd.Click += ButtonAddClick;
            // 
            // labelAddNewStudent
            // 
            labelAddNewStudent.Anchor = AnchorStyles.Top;
            labelAddNewStudent.AutoSize = true;
            labelAddNewStudent.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelAddNewStudent.Location = new Point(102, 30);
            labelAddNewStudent.Margin = new Padding(4, 0, 4, 0);
            labelAddNewStudent.Name = "labelAddNewStudent";
            labelAddNewStudent.Size = new Size(346, 55);
            labelAddNewStudent.TabIndex = 2;
            labelAddNewStudent.Text = "Add new student";
            // 
            // labelName
            // 
            labelName.AutoSize = true;
            labelName.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelName.Location = new Point(30, 114);
            labelName.Margin = new Padding(4, 0, 4, 0);
            labelName.Name = "labelName";
            labelName.Size = new Size(46, 19);
            labelName.TabIndex = 4;
            labelName.Text = "Name";
            // 
            // labelGrade
            // 
            labelGrade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelGrade.AutoSize = true;
            labelGrade.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            labelGrade.Location = new Point(302, 114);
            labelGrade.Margin = new Padding(4, 0, 4, 0);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(47, 19);
            labelGrade.TabIndex = 5;
            labelGrade.Text = "Grade";
            // 
            // textBoxName
            // 
            textBoxName.BackColor = SystemColors.GradientInactiveCaption;
            textBoxName.ForeColor = Color.Black;
            textBoxName.Location = new Point(30, 136);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(167, 26);
            textBoxName.TabIndex = 1;
            textBoxName.Validating += ValidateStudentsName;
            // 
            // textBoxGrade
            // 
            textBoxGrade.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            textBoxGrade.BackColor = SystemColors.GradientInactiveCaption;
            textBoxGrade.ForeColor = Color.Black;
            textBoxGrade.Location = new Point(302, 136);
            textBoxGrade.Name = "textBoxGrade";
            textBoxGrade.Size = new Size(167, 26);
            textBoxGrade.TabIndex = 2;
            textBoxGrade.Validating += ValidatingGrade;
            // 
            // errorProviderName
            // 
            errorProviderName.ContainerControl = this;
            // 
            // errorProviderGrade
            // 
            errorProviderGrade.ContainerControl = this;
            // 
            // labelNameValidation
            // 
            labelNameValidation.AutoSize = true;
            labelNameValidation.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelNameValidation.ForeColor = Color.Red;
            labelNameValidation.Location = new Point(30, 165);
            labelNameValidation.Name = "labelNameValidation";
            labelNameValidation.Size = new Size(188, 15);
            labelNameValidation.TabIndex = 6;
            labelNameValidation.Text = "Name should not be empty string!";
            labelNameValidation.Visible = false;
            // 
            // labelGradeValidation
            // 
            labelGradeValidation.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            labelGradeValidation.AutoSize = true;
            labelGradeValidation.Font = new Font("Times New Roman", 9.75F, FontStyle.Regular, GraphicsUnit.Point);
            labelGradeValidation.ForeColor = Color.Red;
            labelGradeValidation.Location = new Point(302, 165);
            labelGradeValidation.Name = "labelGradeValidation";
            labelGradeValidation.Size = new Size(193, 15);
            labelGradeValidation.TabIndex = 7;
            labelGradeValidation.Text = "Grade should be between 1 and 12!";
            labelGradeValidation.Visible = false;
            // 
            // AddNewStudentForm
            // 
            AutoScaleDimensions = new SizeF(9F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 244);
            ClientSize = new Size(537, 280);
            Controls.Add(labelGradeValidation);
            Controls.Add(labelNameValidation);
            Controls.Add(textBoxGrade);
            Controls.Add(textBoxName);
            Controls.Add(labelGrade);
            Controls.Add(labelName);
            Controls.Add(buttonAdd);
            Controls.Add(labelAddNewStudent);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(741, 473);
            MinimumSize = new Size(472, 283);
            Name = "AddNewStudentForm";
            Text = "New Student";
            ((System.ComponentModel.ISupportInitialize)errorProviderName).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProviderGrade).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelAddNewStudent;
        private Label labelName;
        private Label labelGrade;
        private Label labelGradeValidation;
        private Label labelNameValidation;
        private TextBox textBoxName;
        private TextBox textBoxGrade;
        private Button buttonAdd;
        private ErrorProvider errorProviderName;
        private ErrorProvider errorProviderGrade;
    }
}