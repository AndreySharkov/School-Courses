using System;

class Program
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());

        int[] petrol = new int[n];
        int[] distance = new int[n];

        for (int i = 0; i < n; i++)
        {
            string[] input = Console.ReadLine().Split();
            petrol[i] = int.Parse(input[0]);
            distance[i] = int.Parse(input[1]);
        }

        int startIdx = FindStartingPoint(n, petrol, distance);
        Console.WriteLine(startIdx);
    }

    static int FindStartingPoint(int n, int[] petrol, int[] distance)
    {
        int totalPetrol = 0;
        int currentPetrol = 0;
        int startIdx = 0;

        for (int i = 0; i < n; i++)
        {
            totalPetrol += petrol[i] - distance[i];

            if (currentPetrol < 0)
            {
                currentPetrol = petrol[i] - distance[i];
                startIdx = i;
            }
            else
            {
                currentPetrol += petrol[i] - distance[i];
            }
        }

        return totalPetrol >= 0 ? startIdx : -1;
    }
}
