namespace Grades
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double grade = double.Parse(Console.ReadLine());
            Console.WriteLine(GradeM(grade));
        }
        static string GradeM(double grade)
        {
            string grading = "";
            if(grade <= 2.99)
            {
                return "Fail";
            }
            else if (grade <= 3.49 &&  grade > 3)
            {
                return "Poor";
            }
            else if (grade <= 4.49 && grade > 3.5)
            {
                return "Good";
            }
            else if (grade <= 5.49 && grade > 4.5)
            {
                return "Very good";
            }
            else if (grade <= 6 && grade > 5.49)
            {
                return "Excellent";
            }
                return "jeri";
        }
    }
}