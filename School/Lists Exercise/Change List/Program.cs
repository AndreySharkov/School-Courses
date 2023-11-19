namespace Change_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();
            string[] command = ReadCommand();
            while (command[0]?.ToLower() != "end")
            {
                switch (command[0]?.ToLower())
                {
                    case "delete":
                        list = DeleteNumFromList(list, int.Parse(command[1]));
                    break;
                    case "insert":
                        list = InsertNumInList(list, int.Parse(command[1]), int.Parse(command[2]));
                        break;
                }
                command = ReadCommand();
            }
            Console.WriteLine(string.Join(" ", list));
        }
        static string[] ReadCommand()
        {
            return Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries).ToArray();
        }
        static List<int> DeleteNumFromList(List<int> list, int num)
        {
            list.Remove(num);
            return list;

        }
        static List<int> InsertNumInList(List<int> list, int num, int position)
        {
            list.Insert(position, num);
            return list;
        }

    }
}