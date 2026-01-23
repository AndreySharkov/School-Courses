namespace Employes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employees> employees = new List<Employees>();
            for (int i = 0; i < n; i++)
            {
                string[] employesIn = Console.ReadLine().Split();
                Employees employee = new Employees(employesIn[0], employesIn[1], double.Parse(employesIn[2]));
                employees.Add(employee);
            }
            employees = employees.OrderByDescending(x => x.Salary).ToList();
            foreach (Employees employee in employees)
            {
                Console.WriteLine($"{employee.FirstName} {employee.LastName}: {employee.Salary:f2}");
            }
        }
    }
    class Employees
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public double Salary { get; set; }

        public Employees(string firstName, string lastName, double salary)
        {
            FirstName = firstName;
            LastName = lastName;
            Salary = salary;
        }
    }
}


/*
4
Daliya Zheleva 3001.90
Maya Nikolova 5021.49
Marian Ivanov 4500.85
Stela Dimitrova 6100.00
*/

