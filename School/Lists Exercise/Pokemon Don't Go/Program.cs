namespace Pokemon_Don_t_Go
{
    internal class Program
    {
        static void Main()
        {
            List<int> distances = Console.ReadLine().Split().Select(int.Parse).ToList();
            int sumOfRemovedElements = 0;

            string input;
            while ((input = Console.ReadLine()) != null && input != "")
            {
                int index = int.Parse(input);

                if (index < 0)
                {
                    int removedElement = distances[0];
                    sumOfRemovedElements += removedElement;
                    distances.RemoveAt(0);
                    distances.Insert(0, distances[distances.Count - 1]);

                    IncreaseDecrease(distances, removedElement);
                }
                else if (index >= distances.Count)
                {
                    int removedElement = distances[distances.Count - 1];
                    sumOfRemovedElements += removedElement;
                    distances.RemoveAt(distances.Count - 1);
                    distances.Add(distances[0]);

                    IncreaseDecrease(distances, removedElement);
                }
                else
                {
                    int removedElement = distances[index];
                    sumOfRemovedElements += removedElement;
                    distances.RemoveAt(index);

                    IncreaseDecrease(distances, removedElement);
                }
            }

            Console.WriteLine(sumOfRemovedElements);
        }

        static void IncreaseDecrease(List<int> distances, int removedElement)
        {
            for (int i = 0; i < distances.Count; i++)
            {
                if (distances[i] <= removedElement)
                {
                    distances[i] += removedElement;
                }
                else
                {
                    distances[i] -= removedElement;
                }
            }
        }
    }
}