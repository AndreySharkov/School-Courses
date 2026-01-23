namespace Advertisement_Message
{
    internal class Program
    {
        static void Main()
        {
            int numberOfMessages = int.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < numberOfMessages; i++)
            {
                string phrase = ProductPhrases.Phrases[random.Next(ProductPhrases.Phrases.Length)];
                string eventMessage = ProductPhrases.Events[random.Next(ProductPhrases.Events.Length)];
                string author = ProductPhrases.Authors[random.Next(ProductPhrases.Authors.Length)];
                string city = ProductPhrases.Cities[random.Next(ProductPhrases.Cities.Length)];

                Console.WriteLine($"{phrase} {eventMessage} {author} – {city}");
            }
        }
    }
}
