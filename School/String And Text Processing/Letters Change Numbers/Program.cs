namespace Letters_Change_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] Calsulations = Console.ReadLine().Split();
            double result = 0;
            string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            foreach (string calculation in Calsulations)
            {
                double calcNum = getNums(calculation);
                if (calculation[0] == calculation.ToLower()[0])
                {
                    calcNum *= alphabet.IndexOf(calculation[0]);
                }
                else
                {
                    calcNum /= alphabet.IndexOf(calculation[0]);
                }
                if (calculation[calculation.Length -1] == calculation.ToLower()[calculation.Length - 1])
                {
                    calcNum += alphabet.IndexOf(calculation[calculation.Length - 1]);
                }
                else
                {
                    calcNum -= alphabet.IndexOf(calculation[calculation.Length - 1]);
                }
                result += calcNum;
            }
            Console.WriteLine($"{result:f2}");

        }
        static double getNums(string calculation)
        {
            double result = 0;
            foreach (char c in calculation)
            {
                if (char.IsDigit(c))
                {
                    result += c;
                }
            }
            return result;
        }
    }
}