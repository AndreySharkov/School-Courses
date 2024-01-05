namespace PascalTriangle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            long[][] triangle = new long[n][];

            for (int i = 0; i < n; i++)
            {
                triangle[i] = new long[i + 1];
                triangle[i][0] = 1;

                for (int j = 1; j < i; j++)
                {
                    triangle[i][j] = triangle[i - 1][j - 1] + triangle[i - 1][j];
                }

                triangle[i][i] = 1;

                Console.WriteLine(string.Join(" ", triangle[i]));
            }
        }
    }
}