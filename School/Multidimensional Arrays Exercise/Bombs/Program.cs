namespace Bombs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[,] matrix = new int[size, size];

            for (int row = 0; row < size; row++)
            {
                int[] colElements = Console.ReadLine().Split().Select(int.Parse).ToArray();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }

            string[] commandStrings = Console.ReadLine().Split(" ").ToArray();
            int[] cellsToExplodeRow = { -1, -1, -1, 0, 0, 1, 1, 1 };
            int[] cellsToExplodeCol = { -1, 0, 1, -1, 1, -1, 0, 1 };

            foreach (string commandString in commandStrings)
            {
                int[] command = commandString.Split(",").Select(int.Parse).ToArray();

                if (matrix[command[0], command[1]] > 0)
                {
                    int bombValue = matrix[command[0], command[1]];

                    for (int cell = 0; cell < 8; cell++)
                    {
                        int newRow = command[0] + cellsToExplodeRow[cell];
                        int newCol = command[1] + cellsToExplodeCol[cell];

                        if (newRow >= 0 && newRow < size && newCol >= 0 && newCol < size && matrix[newRow, newCol] > 0)
                        {
                            matrix[newRow, newCol] -= bombValue;
                        }
                    }

                    matrix[command[0], command[1]] = 0;
                }
            }

            int aliveCells = 0;
            int sum = 0;

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    if (matrix[row, col] > 0)
                    {
                        aliveCells++;
                        sum += matrix[row, col];
                    }
                }
            }

            Console.WriteLine($"Alive cells: {aliveCells}");
            Console.WriteLine($"Sum: {sum}");

            for (int row = 0; row < size; row++)
            {
                for (int col = 0; col < size; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }

                Console.WriteLine("");
            }
        }
    }
}
