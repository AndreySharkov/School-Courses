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
                if (charInNum1 < charInNum2)
                {
                    for (int i = ++charInNum1; i < charInNum2; i++)
                    {

                        Console.Write(Convert.ToChar(i) + " ");
                    }
                }
                else
                {
                    for (int i = ++charInNum2; i < charInNum1; i++)
                    {

                        Console.Write(Convert.ToChar(i) + " ");
                    }
                }
                
                Console.WriteLine();
            }
        }
    }
}