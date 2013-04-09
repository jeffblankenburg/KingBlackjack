using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackLogic
{
    public class BlackjackGame
    {
        public Deck Deck;
        public Hand DealerHand;
        public Hand PlayerHand;

        public BlackjackGame()
        {
            BuildGame(1);
        }
        
        public BlackjackGame(int decks)
        {
            BuildGame(decks);
        }

        private void BuildGame(int decks)
        {
            Deck = new Deck(decks);
        }

        public void Deal()
        {
            PlayerHand.Cards.Add(Deck.Draw());
            DealerHand.Cards.Add(Deck.Draw());
            PlayerHand.Cards.Add(Deck.Draw());
            DealerHand.Cards.Add(Deck.Draw());
        }
    }
}
