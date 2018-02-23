using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeMegaCasino
{
    public class Deck
    {
        public List<Card> cardList;

        public Deck()
        {//CONSTRUCTOR METHOD
            this.cardList = new List<Card>();
        }

        public List<Card> CreateDeck()
        {
            List<string> suitsList = new List<string>()
            {
                "Hearts", "Spades", "Diamonds", "Clubs"
            };

            foreach (var suit in suitsList)
            {
                
                for (int rank = 2; rank < 15; rank++)
                {
                    Card suitedCard = new Card();
                    suitedCard.suit = suit;
                    suitedCard.rank = rank;
                    suitedCard.name = rank.ToString() + " of " + suit;
                    cardList.Add(NameFaceCards(suitedCard));
                }
            }
            return cardList;
        }

        public Card NameFaceCards (Card namedCard)
        {
            namedCard.name = (namedCard.rank == 11) ? "Jack of " + namedCard.rank : namedCard.name;
            namedCard.name = (namedCard.rank == 12) ? "Queen of " + namedCard.rank : namedCard.name;
            namedCard.name = (namedCard.rank == 13) ? "King of" + namedCard.rank : namedCard.name;
            namedCard.name = (namedCard.rank == 14) ? "Ace of" + namedCard.rank : namedCard.name;
            return namedCard;
        }
        
        public Random randomCard;
        /*
        public Card Deal(Deck deck)
        {
            while (deck.cardList.Count == 0)
            {
                
            }
        }*/
    }
}