namespace ActionPrint
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string> printf = x => { Console.WriteLine(x); };
            foreach (string name in names)
            {
                printf(name);
            }
        }
    }
}