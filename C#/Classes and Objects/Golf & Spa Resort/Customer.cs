using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf___Spa_Resort
{
    public class Customer : IPerson
    {
        public string FirstName { get; }
        public string LastName { get; }

        public Customer(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
}
