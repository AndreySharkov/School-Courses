namespace Jagged_Array_Modification
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int[][] matrix = new int[n][];
            for (int i = 0; i < n; i++)
            {
                matrix[i] = Console.ReadLine().Split().Select(int.Parse).ToArray();
            }
            string commandString;
            while ((commandString = Console.ReadLine()) != "END")
            {
                string[] command = commandString.Split().ToArray();
                int row = int.Parse(command[1]);
                int col = int.Parse(command[2]);
                int value = int.Parse(command[3]);
                
                if (IsValidCoordinates(row, col, n))
                {
                    switch (command[0].ToLower())
                    {
                        case "add":

                            matrix[row][col] += value;
                            break;
                        case "subtract":
                            matrix[row][col] -= value;
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Invalid coordinates");
                }
            }
            foreach (int[] row in matrix)
            {
                Console.WriteLine(string.Join(" ", row));
            }
        }
        
        static bool IsValidCoordinates(int row, int col, int n)
        {
            return row >= 0 && row < n && col >= 0 && col < n;
        }

    }
}