using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BlackjackLogic
{
    public class Hand
    {
        public List<Card> Cards;
        public int Total;
        public string DisplayTotal;

        public void Check()
        {
            int total = 0;
            foreach (Card c in Cards)
            {
                switch (c.Value)
                {
                    case 1:

                        break;
                    case 2: case 3: case 4: case 5: case 6: case 7: case 8: case 9:
                        total += c.Value;
                        break;
                    case 10: case 11: case 12: case 13:
                        total += 10;
                        break;
                }
            }
            Total = total;
        }
    }
}
