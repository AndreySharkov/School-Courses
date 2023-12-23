namespace Inventory
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> items = Console.ReadLine().Split(", ").ToList();
            string commandString;
            while((commandString = Console.ReadLine()) != "Craft!")
            {
                string[] command = commandString.Split("-").ToArray();
                switch(command[0].Trim().ToLower())
                {
                    case "collect":
                        items.Add(command[1].Trim());
                        break;
                    case "drop":
                        items.Remove(command[1].Trim());
                        break;
                    case "combine items":
                        if (items.Contains(command[1]))
                        {
                            List<string> Jerry = command[1].Split(":").ToList();
                            items.Insert(items.IndexOf(Jerry[0]), Jerry[1]);
                        }
                        break;
                    case "renew":
                        items.Remove(command[1]);
                        items.Add(command[1]);
                        break;
                }
            }
            Console.WriteLine(string.Join(", ", items));
        }
    }
}