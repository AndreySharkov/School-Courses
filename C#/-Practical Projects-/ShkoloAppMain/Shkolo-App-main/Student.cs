namespace Shkolo_App
{
    public class Student
    {
        public Student(string name, int grade)
        {
            this.Name = name;
            this.Grade = grade;
        }

        public Student(string name, int grade, List<double> mathematicsMarks, 
            List<double> informaticsMarks, List<double> sportMarks)
        {
            this.Name = name;
            this.Grade = grade;
            this.MathematicsMarks = mathematicsMarks;
            this.InformaticsMarks = informaticsMarks;
            this.SportMarks = sportMarks;
        }

        public string Name { get; set; }

        public int Grade { get; set; }

        public int ExcusedAbsences { get; set; }

        public int UnexcusedAbsences { get; set; }

        public int TotalAbsences
            => this.ExcusedAbsences + this.UnexcusedAbsences;

        public List<double> MathematicsMarks { get; set; } = new List<double>();

        public List<double> InformaticsMarks { get; set; } = new List<double>();

        public List<double> SportMarks { get; set; } = new List<double>();

        public double AverageMark
        {
            get
            {
                var allMarks = MathematicsMarks
                    .Concat(InformaticsMarks ?? Enumerable.Empty<double>())
                    .Concat(SportMarks ?? Enumerable.Empty<double>());

                return allMarks.Any() ? allMarks.Average() : 0;
            }
        }
    }
}
