using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf___Spa_Resort
{
    internal class Employee : IPerson
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Department { get; set; }
        public int EmployeeId { get; set; }

        public Employee(string firstName, string lastName, string department, int employeeId)
        {
            Department = department;
            EmployeeId = employeeId;
        }

        public string StartWorkingDay()
        {
            return $"{FirstName} {LastName} with id {EmployeeId} starts a new working day in the department {Department}.";
        }
    }
}
