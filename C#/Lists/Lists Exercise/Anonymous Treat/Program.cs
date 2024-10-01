namespace Anonymous_Treat
{
    internal class Program
    {
        static void Main()
        {
            List<string> data = Console.ReadLine().Split().ToList();

            string command;
            while ((command = Console.ReadLine()) != "3:1")
            {
                string[] commandArgs = command.Split();
                string action = commandArgs[0];

                if (action == "merge")
                {
                    int startIndex = Math.Max(0, int.Parse(commandArgs[1]));
                    int endIndex = Math.Min(data.Count - 1, int.Parse(commandArgs[2]));

                    MergeData(data, startIndex, endIndex);
                }
                else if (action == "divide")
                {
                    int index = int.Parse(commandArgs[1]);
                    int partitions = int.Parse(commandArgs[2]);

                    DivideData(data, index, partitions);
                }
            }

            Console.WriteLine(string.Join(" ", data));
        }

        static void MergeData(List<string> data, int startIndex, int endIndex)
        {
            int elementsToRemove = endIndex - startIndex;

            for (int i = 1; i <= elementsToRemove; i++)
            {
                data[startIndex] += data[startIndex + 1];
                data.RemoveAt(startIndex + 1);
            }
        }

        static void DivideData(List<string> data, int index, int partitions)
        {
            string currentString = data[index];
            int partLength = currentString.Length / partitions;
            int remainder = currentString.Length % partitions;

            List<string> dividedParts = new List<string>();

            for (int i = 0; i < partitions; i++)
            {
                int length = partLength + (i < remainder ? 1 : 0);
                dividedParts.Add(currentString.Substring(0, length));
                currentString = currentString.Substring(length);
            }

            data.RemoveAt(index);
            data.InsertRange(index, dividedParts);
        }
    }
}