namespace SqareInMatrix
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sizes = Console.ReadLine().Split(" ").Select(int.Parse).ToArray();
            char[,] matrix = new char[sizes[0], sizes[1]];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string[] colElements = Console.ReadLine().Split(" ").ToArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = char.Parse(colElements[col]);
                }
            }
            
            
            int matrices = 0;
            for (int i = 0; i < matrix.GetLength(0) - 1; i++)
            {
                for (int j = 0; j < matrix.GetLength(1) - 1; j++)
                {
                    if (matrix[i, j] == matrix[i, j + 1] && matrix[i + 1, j] == matrix[i + 1, j + 1] && matrix[i, j] == matrix[i + 1, j])
                    {
                        matrices++;
                    }
                }
            }
            Console.WriteLine(matrices);
        }
    }
}