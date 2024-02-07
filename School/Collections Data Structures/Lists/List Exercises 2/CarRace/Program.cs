namespace CarRace
{
    internal class Program
    {
        static void Main()
        {
            List<int> raceTimes1 = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            

            CalculateRaceWinner(raceTimes1);
            
        }

        static void CalculateRaceWinner(List<int> raceTimes)
        {
            int middleIndex = raceTimes.Count / 2;
            double leftRacerTime = 0;
            double rightRacerTime = 0;

            for (int i = 0; i < raceTimes.Count; i++)
            {
                if (i < middleIndex)
                {
                    leftRacerTime += raceTimes[i];
                    if (raceTimes[i] == 0)
                    {
                        leftRacerTime *= 0.8;
                    }
                }
                else if (i > middleIndex)
                {
                    rightRacerTime += raceTimes[i];
                    if (raceTimes[i] == 0)
                    {
                        rightRacerTime *= 0.8;
                    }
                }
            }

            string winner;
            double totalTime;
            if (leftRacerTime <= rightRacerTime)
            {
                winner = "left";
                totalTime = leftRacerTime;
            }
            else
            {
                winner = "right";
                totalTime = rightRacerTime;
            }
            
            if(totalTime % 1 ==  0)
            {
                Console.WriteLine($"The winner is {winner} with total time: {totalTime}");
            }
            else
            {
                Console.WriteLine($"The winner is {winner} with total time: {totalTime:f1}");
            }
            

            
        }
    }
}