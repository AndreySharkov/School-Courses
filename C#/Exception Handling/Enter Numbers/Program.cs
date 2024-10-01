namespace Enter_Numbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start = 1;
            int end = 100;

            List<int> numbers = new List<int>();

            while (numbers.Count < 10)
            {
                start = ReadNumber(start, end);

                if (start > 1)
                {
                    numbers.Add(start);
                }
            }

            Console.WriteLine(string.Join(", ", numbers));


            int ReadNumber(int start, int end)
            {
                try
                {
                    int number = int.Parse(Console.ReadLine());

                    if (number <= start || number >= end)
                    {
                        throw new Exception($"Your number is not in range {start} - {end}!");
                    }

                    return number;
                }
                catch (FormatException)
                {
                    Console.WriteLine("Invalid Number!");
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }

                return 1;
            }
        }
    }
}
