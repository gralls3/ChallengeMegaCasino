using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeMegaCasino
{
    public class Game
    {
        Player player1;
        Player player2;
        Deck newUnshuffledDeck;
        String gameResult;

    //CONSTRUCTOR METHOD
        public Game()
        {
            player1 = new Player();
            player2 = new Player();
            newUnshuffledDeck = new Deck();
            gameResult = "Begin game<br/><br/>";
        }

    //PLAY GAME METHOD
        public string Play (string player1Name, string player2Name)
        {
            player1.name = player1Name;
            player2.name = player2Name;
        
            newUnshuffledDeck.CreateDeck();
        
            newUnshuffledDeck.Deal(newUnshuffledDeck, player1, player2);
        
            while (player1.handsWon < 5 && player2.handsWon < 5)
            {
                player1.FlipCard(player1);
                player1.battleCard = player1.warCardsList.Last();
                gameResult += String.Format("{0} flips {1}<br/>", player1.name, player1.battleCard.name);
            
                player2.FlipCard(player2);
                player2.battleCard = player2.warCardsList.Last();
                gameResult += String.Format("{0} flips {1}<br/>", player2.name, player2.battleCard.name);

            
                if (player1.battleCard.rank > player2.battleCard.rank)
                {
                    Player1WinsHand(player1, player2);
                }
                else if (player2.battleCard.rank > player1.battleCard.rank)
                {
                    Player2WinsHand(player1, player2);
                }
                else
                {
                    War(player1, player2);
                }
            }
            EndGame(player1, player2);
            return gameResult;
        }

    //PLAYER1 WINS METHOD
        private void Player1WinsHand(Player player1, Player player2)
        {
            player1.cardsInHandList.AddRange(player2.warCardsList);
            player1.cardsInHandList.AddRange(player1.warCardsList);
            player1.handsWon++;
            gameResult += String.Format("{0} beats {1},<br/>{2} wins the hand!<br/>{2} {3} games, {4} {5} games<br/><br/>",
                player1.battleCard.name, player2.battleCard.name, player1.name, player1.handsWon, player2.name, player2.handsWon);
        }
    
    //PLAYER2 WINS METHOD
        private void Player2WinsHand(Player player1, Player player2)
        {
            player2.cardsInHandList.AddRange(player2.warCardsList);
            player2.cardsInHandList.AddRange(player1.warCardsList);
            player2.handsWon++;
            gameResult += String.Format("{0} beats {1},<br/>{2} wins the hand!<br/>{2} {3} games, {4} {5} games<br/><br/>",
                player2.battleCard.name, player1.battleCard.name, player2.name, player2.handsWon, player1.name, player1.handsWon);
        }
    
    //WAR METHOD
        private void War(Player player1 ,Player player2)
        {
            gameResult += String.Format("War!<br/>");
            while (player1.warCardsList.Last().rank == player2.warCardsList.Last().rank)
            {
                player1.ThreeCardsDown(player1);

                player2.ThreeCardsDown(player2);
            }
        }

        private string EndGame(Player player1, Player player2)
        {
            if (player1.handsWon > player2.handsWon)
            {
                gameResult += String.Format("{0} wins {1} hands to {2}", player1.name, player1.handsWon, player2.handsWon);
            }
            else
            {
                gameResult += String.Format("{0} wins {1} hands to {2}", player2.name, player2.handsWon, player1.handsWon);
            }
            return gameResult;
        }
    }
}