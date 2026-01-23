namespace PlayCatch
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            int[] array = Console.ReadLine().Split().Select(int.Parse).ToArray();
            int exceptionCount = 0;

            while (exceptionCount < 3)
            {
                string[] command = Console.ReadLine().Split();

                try
                {
                    string action = command[0];
                    switch (action)
                    {
                        case "Replace":
                            array[int.Parse(command[1])] = int.Parse(command[2]);
                            break;
                        case "Print":
                            Console.WriteLine(string.Join(", ", array[int.Parse(command[1])..(int.Parse(command[2]) + 1)]));
                            break;
                        case "Show":
                            Console.WriteLine(array[int.Parse(command[1])]);
                            break;
                    }
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionCount++;
                }
                catch (IndexOutOfRangeException)
                {
                    Console.WriteLine("The index does not exist!");
                    exceptionCount++;
                }
                catch (FormatException)
                {
                    Console.WriteLine("The variable is not in the correct format!");
                    exceptionCount++;
                }
            }

            Console.WriteLine(string.Join(", ", array));
        }
    }
}
