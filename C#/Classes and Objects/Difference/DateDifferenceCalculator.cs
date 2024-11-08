using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Difference
{
    public class DateDifferenceCalculator
    {
        public int CalculateDaysBetween(string date1, string date2)
        {
            string dateFormat = "yyyy MM dd";
            DateTime dateObj1 = DateTime.ParseExact(date1, dateFormat, null);
            DateTime dateObj2 = DateTime.ParseExact(date2, dateFormat, null);
            int daysDifference = Math.Abs((dateObj2 - dateObj1).Days);
            Console.WriteLine(daysDifference);
            return daysDifference;
        }
    }

}
