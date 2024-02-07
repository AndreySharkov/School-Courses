namespace CheckStudents
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> MissingStudents = new List<string>();
            for (int i = 0; i < n; i++)
            {
                string[] command = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
                if (command[2] == "not")
                {
                    if (MissingStudents.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is already in the list!");
                    }
                    else
                    {
                        MissingStudents.Add(command[0]);
                    }
                }
                else if (command[2] == "here!")
                {
                    if (MissingStudents.Contains(command[0]))
                    {
                        Console.WriteLine($"{command[0]} is in class!");
                        MissingStudents.Remove(command[0]);
                    }
                    else
                    {

                    }
                }
            }
            foreach(string s in MissingStudents)
            {
                Console.WriteLine(s);
            }

        }
    }
}