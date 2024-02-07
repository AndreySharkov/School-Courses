namespace Dictionary
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var students = new Dictionary<string, List<double>>();
            int lines = int.Parse(Console.ReadLine());
            for(int i = 0; i < lines; i++)
            {
                string[] grade = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (!students.ContainsKey(grade[0]))
                {
                    students.Add(grade[0], new List<double>());
                    students[grade[0]].Add(int.Parse(grade[1]));
                }
                else
                {
                    students[grade[0]].Add(int.Parse(grade[1]));
                }

            }
            foreach(var  student in students)
            {
                Console.WriteLine($"{student.Key} - {student.Value.Average():f2}");
            }
        }
    }
}