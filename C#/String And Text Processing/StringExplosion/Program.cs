namespace StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = Console.ReadLine();
            int explosion = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if (text[i] == '>' && char.IsDigit(text[i + 1]))
                {
                    explosion += int.Parse(text[i + 1].ToString());
                }
                else if (text[i] != '>' && explosion > 0)
                {
                    text = text.Remove(i, 1);
                    explosion--;
                    i--;
                }
            }
            Console.WriteLine(text);


        }
    }
}