using System;
using System.Linq;
namespace RadioactiveMutantVampireBunnies
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimensions = Console.ReadLine().Split().Select(int.Parse).ToArray();
            char[,] matrix = new char[dimensions[0], dimensions[1]];
            int playerRow = 0;
            int playerCol = 0;
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                char[] rowValues = Console.ReadLine().ToCharArray();
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    matrix[row, col] = rowValues[col];
                    if (matrix[row, col] == 'P')
                    {
                        playerRow = row;
                        playerCol = col;
                    }
                }
            }
            char[] directions = Console.ReadLine().ToCharArray();
            bool isWon = false;
            bool isDead = false;
            foreach (char direction in directions)
            {
                int playerNewRow = playerRow;
                int playerNewCol = playerCol;
                switch (direction)
                {
                    case 'U':
                        playerNewRow--;
                        break;
                    case 'D':
                        playerNewRow++;
                        break;
                    case 'L':
                        playerNewCol--;
                        break;
                    case 'R':
                        playerNewRow++;
                        break;
                }
                isWon = Won(matrix, playerNewRow, playerNewCol);
                if (!isWon)
                {
                    isDead = Death(matrix, 'B', playerNewRow, playerNewCol);
                    if (!isDead)
                    {
                        matrix[playerRow, playerCol] = 'P';
                    }
                    matrix[playerRow, playerCol] = '.';
                    playerRow = playerNewRow;
                    playerCol = playerNewCol;
                }
                else
                {
                    matrix[playerRow, playerCol] = '.';
                }
                List<int> coordinatesBunnies = new List<int>();
                for (int row = 0; row < matrix.GetLength(0); row++)
                {
                    for (int col = 0; col < matrix.GetLength(1); col++)
                    {
                        if (matrix[row, col] == 'B')
                        {
                            coordinatesBunnies.Add(row);
                            coordinatesBunnies.Add(col);
                        }
                    }
                }
                for (int i = 0; i < coordinatesBunnies.Count; i += 2)
                {
                    int rowBunny = coordinatesBunnies[i];
                    int colBunny = coordinatesBunnies[i + 1];
                    SpreadBunny(matrix, rowBunny, colBunny);
                }
                isDead = Death(matrix, 'B', playerRow, playerCol);
                if (isDead || isWon)
                {
                    break;
                }
            }
            PrintMatrix(matrix);
            if (isWon)
            {
                Console.WriteLine($"won: {playerRow} {playerCol}");
            }
            else if (isDead)
            {
                Console.WriteLine($"dead: {playerRow} {playerCol}");
            }
        }

        static bool Death(char[,] matrix, char symbol, int playerNewRow, int playerNewCol)
        {
            bool isDead = false;
            if (matrix[playerNewRow, playerNewCol] == symbol)
            {
                isDead = true;
            }
            return isDead;
        }

        static bool Won(char[,] matrix, int playerNewRow, int playerNewCol)
        {
            bool isWon = true;
            if ((playerNewRow >= 0 && playerNewRow < matrix.GetLength(0)) && (playerNewCol >= 0 && playerNewCol < matrix.GetLength(1)))
            {
                isWon = false;
            }
            return isWon;
        }


        static void PrintMatrix(char[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }

        }

        static void SpreadBunny(char[,] matrix, int rowBunny, int colBunny)
        {
            if (rowBunny + 1 < matrix.GetLength(0))
            {

                matrix[rowBunny + 1, colBunny] = 'B';
            }
            if (rowBunny - 1 >= 0)
            {
                matrix[rowBunny - 1, colBunny] = 'B';
            }
            if (colBunny + 1 < matrix.GetLength(1))
            {
                matrix[rowBunny, colBunny + 1] = 'B';
            }

            if (colBunny - 1 >= 0)
            {
                matrix[rowBunny, colBunny - 1] = 'B';
            }


        }
    }
}