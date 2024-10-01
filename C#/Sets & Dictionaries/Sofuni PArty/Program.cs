namespace Sofuni_PArty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HashSet<string> set = new HashSet<string>();
            string command;
            bool partyTime = false;
            while((command = Console.ReadLine()) != "END")
            {
                if (command == "PARTY")
                {
                    partyTime = true;
                }
                else if (!partyTime)
                {
                    set.Add(command);
                }
                else
                {
                    set.Remove(command);
                }
               
            }
            Console.WriteLine(set.Count);
            foreach(string s in set)
            {
                if (char.IsDigit(s, 0))
                {
                    Console.WriteLine(s);
                    set.Remove(s);
                }
            }
            foreach (string s in set)
            {
                Console.WriteLine(s);
            }
        }
    }
}