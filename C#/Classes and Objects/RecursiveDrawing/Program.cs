namespace RecursiveDrawing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            for (int i = -num; i < num; i++)
            {
                for (int k = 0; k > i; k--)
                {
                    Console.Write('*');
                }
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("#");
                }
                Console.WriteLine();
            }
        }
    }
}
