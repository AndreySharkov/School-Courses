namespace Train
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> train = GetIntList();

            int capacity = int.Parse(Console.ReadLine());

            string[] command = GetStringArr();

            while (command[0]?.ToLower() != "end")
            {
                switch (command[0]?.ToLower())
                {
                    case "add":
                        train.Add(int.Parse(command[1]));
                        break;
                    default:
                        AddNumberToList(train, capacity, int.Parse(command[0]));
                        break;
                }
                command = GetStringArr();
            }
            Console.WriteLine(string.Join(" ", train));
        }
        static List<int> GetIntList()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
        }
        static string[] GetStringArr()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
        static List <int> AddNumberToList(List<int> train, int capacity, int number)
        {
            
            for (int i = 0; i < train.Count; i++)
            {
                if (train[i] + number <= capacity)
                {
                    train[i] += number;
                    break;
                }
                
                
            }
            return train;
        }
    }
}