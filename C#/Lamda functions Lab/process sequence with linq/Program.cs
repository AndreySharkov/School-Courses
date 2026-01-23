namespace Squared_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            Console.WriteLine(square(num));
        }
        static int square(int num) => num + num;
    }
}