namespace Vowels_Count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string word = Console.ReadLine();
            Console.WriteLine(GetVowelsCount(word));
        }
        static int GetVowelsCount(string word)
        {
            string vowels = "aeuio";
            int VowelsCount = 0;
            foreach (char c in word.ToLower())
            {
                if(vowels.Contains(c))
                {
                    VowelsCount++;
                }
            }
            return VowelsCount;
        }
    }
}