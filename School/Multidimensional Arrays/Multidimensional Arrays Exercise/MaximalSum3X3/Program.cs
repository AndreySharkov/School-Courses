namespace MaximalSum3X3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            int[,] matrix = new int[sizes[0], sizes[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                int[] colElements = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int MaxSum = 0;
            int[] TopSizes = { 0, 0 };
            for (int i = 0; i < matrix.GetLength(0) - 2; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 2; j++)
                {
                    int currentSun = matrix[i, j] + matrix[i + 1, j] + matrix[i + 2, j] +
                        matrix[i, j + 1] + matrix[i + 1, j + 1] + matrix[i + 2, j + 1] +
                        matrix[i, j + 2] + matrix[i + 1, j + 2] + matrix[i + 2, j + 2];
                    if (currentSun > MaxSum)
                    {
                        MaxSum = currentSun;
                        TopSizes[0] = i;
                        TopSizes[1] = j;
                    }
                }
            }
            Console.WriteLine($"Sum = {MaxSum}");
            Console.WriteLine($"{matrix[TopSizes[0]    , TopSizes[1]]} {matrix[TopSizes[0], TopSizes[1] + 1]} {matrix[TopSizes[0], TopSizes[1] + 2]}");
            Console.WriteLine($"{matrix[TopSizes[0] + 1, TopSizes[1]]} {matrix[TopSizes[0] + 1, TopSizes[1] + 1]} {matrix[TopSizes[0] + 1, TopSizes[1] + 2]}");
            Console.WriteLine($"{matrix[TopSizes[0] + 2, TopSizes[1]]} {matrix[TopSizes[0] + 2, TopSizes[1] + 1]} {matrix[TopSizes[0] + 2, TopSizes[1] + 2]}");

            
        }
    }
}