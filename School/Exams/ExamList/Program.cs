namespace ExamList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            List<string> list = new List<string>();
            for (int i = 0;  i < n; i++)
            {
                list.Add(Console.ReadLine());
            }
            list.Sort();
            for (int i = 0; i < list.Count;i++)
            {
                Console.WriteLine(list[i]);
            }
        }
    }
}