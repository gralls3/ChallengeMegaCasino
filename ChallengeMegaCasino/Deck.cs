using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeMegaCasino
{
    public class Deck
    {
        public List<Card> cardsList;
        public Random randomCard;

    //CONSTRUCTOR METHOD
        public Deck()
        {
            this.cardsList = new List<Card>();
            randomCard = new Random();
        }

    //CREATE DECK METHOD
        public List<Card> CreateDeck()
        {
            List<string> suitsList = new List<string>()
            {
                "Hearts", "Spades", "Diamonds", "Clubs"
            };

            foreach (var suit in suitsList)
            {//For each suit, create cards 2-14
                for (int rank = 2; rank < 15; rank++)
                {
                    Card suitedCard = new Card();
                    suitedCard.suit = suit;
                    suitedCard.rank = rank;
                    suitedCard.name = rank.ToString() + " of " + suit;
                    cardsList.Add(NameFaceCards(suitedCard));
                }
            }
            return cardsList;
        }

    //NAME FACE CARDS METHOD
        public Card NameFaceCards (Card namedCard)
        {//If card name=11-14, rename to Jack, etc.
            namedCard.name = (namedCard.rank == 11) ? "Jack of " + namedCard.suit : namedCard.name;
            namedCard.name = (namedCard.rank == 12) ? "Queen of " + namedCard.suit : namedCard.name;
            namedCard.name = (namedCard.rank == 13) ? "King of " + namedCard.suit : namedCard.name;
            namedCard.name = (namedCard.rank == 14) ? "Ace of " + namedCard.suit : namedCard.name;
            return namedCard;
        }
        
    //DEAL ALL CARDS METHOD
        public void Deal(Deck newDeck, Player player1, Player player2)
        {
            while (newDeck.cardsList.Count != 0)
            {
                int index = randomCard.Next(0, cardsList.Count);
                if (player1.cardsInHandList.Count == player2.cardsInHandList.Count)
                {
                    player1.cardsInHandList.Add(newDeck.cardsList.ElementAt(index));
                    newDeck.cardsList.RemoveAt(index);
                }
                else
                {
                    player2.cardsInHandList.Add(newDeck.cardsList.ElementAt(index));
                    newDeck.cardsList.RemoveAt(index);
                }
            }
        }
    }
}