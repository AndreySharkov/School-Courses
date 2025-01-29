namespace Shkolo_App
{
    public partial class IndexForm : Form
    {
        private readonly List<Student> students = new()
        {
            new Student
            (
                "Mark Hil",
                12,
                new List<double> { 6, 2, 3.54 },
                new List<double> { 3.78, 5.8, 4.34 },
                new List<double> { 5.50, 6, 5 }
            ),
            new Student
            (
                "John Tven",
                10,
                new List<double> { 5.43, 2, 3.34 },
                new List<double> { 3, 5.34, 4.43 },
                new List<double> { 5.23, 6, 5.54 }
            )
        };

        public IndexForm()
        {
            InitializeComponent();
        }

        private void OnLoad(object sender, EventArgs e)
        {
            LoadAllStudents();
        }

        private void LoadAllStudents()
        {
            this.listViewGrades.Items.Clear();

            foreach (Student student in students)
            {
                ListViewItem studentRow = new(student.Name);
                studentRow.SubItems.Add(string.Join(", ", student.MathematicsMarks));
                studentRow.SubItems.Add(string.Join(", ", student.InformaticsMarks));
                studentRow.SubItems.Add(string.Join(", ", student.SportMarks));
                this.listViewGrades.Items.Add(studentRow);
            }
        }

        private void AddNewStudentClick(object sender, EventArgs e)
        {
            using (AddNewStudentForm addNewStudent = new())
            {
                if (addNewStudent.ShowDialog() == DialogResult.OK)
                {
                    AddNewStudent(addNewStudent.Name, addNewStudent.Grade);
                }
            }
        }

        private void AddNewStudent(string name, int grade)
        {
            Student newStudent = new(name, grade);

            students.Add(newStudent);

            LoadAllStudents();
        }

        private void ListViewGradesMouseClick(object sender, MouseEventArgs e)
        {
            Student currSelectedStudent = GetSelectedStudent();

            using (StudentDetailsForm detailsPage = new(currSelectedStudent))
            {
                detailsPage.ShowDialog();
            }

            LoadAllStudents();
        }

        private Student GetSelectedStudent()
        {
            ListViewItem selectedRow = this.listViewGrades.SelectedItems[0];
            string studentName = selectedRow.SubItems[0].Text;

            return students.FirstOrDefault(s => s.Name == studentName);
        }
    }
}