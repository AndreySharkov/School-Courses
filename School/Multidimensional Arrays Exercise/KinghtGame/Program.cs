namespace KnightGame
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                string colElements = Console.ReadLine();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = colElements[col];
                }
            }
            int[] knightMovesRow = { -2, -1, 1, 2, 2, 1, -1, -2 };
            int[] knightMovesCol = { 1, 2, 2, 1, -1, -2, -2, -1 };
            int RemovedKnights = 0;
            while (true)
            {
                int MaxAtacks = 0;
                int[] KnightCords = { 0, 0 };
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(0); col++)
                    {
                        if (matrix[row, col] == 'K')
                        {
                            int currentAtacks = 0;
                            for (int i = 0; i < 8; i++)
                            {
                                if (row + knightMovesRow[i] >= 0
                                    && row + knightMovesRow[i] < size
                                    && col + knightMovesCol[i] >= 0
                                    && col + knightMovesCol[i] < size
                                    && matrix[row + knightMovesRow[i], col + knightMovesCol[i]] == 'K')
                                {
                                    currentAtacks++;
                                }
                            }
                            if (currentAtacks > MaxAtacks)
                            {
                                MaxAtacks = currentAtacks;
                                KnightCords[0] = row;
                                KnightCords[1] = col;
                            }
                        }
                    }
                }
                if (MaxAtacks == 0)
                {
                    break;
                }
                matrix[KnightCords[0], KnightCords[1]] = '0';
                RemovedKnights++;
            }
            Console.WriteLine(RemovedKnights);
        }
    }
}