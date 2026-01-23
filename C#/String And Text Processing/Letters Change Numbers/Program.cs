namespace Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Calculations = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            double result = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            alphabet = alphabet.ToLower();
            
            foreach (string calculation in Calculations)
            {
                double calcNum = getNums(calculation);
                if (calculation[0] == calculation.ToLower()[0])
                {
                    calcNum *= alphabet.IndexOf(calculation[0]) + 1;
                }
                else
                {
                    calcNum /= alphabet.IndexOf(calculation.ToLower()[0]) + 1;
                }
                if (calculation[calculation.Length -1] == calculation.ToLower()[calculation.Length - 1])
                {
                    calcNum += alphabet.IndexOf(calculation[calculation.Length - 1]) + 1;
                }
                else
                {
                    calcNum -= alphabet.IndexOf(calculation.ToLower()[calculation.Length - 1]) + 1;
                }
                result += calcNum;
            }
            Console.ReadLine();
            Console.WriteLine($"{result:f2}");

        }
        static double getNums(string calculation)
        {
            double result = 0;
            string currentNumber = "";

            foreach (char c in calculation)
            {
                if (char.IsDigit(c))
                {
                    currentNumber += c;
                }
            }
            result += double.Parse(currentNumber);
            return result;
        }
    }
}