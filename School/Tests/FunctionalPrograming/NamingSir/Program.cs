namespace NamingSir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] names = Console.ReadLine().Split();
            Action<string[]> action = x => { foreach (string name in names) { Console.WriteLine("Sir " + name); } };
            action(names);
        }
    }
}