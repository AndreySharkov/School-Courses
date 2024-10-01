namespace MathPower
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());
            int power = int.Parse(Console.ReadLine());
            Console.WriteLine(RaisedToPower(n, power));
        }
        static double RaisedToPower(double number, int power)
        {
            return Math.Pow(number, power);
        }
    }
}