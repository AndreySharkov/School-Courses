namespace AddVat
{
    internal class Program
    {
        public delegate double Multiplier(double x);

        static void Main(string[] args)
        {
            Multiplier calc = (x) => x + x * 0.2;
            double[] nums = Console.ReadLine().Split(", ").Select(double.Parse).Select(x => calc(x)).ToArray();
            foreach (double x in nums)
            {
                Console.WriteLine($"{x:f2}");
            }
        }

    }
}