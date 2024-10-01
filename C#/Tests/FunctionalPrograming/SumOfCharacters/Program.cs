namespace SumOfCharacters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string[] names = Console.ReadLine().Split();
            Func<string, int> CharSum = x => x.Select(x => (int)x).Sum();
            Func<string, Func<string, int>, bool> MainProgram = (x, l) => n <= l(x);
            names = names.Where(x => MainProgram(x, CharSum)).ToArray();
            foreach (string name in names)
            {
                Console.WriteLine(name);
            }   
        }
    }
}