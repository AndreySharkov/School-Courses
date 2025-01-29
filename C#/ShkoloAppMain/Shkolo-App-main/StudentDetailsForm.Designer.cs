namespace Shkolo_App
{
    partial class StudentDetailsForm
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
            labelStudentName = new Label();
            labelTitle = new Label();
            labelGrade = new Label();
            labelLine = new Label();
            listViewMarks = new ListView();
            columnSubject = new ColumnHeader();
            columnMarks = new ColumnHeader();
            groupBoxNewMark = new GroupBox();
            labelInfoForNewMark = new Label();
            buttonAddNewMark = new Button();
            listBoxSubjects = new ListBox();
            labelSubject = new Label();
            labelMark = new Label();
            textBoxMark = new TextBox();
            labelAverageMark = new Label();
            groupBoxАbsences = new GroupBox();
            numericUpDownAbsences = new NumericUpDown();
            labelInfoForAbsences = new Label();
            buttonAbsence = new Button();
            listBoxAbsenceType = new ListBox();
            labelAbsenceType = new Label();
            labelAbsencesCount = new Label();
            labelTotaАbsences = new Label();
            labelSecondLine = new Label();
            labelUnexcusedАbsences = new Label();
            labelЕxcusedАbsences = new Label();
            labelInfoTotal = new Label();
            labelInfoUnexcused = new Label();
            labelInfoExcused = new Label();
            labelInfoAverage = new Label();
            labelInfoStudentGrade = new Label();
            labelInfoStudentName = new Label();
            labelTooManyAbsences = new Label();
            groupBoxNewMark.SuspendLayout();
            groupBoxАbsences.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAbsences).BeginInit();
            SuspendLayout();
            // 
            // labelStudentName
            // 
            labelStudentName.AutoSize = true;
            labelStudentName.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelStudentName.ImageAlign = ContentAlignment.MiddleLeft;
            labelStudentName.Location = new Point(202, 115);
            labelStudentName.Margin = new Padding(5, 0, 5, 0);
            labelStudentName.Name = "labelStudentName";
            labelStudentName.Size = new Size(178, 34);
            labelStudentName.TabIndex = 1;
            labelStudentName.Text = "Student name";
            labelStudentName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTitle
            // 
            labelTitle.Anchor = AnchorStyles.Top;
            labelTitle.AutoSize = true;
            labelTitle.Font = new Font("Times New Roman", 36F, FontStyle.Regular, GraphicsUnit.Point);
            labelTitle.Location = new Point(299, 8);
            labelTitle.Margin = new Padding(4, 0, 4, 0);
            labelTitle.Name = "labelTitle";
            labelTitle.Size = new Size(414, 68);
            labelTitle.TabIndex = 2;
            labelTitle.Text = "Student Details ";
            // 
            // labelGrade
            // 
            labelGrade.AutoSize = true;
            labelGrade.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelGrade.ImageAlign = ContentAlignment.MiddleLeft;
            labelGrade.Location = new Point(202, 145);
            labelGrade.Margin = new Padding(5, 0, 5, 0);
            labelGrade.Name = "labelGrade";
            labelGrade.Size = new Size(179, 34);
            labelGrade.TabIndex = 3;
            labelGrade.Text = "Student grade";
            labelGrade.TextAlign = ContentAlignment.MiddleCenter;
            labelGrade.Click += labelGrade_Click;
            // 
            // labelLine
            // 
            labelLine.AutoSize = true;
            labelLine.Font = new Font("Times New Roman", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelLine.Location = new Point(-18, 87);
            labelLine.Margin = new Padding(0);
            labelLine.Name = "labelLine";
            labelLine.Size = new Size(80, 136);
            labelLine.TabIndex = 4;
            labelLine.Text = "|";
            // 
            // listViewMarks
            // 
            listViewMarks.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            listViewMarks.BackColor = SystemColors.GradientInactiveCaption;
            listViewMarks.Columns.AddRange(new ColumnHeader[] { columnSubject, columnMarks });
            listViewMarks.Location = new Point(487, 113);
            listViewMarks.Name = "listViewMarks";
            listViewMarks.Size = new Size(382, 183);
            listViewMarks.TabIndex = 5;
            listViewMarks.UseCompatibleStateImageBehavior = false;
            listViewMarks.View = View.Details;
            // 
            // columnSubject
            // 
            columnSubject.Text = "Subject";
            columnSubject.Width = 100;
            // 
            // columnMarks
            // 
            columnMarks.Text = "Marks";
            columnMarks.Width = 275;
            // 
            // groupBoxNewMark
            // 
            groupBoxNewMark.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxNewMark.Controls.Add(labelInfoForNewMark);
            groupBoxNewMark.Controls.Add(buttonAddNewMark);
            groupBoxNewMark.Controls.Add(listBoxSubjects);
            groupBoxNewMark.Controls.Add(labelSubject);
            groupBoxNewMark.Controls.Add(labelMark);
            groupBoxNewMark.Controls.Add(textBoxMark);
            groupBoxNewMark.Location = new Point(405, 329);
            groupBoxNewMark.Name = "groupBoxNewMark";
            groupBoxNewMark.Size = new Size(430, 122);
            groupBoxNewMark.TabIndex = 6;
            groupBoxNewMark.TabStop = false;
            groupBoxNewMark.Text = "Add new mark";
            // 
            // labelInfoForNewMark
            // 
            labelInfoForNewMark.AutoSize = true;
            labelInfoForNewMark.ForeColor = Color.Red;
            labelInfoForNewMark.Location = new Point(25, 91);
            labelInfoForNewMark.Name = "labelInfoForNewMark";
            labelInfoForNewMark.Size = new Size(186, 22);
            labelInfoForNewMark.TabIndex = 5;
            labelInfoForNewMark.Text = "Please add valid data!";
            labelInfoForNewMark.Visible = false;
            // 
            // buttonAddNewMark
            // 
            buttonAddNewMark.Anchor = AnchorStyles.Bottom;
            buttonAddNewMark.BackColor = Color.FromArgb(1, 25, 54);
            buttonAddNewMark.ForeColor = SystemColors.HighlightText;
            buttonAddNewMark.Location = new Point(297, 58);
            buttonAddNewMark.Name = "buttonAddNewMark";
            buttonAddNewMark.Size = new Size(111, 32);
            buttonAddNewMark.TabIndex = 4;
            buttonAddNewMark.Text = "Add";
            buttonAddNewMark.UseVisualStyleBackColor = false;
            buttonAddNewMark.Click += ButtonAddNewMarkClick;
            // 
            // listBoxSubjects
            // 
            listBoxSubjects.BackColor = SystemColors.GradientInactiveCaption;
            listBoxSubjects.ForeColor = Color.Black;
            listBoxSubjects.FormattingEnabled = true;
            listBoxSubjects.ItemHeight = 22;
            listBoxSubjects.Items.AddRange(new object[] { "Mathematics", "Informatics", "Sport" });
            listBoxSubjects.Location = new Point(160, 65);
            listBoxSubjects.Name = "listBoxSubjects";
            listBoxSubjects.Size = new Size(104, 26);
            listBoxSubjects.TabIndex = 3;
            // 
            // labelSubject
            // 
            labelSubject.AutoSize = true;
            labelSubject.Location = new Point(160, 40);
            labelSubject.Name = "labelSubject";
            labelSubject.Size = new Size(69, 22);
            labelSubject.TabIndex = 2;
            labelSubject.Text = "Subject";
            // 
            // labelMark
            // 
            labelMark.AutoSize = true;
            labelMark.Location = new Point(25, 40);
            labelMark.Name = "labelMark";
            labelMark.Size = new Size(52, 22);
            labelMark.TabIndex = 1;
            labelMark.Text = "Mark";
            // 
            // textBoxMark
            // 
            textBoxMark.BackColor = SystemColors.GradientInactiveCaption;
            textBoxMark.ForeColor = Color.Black;
            textBoxMark.Location = new Point(25, 62);
            textBoxMark.Name = "textBoxMark";
            textBoxMark.Size = new Size(100, 30);
            textBoxMark.TabIndex = 0;
            // 
            // labelAverageMark
            // 
            labelAverageMark.AutoSize = true;
            labelAverageMark.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelAverageMark.ImageAlign = ContentAlignment.MiddleLeft;
            labelAverageMark.Location = new Point(115, 179);
            labelAverageMark.Margin = new Padding(5, 0, 5, 0);
            labelAverageMark.Name = "labelAverageMark";
            labelAverageMark.Size = new Size(111, 34);
            labelAverageMark.TabIndex = 7;
            labelAverageMark.Text = "Average";
            labelAverageMark.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // groupBoxАbsences
            // 
            groupBoxАbsences.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            groupBoxАbsences.Controls.Add(numericUpDownAbsences);
            groupBoxАbsences.Controls.Add(labelInfoForAbsences);
            groupBoxАbsences.Controls.Add(buttonAbsence);
            groupBoxАbsences.Controls.Add(listBoxAbsenceType);
            groupBoxАbsences.Controls.Add(labelAbsenceType);
            groupBoxАbsences.Controls.Add(labelAbsencesCount);
            groupBoxАbsences.Location = new Point(405, 473);
            groupBoxАbsences.Name = "groupBoxАbsences";
            groupBoxАbsences.Size = new Size(430, 122);
            groupBoxАbsences.TabIndex = 7;
            groupBoxАbsences.TabStop = false;
            groupBoxАbsences.Text = "Аbsences";
            // 
            // numericUpDownAbsences
            // 
            numericUpDownAbsences.BackColor = SystemColors.GradientInactiveCaption;
            numericUpDownAbsences.Location = new Point(32, 63);
            numericUpDownAbsences.Name = "numericUpDownAbsences";
            numericUpDownAbsences.Size = new Size(45, 30);
            numericUpDownAbsences.TabIndex = 6;
            // 
            // labelInfoForAbsences
            // 
            labelInfoForAbsences.AutoSize = true;
            labelInfoForAbsences.ForeColor = Color.Red;
            labelInfoForAbsences.Location = new Point(25, 91);
            labelInfoForAbsences.Name = "labelInfoForAbsences";
            labelInfoForAbsences.Size = new Size(186, 22);
            labelInfoForAbsences.TabIndex = 5;
            labelInfoForAbsences.Text = "Please add valid data!";
            labelInfoForAbsences.Visible = false;
            // 
            // buttonAbsence
            // 
            buttonAbsence.Anchor = AnchorStyles.Bottom;
            buttonAbsence.BackColor = Color.FromArgb(1, 25, 54);
            buttonAbsence.ForeColor = SystemColors.HighlightText;
            buttonAbsence.Location = new Point(301, 54);
            buttonAbsence.Name = "buttonAbsence";
            buttonAbsence.Size = new Size(111, 32);
            buttonAbsence.TabIndex = 4;
            buttonAbsence.Text = "Add";
            buttonAbsence.UseVisualStyleBackColor = false;
            buttonAbsence.Click += ButtonAbsenceClick;
            // 
            // listBoxAbsenceType
            // 
            listBoxAbsenceType.BackColor = SystemColors.GradientInactiveCaption;
            listBoxAbsenceType.ForeColor = Color.Black;
            listBoxAbsenceType.FormattingEnabled = true;
            listBoxAbsenceType.ItemHeight = 22;
            listBoxAbsenceType.Items.AddRange(new object[] { "Excused", "Unexcused" });
            listBoxAbsenceType.Location = new Point(145, 65);
            listBoxAbsenceType.Name = "listBoxAbsenceType";
            listBoxAbsenceType.Size = new Size(104, 26);
            listBoxAbsenceType.TabIndex = 3;
            // 
            // labelAbsenceType
            // 
            labelAbsenceType.AutoSize = true;
            labelAbsenceType.Location = new Point(145, 40);
            labelAbsenceType.Name = "labelAbsenceType";
            labelAbsenceType.Size = new Size(49, 22);
            labelAbsenceType.TabIndex = 2;
            labelAbsenceType.Text = "Type";
            // 
            // labelAbsencesCount
            // 
            labelAbsencesCount.AutoSize = true;
            labelAbsencesCount.Location = new Point(32, 40);
            labelAbsencesCount.Name = "labelAbsencesCount";
            labelAbsencesCount.Size = new Size(56, 22);
            labelAbsencesCount.TabIndex = 1;
            labelAbsencesCount.Text = "Count";
            // 
            // labelTotaАbsences
            // 
            labelTotaАbsences.Anchor = AnchorStyles.Left;
            labelTotaАbsences.AutoSize = true;
            labelTotaАbsences.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelTotaАbsences.ImageAlign = ContentAlignment.MiddleLeft;
            labelTotaАbsences.Location = new Point(85, 478);
            labelTotaАbsences.Margin = new Padding(5, 0, 5, 0);
            labelTotaАbsences.Name = "labelTotaАbsences";
            labelTotaАbsences.Size = new Size(30, 34);
            labelTotaАbsences.TabIndex = 11;
            labelTotaАbsences.Text = "0";
            labelTotaАbsences.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelSecondLine
            // 
            labelSecondLine.Anchor = AnchorStyles.Left;
            labelSecondLine.AutoSize = true;
            labelSecondLine.Font = new Font("Times New Roman", 72F, FontStyle.Regular, GraphicsUnit.Point);
            labelSecondLine.Location = new Point(-18, 380);
            labelSecondLine.Margin = new Padding(0);
            labelSecondLine.Name = "labelSecondLine";
            labelSecondLine.Size = new Size(80, 136);
            labelSecondLine.TabIndex = 10;
            labelSecondLine.Text = "|";
            // 
            // labelUnexcusedАbsences
            // 
            labelUnexcusedАbsences.Anchor = AnchorStyles.Left;
            labelUnexcusedАbsences.AutoSize = true;
            labelUnexcusedАbsences.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelUnexcusedАbsences.ImageAlign = ContentAlignment.MiddleLeft;
            labelUnexcusedАbsences.Location = new Point(144, 448);
            labelUnexcusedАbsences.Margin = new Padding(5, 0, 5, 0);
            labelUnexcusedАbsences.Name = "labelUnexcusedАbsences";
            labelUnexcusedАbsences.Size = new Size(30, 34);
            labelUnexcusedАbsences.TabIndex = 9;
            labelUnexcusedАbsences.Text = "0";
            labelUnexcusedАbsences.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelЕxcusedАbsences
            // 
            labelЕxcusedАbsences.Anchor = AnchorStyles.Left;
            labelЕxcusedАbsences.AutoSize = true;
            labelЕxcusedАbsences.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelЕxcusedАbsences.ImageAlign = ContentAlignment.MiddleLeft;
            labelЕxcusedАbsences.Location = new Point(118, 415);
            labelЕxcusedАbsences.Margin = new Padding(5, 0, 5, 0);
            labelЕxcusedАbsences.Name = "labelЕxcusedАbsences";
            labelЕxcusedАbsences.Size = new Size(30, 34);
            labelЕxcusedАbsences.TabIndex = 8;
            labelЕxcusedАbsences.Text = "0";
            labelЕxcusedАbsences.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInfoTotal
            // 
            labelInfoTotal.Anchor = AnchorStyles.Left;
            labelInfoTotal.AutoSize = true;
            labelInfoTotal.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfoTotal.ImageAlign = ContentAlignment.MiddleLeft;
            labelInfoTotal.Location = new Point(23, 477);
            labelInfoTotal.Margin = new Padding(5, 0, 5, 0);
            labelInfoTotal.Name = "labelInfoTotal";
            labelInfoTotal.Size = new Size(83, 34);
            labelInfoTotal.TabIndex = 14;
            labelInfoTotal.Text = "Total:";
            labelInfoTotal.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInfoUnexcused
            // 
            labelInfoUnexcused.Anchor = AnchorStyles.Left;
            labelInfoUnexcused.AutoSize = true;
            labelInfoUnexcused.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfoUnexcused.ImageAlign = ContentAlignment.MiddleLeft;
            labelInfoUnexcused.Location = new Point(24, 446);
            labelInfoUnexcused.Margin = new Padding(5, 0, 5, 0);
            labelInfoUnexcused.Name = "labelInfoUnexcused";
            labelInfoUnexcused.Size = new Size(154, 34);
            labelInfoUnexcused.TabIndex = 13;
            labelInfoUnexcused.Text = "Unexcused:";
            labelInfoUnexcused.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInfoExcused
            // 
            labelInfoExcused.Anchor = AnchorStyles.Left;
            labelInfoExcused.AutoSize = true;
            labelInfoExcused.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfoExcused.ImageAlign = ContentAlignment.MiddleLeft;
            labelInfoExcused.Location = new Point(24, 415);
            labelInfoExcused.Margin = new Padding(5, 0, 5, 0);
            labelInfoExcused.Name = "labelInfoExcused";
            labelInfoExcused.Size = new Size(122, 34);
            labelInfoExcused.TabIndex = 12;
            labelInfoExcused.Text = "Еxcused:";
            labelInfoExcused.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInfoAverage
            // 
            labelInfoAverage.AutoSize = true;
            labelInfoAverage.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfoAverage.ImageAlign = ContentAlignment.MiddleLeft;
            labelInfoAverage.Location = new Point(23, 178);
            labelInfoAverage.Margin = new Padding(5, 0, 5, 0);
            labelInfoAverage.Name = "labelInfoAverage";
            labelInfoAverage.Size = new Size(119, 34);
            labelInfoAverage.TabIndex = 17;
            labelInfoAverage.Text = "Average:";
            labelInfoAverage.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInfoStudentGrade
            // 
            labelInfoStudentGrade.AutoSize = true;
            labelInfoStudentGrade.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfoStudentGrade.ImageAlign = ContentAlignment.MiddleLeft;
            labelInfoStudentGrade.Location = new Point(24, 146);
            labelInfoStudentGrade.Margin = new Padding(5, 0, 5, 0);
            labelInfoStudentGrade.Name = "labelInfoStudentGrade";
            labelInfoStudentGrade.Size = new Size(187, 34);
            labelInfoStudentGrade.TabIndex = 16;
            labelInfoStudentGrade.Text = "Student grade:";
            labelInfoStudentGrade.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelInfoStudentName
            // 
            labelInfoStudentName.AutoSize = true;
            labelInfoStudentName.Font = new Font("Times New Roman", 18F, FontStyle.Regular, GraphicsUnit.Point);
            labelInfoStudentName.ImageAlign = ContentAlignment.MiddleLeft;
            labelInfoStudentName.Location = new Point(24, 115);
            labelInfoStudentName.Margin = new Padding(5, 0, 5, 0);
            labelInfoStudentName.Name = "labelInfoStudentName";
            labelInfoStudentName.Size = new Size(186, 34);
            labelInfoStudentName.TabIndex = 15;
            labelInfoStudentName.Text = "Student name:";
            labelInfoStudentName.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // labelTooManyAbsences
            // 
            labelTooManyAbsences.AutoSize = true;
            labelTooManyAbsences.ForeColor = Color.White;
            labelTooManyAbsences.Location = new Point(260, 69);
            labelTooManyAbsences.Name = "labelTooManyAbsences";
            labelTooManyAbsences.Size = new Size(294, 22);
            labelTooManyAbsences.TabIndex = 18;
            labelTooManyAbsences.Text = "This student has too many absences!";
            labelTooManyAbsences.Visible = false;
            // 
            // StudentDetailsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(237, 242, 244);
            ClientSize = new Size(896, 655);
            Controls.Add(labelTooManyAbsences);
            Controls.Add(labelInfoAverage);
            Controls.Add(labelInfoStudentGrade);
            Controls.Add(labelInfoStudentName);
            Controls.Add(labelInfoTotal);
            Controls.Add(labelInfoUnexcused);
            Controls.Add(labelInfoExcused);
            Controls.Add(labelTotaАbsences);
            Controls.Add(labelSecondLine);
            Controls.Add(labelUnexcusedАbsences);
            Controls.Add(labelЕxcusedАbsences);
            Controls.Add(groupBoxАbsences);
            Controls.Add(labelAverageMark);
            Controls.Add(groupBoxNewMark);
            Controls.Add(listViewMarks);
            Controls.Add(labelLine);
            Controls.Add(labelGrade);
            Controls.Add(labelTitle);
            Controls.Add(labelStudentName);
            Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(4);
            MaximumSize = new Size(980, 866);
            MinimumSize = new Size(622, 398);
            Name = "StudentDetailsForm";
            Text = "Student Details";
            Load += OnLoad;
            groupBoxNewMark.ResumeLayout(false);
            groupBoxNewMark.PerformLayout();
            groupBoxАbsences.ResumeLayout(false);
            groupBoxАbsences.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAbsences).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelStudentName;
        private Label labelTitle;
        private Label labelGrade;
        private Label labelLine;
        private Label labelAbsenceType;
        private Label labelAbsencesCount;
        private Label labelTotaАbsences;
        private Label labelSecondLine;
        private Label labelUnexcusedАbsences;
        private Label labelЕxcusedАbsences;
        private Label labelInfoTotal;
        private Label labelInfoUnexcused;
        private Label labelInfoExcused;
        private Label labelInfoAverage;
        private Label labelInfoStudentGrade;
        private Label labelInfoStudentName;
        private Label labelTooManyAbsences;
        private Label labelMark;
        private Label labelSubject;
        private Label labelInfoForNewMark;
        private Label labelAverageMark;
        private Label labelInfoForAbsences;
        private ListView listViewMarks;
        private GroupBox groupBoxNewMark;
        private GroupBox groupBoxАbsences;
        private ColumnHeader columnSubject;
        private ColumnHeader columnMarks;
        private TextBox textBoxMark;
        private Button buttonAddNewMark;
        private Button buttonAbsence;
        private ListBox listBoxAbsenceType;
        private ListBox listBoxSubjects;
        private NumericUpDown numericUpDownAbsences;
    }
}