using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeMegaCasino
{
    public class Player
    {
        public string name;
        public List<Card> cardsInHandList;
        public List<Card> warCardsList;
        public Card battleCard;
        public int handsWon;
        public Random randomCard;

    //CONSTRUCTOR METHOD
        public Player()
        {
            name = "unassigned";
            cardsInHandList = new List<Card>();
            warCardsList = new List<Card>();
            battleCard = new Card();
            handsWon = 0;
            randomCard = new Random();
        }

    //FLIP CARD METHOD
        public Player FlipCard(Player player)
        {
            int index = randomCard.Next(0, player.cardsInHandList.Count);
            warCardsList.Add(player.cardsInHandList.ElementAt(index));
            player.cardsInHandList.RemoveAt(index);
            return player;
        }
        
    //WAR THREE CARDS DOWN METHOD
        public Player ThreeCardsDown(Player player)
        {
            for (int warFlips = 1; warFlips < 4; warFlips++)
            {
                int index = randomCard.Next(0, player.cardsInHandList.Count);
                player.warCardsList.Add(cardsInHandList.ElementAt(index));
                player.cardsInHandList.RemoveAt(index);
            }
            return player;
        }
    }

    
}