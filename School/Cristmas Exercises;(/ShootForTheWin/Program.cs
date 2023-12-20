namespace ShootForTheWin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] targets = Console.ReadLine().Split().Select(int.Parse).ToArray();
            string command;
            int shotTargetsCount = 0;
            while ((command = Console.ReadLine()) != "End")
            {
                int index = int.Parse(command);

                if (index < 0 || index >= targets.Length || targets[index] == -1)
                {
                    continue;
                }

                int shotValue = targets[index];
                targets[index] = -1;
                shotTargetsCount++;

                for (int i = 0; i < targets.Length; i++)
                {
                    if (targets[i] > shotValue)
                    {
                        targets[i] -= shotValue;
                    }
                    else if (targets[i] != -1)
                    {
                        targets[i] += shotValue;
                    }
                }
            }
            Console.WriteLine($"Shot targets: {shotTargetsCount} -> {string.Join(" ", targets)}");
        }
    }
}