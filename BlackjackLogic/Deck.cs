using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackLogic
{
    public class Deck
    {
        public List<Card> Cards;
        public List<Suit> Suits = new List<Suit> { new Suit { Name = "Hearts", ID = 1 }, new Suit { Name = "Diamonds", ID = 2 }, new Suit { Name = "Clubs", ID = 3 }, new Suit { Name = "Spades", ID = 4 } };
        public List<int> Values = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

        public Deck()
        {

        }

        public Deck(int decks)
        {
            Cards = new List<Card>();

            for (int i = 0; i < decks; i++)
            {
                foreach (Suit s in Suits)
                {
                    foreach (int v in Values)
                    {
                        Cards.Add(new Card(s, v));
                    }
                }
            }

            Shuffle();
        }

        public void Shuffle()
        {
            Random r = new Random();
            for (int i = 0; i < Cards.Count; i++)
            {
                int index1 = i;
                int index2 = r.Next(Cards.Count);
                SwapCard(index1, index2);
            }
        }

        private void SwapCard(int index1, int index2)
        {
            Card card = Cards[index1];
            Cards[index1] = Cards[index2];
            Cards[index2] = card;
        }

        public Card Draw()
        {
            Card card = Cards[0];
            Cards.RemoveAt(0);
            return card;
        }
    }
}
