using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeMegaCasino
{
    public class Card
    {
        public string name;
        public int rank;
        public string suit;

        public Card()
        {
            name = "unassigned";
            rank = 0;
            suit = "unassigned";
        }
    }
}