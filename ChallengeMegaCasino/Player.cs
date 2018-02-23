using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeMegaCasino
{
    public class Player
    {
        public string name;
        public Card currentCard;
        public List<Card> cardsInHand;

        public Player()
        {
            name = "unassigned";
            currentCard = new Card();
            cardsInHand = new List<Card>();
        }

        public int FlipCard { get; set; }
    }

    
}