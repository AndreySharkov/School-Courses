namespace Mathcalculations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double FirstN = double.Parse(Console.ReadLine());
            string operation = Console.ReadLine();
            double SecondN = double.Parse(Console.ReadLine());
            Console.WriteLine(Eval(FirstN, operation, SecondN));
        }
        static double Eval(double n1, string oper, double secondN)
        {
            switch (oper)
            {
                case "+":
                    return n1 + secondN;
                case "-":
                    return n1 - secondN;
                case "*":
                    return n1 * secondN;
                case "/":
                    return n1 / secondN;
                default:
                    return 0;
            }
            
        }
    }
}