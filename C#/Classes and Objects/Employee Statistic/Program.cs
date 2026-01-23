namespace Employee_Statistic
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<Employees> employees = new List<Employees>();
            for (int i = 0; i < n; i++)
            {
                string[] employeeIn = Console.ReadLine().Split();
                Employees employee = new Employees(employeeIn[0], double.Parse(employeeIn[1]), employeeIn[2]);
                employees.Add(employee);
            }
            Dictionary<string, double> highAvSalary = new Dictionary<string, double>();
            foreach (Employees employee in employees)
            {
                if (!highAvSalary.ContainsKey(employee.Development))
                {
                    highAvSalary.Add(employee.Development, employee.Salary);
                }
                else
                {
                    highAvSalary[employee.Development] = (highAvSalary[employee.Development] + employee.Salary) / 2 ;
                }
            }
            employees = employees.OrderByDescending(x => x.Salary).ToList();
            foreach(string key in highAvSalary.Keys)
            {
                if (highAvSalary[key] == highAvSalary.Values.Max())
                {
                    Console.WriteLine($"Highest Average Salary: {key}");
                    foreach(Employees employee in employees)
                    {
                        if(employee.Development == key)
                        {
                            Console.WriteLine($"{employee.Name} {employee.Salary:f2}");
                        }
                    }
                    break;
                }
            }

            
            
        }
    }
    class Employees
    {
        public string Name { get; set; }
        public double Salary { get; set; }
        public string Development { get; set; }
        

        public Employees(string firstName, double salary, string development)
        {
            Name = firstName;
            Salary = salary;
            Development = development;

        }
    }
}

