namespace Shkolo_App
{
    public partial class StudentDetailsForm : Form
    {
        private readonly Student student;

        public StudentDetailsForm(Student student)
        {
            InitializeComponent();

            this.student = student;
        }

        private void OnLoad(object sender, EventArgs e)
        {
            FillStudentInfoLabels();
            UpdateListViewWithMarks();
            CheckForWarnings();
        }

        private void FillStudentInfoLabels()
        {
            this.labelStudentName.Text = this.student.Name;
            this.labelGrade.Text = this.student.Grade.ToString();
            this.labelAverageMark.Text = this.student.AverageMark.ToString("f2");
            this.labelЕxcusedАbsences.Text = this.student.ExcusedAbsences.ToString();
            this.labelUnexcusedАbsences.Text = this.student.UnexcusedAbsences.ToString();
            this.labelTotaАbsences.Text = this.student.TotalAbsences.ToString();
        }

        private void UpdateListViewWithMarks()
        {
            this.listViewMarks.Items.Clear();

            AddMarksToListView("Mathematics", this.student.MathematicsMarks);
            AddMarksToListView("Informatics", this.student.InformaticsMarks);
            AddMarksToListView("Sport", this.student.SportMarks);
        }

        private void AddMarksToListView(string subject, List<double> marks)
        {
            ListViewItem newColumn = new ListViewItem(subject);
            foreach (var mark in marks)
            {
                newColumn.SubItems.Add(mark.ToString());
            }
            this.listViewMarks.Items.Add(newColumn);
        }

        private void CheckForWarnings()
        {
            if (this.student.UnexcusedAbsences > 10)
            {
                ChangeColor();
            }
        }

        private void ChangeColor()
        {
            this.BackColor = Color.FromArgb(228, 131, 151);
            this.ForeColor = Color.White;
            this.labelTooManyAbsences.Visible = true;

            this.buttonAbsence.BackColor = Color.FromArgb(237, 30, 54);
            this.buttonAddNewMark.BackColor = Color.FromArgb(237, 30, 54);

            this.listViewMarks.BackColor = Color.FromArgb(228, 205, 211);
            this.listBoxAbsenceType.BackColor = Color.FromArgb(228, 205, 211);
            this.listBoxSubjects.BackColor = Color.FromArgb(228, 205, 211);
            this.textBoxMark.BackColor = Color.FromArgb(228, 205, 211);
            this.numericUpDownAbsences.BackColor = Color.FromArgb(228, 205, 211);
        }

        private void ButtonAddNewMarkClick(object sender, EventArgs e)
        {
            try
            {
                AddNewMark();
                FillStudentInfoLabels();
                UpdateListViewWithMarks();
                ClearInputs();
            }
            catch (Exception)
            {
                ShowErrorMessage(this.labelInfoForNewMark);
            }
        }

        private void AddNewMark()
        {
            GetNewMarkInfo(out double mark, out string subject);

            Dictionary<string, List<double>> subjectMarks = new()
            {
                { "Mathematics", this.student.MathematicsMarks },
                { "Informatics", this.student.InformaticsMarks },
                { "Sport", this.student.SportMarks }
            };

            if (subjectMarks.ContainsKey(subject))
            {
                subjectMarks[subject].Add(mark);
            }
        }

        private void GetNewMarkInfo(out double mark, out string subject)
        {
            mark = double.Parse(this.textBoxMark.Text);
            subject = this.listBoxSubjects.Text;

            if (string.IsNullOrEmpty(subject) || mark < 2 || mark > 6)
            {
                throw new Exception();
            }
        }

        private void ClearInputs()
        {
            this.textBoxMark.Clear();
            this.listBoxSubjects.ClearSelected();
            this.listBoxAbsenceType.ClearSelected();
            this.numericUpDownAbsences.Value = 0;
        }

        private void ShowErrorMessage(Label label)
        {
            label.Visible = true;

            Task.Delay(3000).ContinueWith(_ =>
            {
                Invoke(new MethodInvoker(() =>
                {
                    label.Visible = false;
                }));
            });
        }

        private void ButtonAbsenceClick(object sender, EventArgs e)
        {
            try
            {
                AddAbsence();
                FillStudentInfoLabels();
                ClearInputs();
                CheckForWarnings();
            }
            catch (Exception)
            {
                ShowErrorMessage(this.labelInfoForAbsences);
            }
        }

        private void AddAbsence()
        {
            GetNewAbsenceInfo(out string selectedAbsenceType, out int numberOfAbsences);

            Dictionary<string, Action<int>> absenceActions = new()
            {
                { "Excused", absences => this.student.ExcusedAbsences += absences },
                { "Unexcused", absences => this.student.UnexcusedAbsences += absences }
            };

            if (!absenceActions.ContainsKey(selectedAbsenceType) || numberOfAbsences < 1)
            {
                throw new Exception();
            }

            absenceActions[selectedAbsenceType](numberOfAbsences);
        }

        private void GetNewAbsenceInfo(out string selectedAbsenceType, out int numberOfAbsences)
        {
            selectedAbsenceType = this.listBoxAbsenceType.Text;
            numberOfAbsences = int.Parse(this.numericUpDownAbsences.Value.ToString());
        }

        private void labelGrade_Click(object sender, EventArgs e)
        {

        }
    }
}
