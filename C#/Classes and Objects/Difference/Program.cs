namespace Difference
{
    using System;

    class Program
    {
        static void Main()
        {
            DateDifferenceCalculator calculator = new DateDifferenceCalculator();
            string date1 = Console.ReadLine();
            string date2 = Console.ReadLine();
            calculator.CalculateDaysBetween(date1, date2); 
        }
    }

}
