namespace Class_DeckOfCards
{
    internal class Program
    {
        static void Main()
        {
            DeckOfCards deck = new DeckOfCards();
            string command;
            while ((command = Console.ReadLine()) != "End")
            {
                string[] parts = command.Split();
                string action = parts[0];

                switch (action)
                {
                    case "Add":
                        string face = parts[1];
                        string suit = parts[2];
                        deck.Add(new Card(face, suit));
                        break;

                    case "Print":
                        deck.Print();
                        break;

                    case "GetAllCards":
                        deck.GetAllCards();
                        break;

                    case "Randomize":
                        deck.Shuffle();
                        break;

                    case "Clear":
                        deck.Clear();
                        break;
                }
            }
        }
    }
}
