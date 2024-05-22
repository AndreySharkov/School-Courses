using System.Data;
using System.Text;

namespace Cards
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string[] cardDefinitions = input.Split(", ");
            List<string> outputCards = new List<string>();

            foreach (string cardDefinition in cardDefinitions)
            {
                try
                {
                    string[] parts = cardDefinition.Split();
                    if (parts.Length != 2)
                    {
                        throw new Exception("Invalid card!");
                    }
                    Card card = new Card(parts[0], parts[1]);
                    outputCards.Add(card.ToString());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid card!");
                }
                

            }

            Console.WriteLine(string.Join(" ", outputCards));
        }
    }
    public class Card
    {
        private static string[] ValidFaces = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private static Dictionary<string, string> ValidSuits = new Dictionary<string, string>
        {
            { "S", "\u2660" },
            { "H", "\u2665" },
            { "D", "\u2666" },
            { "C", "\u2663" }
        };

        public string Face { get; }
        public string Suit { get; }

        public Card(string face, string suit)
        {
            if (!ValidFaces.Contains(face) || !ValidSuits.ContainsKey(suit))
            {
                throw new Exception("Invalid card!");
            }

            Face = face;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"[{Face}{ValidSuits[Suit]}]";
        }
    }
}
