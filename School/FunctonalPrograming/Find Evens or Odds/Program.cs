namespace Find_Evens_or_Odds
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Predicate<int> filter;
            int[] nums = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string oddOrEven = Console.ReadLine();
            if(oddOrEven == "odd")
            {
                filter = isOdd;
            }
            else
            {
                filter = isEven;
            }
            List<int> result = new List<int>();
            for(int i = nums[0]; i <= nums[1]; i++)
            {
                if (filter(i))
                {
                    result.Add(i);
                }
            }
            Console.WriteLine(string.Join(" ", result));

        }
        static bool isOdd(int i)
        {
            return i % 2 != 0;
        }
        static bool isEven(int i)
        {
            return i % 2 == 0;
        }

    }
}