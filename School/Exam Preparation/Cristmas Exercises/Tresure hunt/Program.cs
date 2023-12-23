namespace Tresure_hunt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> treasureChest = Console.ReadLine().Split("|").ToList();

            string command;
            while ((command = Console.ReadLine()) != "Yohoho!")
            {
                string[] tokens = command.Split();
                string action = tokens[0];

                switch (action)
                {
                    case "Loot":
                        for (int i = 1; i < tokens.Length; i++)
                        {
                            string item = tokens[i];
                            if (!treasureChest.Contains(item))
                            {
                                treasureChest.Insert(0, item);
                            }
                        }
                        break;

                    case "Drop":
                        int index = int.Parse(tokens[1]);
                        if (index >= 0 && index < treasureChest.Count)
                        {
                            string droppedItem = treasureChest[index];
                            treasureChest.RemoveAt(index);
                            treasureChest.Add(droppedItem);
                        }
                        break;

                    case "Steal":
                        int count = Math.Min(int.Parse(tokens[1]), treasureChest.Count);
                        List<string> stolenItems = treasureChest.TakeLast(count).ToList();
                        treasureChest.RemoveRange(treasureChest.Count - count, count);
                        Console.WriteLine(string.Join(", ", stolenItems));
                        break;
                }
            }

            double averageGain = treasureChest.Sum(item => item.Length) / (double)treasureChest.Count;

            if (treasureChest.Count > 0)
            {
                Console.WriteLine($"Average treasure gain: {averageGain:F2} pirate credits.");
            }
            else
            {
                Console.WriteLine("Failed treasure hunt.");
            }
        }
    }
    
}