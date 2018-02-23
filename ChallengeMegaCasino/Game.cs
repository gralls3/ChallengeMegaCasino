using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeMegaCasino
{
    public class Game
    {
        public Game(string player1Name, string player2Name)
        {
            Player player1 = new Player();
            player1.name = player1Name;

            Player player2 = new Player();
            player2.name = player2Name;

            Deck newUnshuffledCardDeck = new Deck();

            newUnshuffledCardDeck.CreateDeck();

            newUnshuffledCardDeck.Deal(newUnshuffledCardDeck, player1, player2);
        }
    }
}