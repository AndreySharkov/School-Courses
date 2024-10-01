namespace Palindrome_Integers
{
    internal class Program
    {
        static void Main()
        {
            string input = Console.ReadLine();

            while (input != "END")
            {
                Console.WriteLine(CheckIfPalindrome(input));
                input = Console.ReadLine();
            }
        }

        static string CheckIfPalindrome(string number)
        {
            for (int i = 0; i < number.Length / 2; i++)
            {
                if (number[i] == number[number.Length - i - 1])
                {
                    return "true";
                }
            }
            return "false";
        }
    }
}