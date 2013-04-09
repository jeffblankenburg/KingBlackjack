using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackLogic
{
    public class Card
    {
        public Suit Suit { get; set; }
        public int Value { get; set; }

        public Card(Suit suit, int value)
        {
            Suit = suit;
            Value = value;
        }
    }
}
