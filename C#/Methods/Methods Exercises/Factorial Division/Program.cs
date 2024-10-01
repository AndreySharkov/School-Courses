namespace Factorial_Division
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse( Console.ReadLine());
            Console.WriteLine($"{GetFactoralDivision(num1,num2):f2}");
        }
        static decimal GetFactoralDivision(int FirstNumber, int SecondNumber)
        {
            decimal Fact1 = CalculateFactorial(FirstNumber);
            decimal Fact2 = CalculateFactorial(SecondNumber);
            return Fact1 / Fact2;
        }
        static int CalculateFactorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * CalculateFactorial(n - 1);
            }
        }
    }
}