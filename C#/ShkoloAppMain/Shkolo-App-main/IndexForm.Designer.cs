namespace Shkolo_App
{
    partial class IndexForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelTitle = new Label();
            buttonAddNewStudent = new Button();
            listViewGrades = new ListView();
            columnStudent = new ColumnHeader();
            columnMathematics = new ColumnHeader();
            columnInformatics = new ColumnHeader();
            columnSport = new ColumnHeader();
            SuspendLayout();
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(296, 33);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(199, 68);
            labelTitle.TabIndex = 0;
            labelTitle.Text = "Shkolo";
            // 
            // buttonAddNewStudent
            // 
            buttonAddNewStudent.Anchor = AnchorStyles.Right;
            buttonAddNewStudent.BackColor = Color.FromArgb(1, 25, 54);
            buttonAddNewStudent.ForeColor = SystemColors.HighlightText;
            buttonAddNewStudent.Location = new Point(584, 47);
            buttonAddNewStudent.Name = "buttonAddNewStudent";
            buttonAddNewStudent.Size = new Size(135, 54);
            buttonAddNewStudent.TabIndex = 1;
            buttonAddNewStudent.Text = "Add new student";
            buttonAddNewStudent.UseVisualStyleBackColor = false;
            buttonAddNewStudent.Click += AddNewStudentClick;
            // 
            // listViewGrades
            // 
            listViewGrades.Anchor = AnchorStyles.Left;
            listViewGrades.BackColor = SystemColors.GradientInactiveCaption;
            listViewGrades.Columns.AddRange(new ColumnHeader[] { columnStudent, columnMathematics, columnInformatics, columnSport });
            listViewGrades.ForeColor = Color.Black;
            listViewGrades.Location = new Point(54, 135);
            listViewGrades.Name = "listViewGrades";
            listViewGrades.Size = new Size(665, 280);
            listViewGrades.TabIndex = 2;
            listViewGrades.UseCompatibleStateImageBehavior = false;
            listViewGrades.View = View.Details;
            listViewGrades.MouseClick += ListViewGradesMouseClick;
            // 
            // columnStudent
            // 
            columnStudent.Text = "Student";
            columnStudent.Width = 120;
            // 
            // columnMathematics
            // 
            columnMathematics.Text = "Mathematics";
            columnMathematics.Width = 170;
            // 
            // columnInformatics
            // 
            columnInformatics.Text = "Informatics";
            columnInformatics.Width = 170;
            // 
            // columnSport
            // 
            columnSport.Text = "Sport";
            columnSport.Width = 170;
            // 
            // IndexForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 244);
            ClientSize = new Size(775, 461);
            Controls.Add(listViewGrades);
            Controls.Add(buttonAddNewStudent);
            Controls.Add(labelTitle);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(966, 660);
            MinimumSize = new Size(747, 422);
            Name = "IndexForm";
            Text = "Shkolo App";
            Load += OnLoad;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitle;
        private Button buttonAddNewStudent;
        private ListView listViewGrades;
        private ColumnHeader columnStudent;
        private ColumnHeader columnMathematics;
        private ColumnHeader columnInformatics;
        private ColumnHeader columnSport;
    }
}