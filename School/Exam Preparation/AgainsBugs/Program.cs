namespace AgainsBugs
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int plantsCount = int.Parse(Console.ReadLine());
            List<int> plants = Console.ReadLine().Split().Select(int.Parse).ToList();

            int days = 0;
            while(plantsCount >= 0)
            {
                int jerrys = 0;

                for(int i = 0; i < plants.Count; i++)
                {
                    if (i != 0)
                    {
                        if (plants[i] > plants[i - 1])
                        {
                            plants.RemoveAt(i - 1);
                            jerrys++;
                        }
                    }
                }
                if (jerrys == 0)
                {
                    days--;
                    break;
                }
                days++;
            }
            Console.WriteLine(days);

        }
    }
}