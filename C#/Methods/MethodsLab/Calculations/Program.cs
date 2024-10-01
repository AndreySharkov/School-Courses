namespace Calculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            if (input == "divide")
            {
                
                divide(num1, num2);
            }
            else if (input == "subtrack")
            {
                subtrack(num1, num2);
            }
            else if (input == "add")
            {
                add(num1, num2);
            }
            else if (input == "multiply")
            {
                multiply(num1, num2);
            }
        }
        static void subtrack(int num1, int num2)
        {
            Console.WriteLine(num1 - num2);
        }
        static void divide(int num1, int num2)
        {
            double number = num1 / num2;
            Console.WriteLine(number);
        }
        static void multiply(int num1, int num2)
        {
            Console.WriteLine(num1 * num2);
        }
        static void add(int num1, int num2)
        {
            Console.WriteLine(num1 + num2);
        }
    }
}