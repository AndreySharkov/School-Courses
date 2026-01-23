namespace DefiningSimpleClses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string firstInputDate = Console.ReadLine();
            string secondInputDate = Console.ReadLine();
            DateCounter counter = new DateCounter();
            Console.WriteLine(counter.CalculateDifference(firstInputDate, secondInputDate));
        }
    }
}
