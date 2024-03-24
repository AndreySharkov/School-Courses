namespace Calculations_with_Characters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            int sum = 0;
            if (names[0].Length == names[1].Length)
            {
                for(int i = 0; i < names[0].Length; i++)
                {
                    sum += names[0][i] * names[1][i];
                }
            }
            else
            {
                for (int i = 0; i < names[0].Length; i++)
                {
                    sum += names[0][i];
                }
                for (int i = 0; i < names[1].Length; i++)
                {
                    sum += names[1][i];
                }
            }
            Console.WriteLine(sum);
        }
    }
}