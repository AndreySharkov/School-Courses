namespace CardsGame
{
    internal class Program
    {
        static void Main()
        {
            List<int> firstPlayerDeck = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> secondPlayerDeck = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (firstPlayerDeck.Count > 0 && secondPlayerDeck.Count > 0)
            {
                PlayRound(firstPlayerDeck, secondPlayerDeck);
            }

            if (firstPlayerDeck.Count > 0)
            {
                PrintResult("First", firstPlayerDeck);
            }
            else
            {
                PrintResult("Second", secondPlayerDeck);
            }
        }
        static void PlayRound(List<int> firstPlayerDeck, List<int> secondPlayerDeck)
        {
            int firstPlayerCard = firstPlayerDeck[0];
            int secondPlayerCard = secondPlayerDeck[0];

            if (firstPlayerCard > secondPlayerCard)
            {

                firstPlayerDeck.RemoveAt(0);
                secondPlayerDeck.RemoveAt(0);
                firstPlayerDeck.Add(firstPlayerCard);
                firstPlayerDeck.Add(secondPlayerCard);
            }
            else if (secondPlayerCard > firstPlayerCard)
            {

                firstPlayerDeck.RemoveAt(0);
                secondPlayerDeck.RemoveAt(0);
                secondPlayerDeck.Add(secondPlayerCard);
                secondPlayerDeck.Add(firstPlayerCard);
            }
            else
            {

                firstPlayerDeck.RemoveAt(0);
                secondPlayerDeck.RemoveAt(0);
            }
        }

        static void PrintResult(string winner, List<int> remainingCards)
        {
            int sum = remainingCards.Sum();
            Console.WriteLine($"{winner} player wins! Sum: {sum}");
        }
    }
}