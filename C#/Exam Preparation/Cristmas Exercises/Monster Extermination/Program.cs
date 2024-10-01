

class MonsterExtermination
{
    static void Main()
    {
        List<int> armorValues = Console.ReadLine().Split(',').Select(int.Parse).ToList();
        List<int> strikingImpactValues = Console.ReadLine().Split(',').Select(int.Parse).ToList();

        var result = BattleSimulation(armorValues, strikingImpactValues);

        if (result.remainingStrikes.Count == 0)
        {
            Console.WriteLine("All monsters have been killed!");
        }
        else
        {
            Console.WriteLine("The soldier has been defeated.");
        }

        Console.WriteLine($"Total monsters killed: {result.killedMonsters}");
    }

    static (int killedMonsters, List<int> remainingStrikes) BattleSimulation(List<int> armorSequence, List<int> strikingImpactSequence)
    {
        int killedMonsters = 0;
        List<int> remainingStrikes = new List<int>();

        while (armorSequence.Any() && strikingImpactSequence.Any())
        {
            int currentArmor = armorSequence.First();
            int currentImpact = strikingImpactSequence.Last();

            if (currentImpact >= currentArmor)
            {
                killedMonsters++;

                if (strikingImpactSequence.Count > 1)
                {
                    strikingImpactSequence[strikingImpactSequence.Count - 2] += currentImpact - currentArmor;
                }
            }
            else
            {
                armorSequence[0] -= currentImpact;
                remainingStrikes.Insert(0, strikingImpactSequence.Last());
            }

            armorSequence.RemoveAt(0);
            strikingImpactSequence.RemoveAt(strikingImpactSequence.Count - 1);
        }

        return (killedMonsters, remainingStrikes);
    }
}
