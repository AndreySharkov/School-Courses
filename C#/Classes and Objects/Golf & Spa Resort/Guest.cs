using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Golf___Spa_Resort
{
    public class Guest : Customer
    {
        public Guest(string firstName, string lastName)
            : base(firstName, lastName)
        {

        }

        public string NewGuest()
        {
            return $"Mr/Ms/Mrs {FirstName} {LastName} registers as a guest.";
        }
    }
}
