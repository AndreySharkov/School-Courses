using System.Text;

namespace TakeSkipRope
{
    internal class Program
    {
        static void Main()
        {
            string encryptedMessage = Console.ReadLine();
            string decryptedMessage = DecryptMessage(encryptedMessage);
            Console.WriteLine(decryptedMessage);
        }

        static string DecryptMessage(string encryptedMessage)
        {
            List<int> numbersList = new List<int>();
            List<char> nonNumbersList = new List<char>();
            foreach (char ch in encryptedMessage)
            {
                if (char.IsDigit(ch))
                {
                    numbersList.Add(int.Parse(ch.ToString()));
                }
                else
                {
                    nonNumbersList.Add(ch);
                }
            }
            List<int> takeList = new List<int>();
            List<int> skipList = new List<int>();

            for (int i = 0; i < numbersList.Count; i++)
            {
                if (i % 2 == 0)
                {
                    takeList.Add(numbersList[i]);
                }
                else
                {
                    skipList.Add(numbersList[i]);
                }
            }

            
            string result = string.Empty;
            int skipCount = 0;

            for (int i = 0; i < takeList.Count; i++)
            {
                int takeCount = takeList[i];
                int currentSkipCount = skipList[i];

                result += new string(nonNumbersList.Skip(skipCount).Take(takeCount).ToArray());
                skipCount += currentSkipCount + takeCount;
            }

            return result;
        }
    }
}