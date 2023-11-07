namespace CharsInRange
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char firstChar = char.Parse(Console.ReadLine());
            char secondChar = char.Parse(Console.ReadLine());
            PrintChars(firstChar, secondChar);
        
            static void PrintChars(char char1, char char2)
            {
                int charInNum1 = char1;
                int charInNum2 = char2;
                for (int i = char1; i < charInNum2; i++)
                {
                    Console.Write(i++ + " ");
                }
            }
    }
}