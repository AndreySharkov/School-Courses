using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_DeckOfCards
{
    public class DeckOfCards
    {
        public List<Card> CardCollection = new List<Card>();
        public void Add(Card card)
        {
            CardCollection.Add(card);
        }

        public void Print()
        {
            if (CardCollection.Count > 0)
            {
                Console.WriteLine(CardCollection[CardCollection.Count - 1]);
            }
            else
            {
                Console.WriteLine("No cards in the deck.");
            }
        }

        public void GetAllCards()
        {
            if (CardCollection.Count > 0)
            {
                foreach (var card in CardCollection)
                {
                    Console.WriteLine(card);
                }
            }
            else
            {
                Console.WriteLine("No cards in the deck.");
            }
        }

        public void Shuffle()
        {
            Random r = new Random();
            for (int i = 0; i < CardCollection.Count; i++)
            {
                int rIdx = r.Next(0, CardCollection.Count);
                Card oldCard = CardCollection[i];
                CardCollection[i] = CardCollection[rIdx];
                CardCollection[rIdx] = oldCard;
            }

            foreach (var card in CardCollection)
            {
                Console.WriteLine(card);
            }
        }

        public void Clear()
        {
            CardCollection.Clear();
        }
    }

}
