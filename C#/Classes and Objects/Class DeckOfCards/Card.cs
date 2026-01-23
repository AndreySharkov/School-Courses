using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_DeckOfCards
{
    public class Card
    {
        public string Face { get; set; }
        public string Suit { get; set; }

        public Card(string face, string suit)
        {
            Face = face;
            Suit = suit;
        }

        public override string ToString()
        {
            return $"{Face} {Suit}";
        }
    }
}
