using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class aGame
    {
        private aShoe shoe;
        private aPlayer player;
        private aPlayer dealer;
        private int seed;
        private int numDecks;
        private int bet;

        public aGame(int seed, int numDecks)
        {
            shoe = new aShoe(seed, numDecks);
            player = new aPlayer();
            dealer = new aPlayer();
        }
        // draws a card from the shoe to each player and the dealer.
        public List<int> dealCards()
        {
            aCard newCard;
            List<aCard> pHand, dHand;
            List<int> nums = new List<int>(4);
            int num;

            // Player cards
            for (int i = 0; i < 2; ++i)
            {
                /*
                newCard = shoe.Draw();
                pHand = player.getHand();
                pHand.Add(newCard);
                player.setHand(pHand);
                */
                newCard = shoe.Draw();
                num = newCard.GetValue();
                nums.Add(num);
                pHand = player.getHand();
                pHand.Add(newCard);
                player.setHand(pHand);
            }

            // Dealer Cards
            for (int i = 0; i < 2; ++i)
            {
                /*
                newCard = shoe.Draw();
                dHand = dealer.getHand();
                dHand.Add(newCard);
                dealer.setHand(dHand);
                */
                newCard = shoe.Draw();
                num = newCard.GetValue();
                nums.Add(num);
                dHand = dealer.getHand();
                dHand.Add(newCard);
                dealer.setHand(dHand);
            }

            return nums;
        }
        // Function that draws 1 new card to player card.
        public int hitCard()
        {
            aCard newCard;
            List<aCard> pHand;
            newCard = shoe.Draw();
            int num = newCard.GetValue();
            pHand = player.getHand();
            pHand.Add(newCard);
            player.setHand(pHand);

            return num;
        }
        // Checks for ruleset between player and dealer.
        public string checkBlackJack()
        {
            List<aCard> pHand = player.getHand();
            List<aCard> dHand = dealer.getHand();
            int pValue = 0;
            int dValue = 0;
            bool dealerStand = false;
            string status;

            for(int i = 0; i < pHand.Count(); i++)
            {
                pValue += pHand[i].GetValue();
            }

            for(int i = 0; i < dHand.Count(); i++)
            {
                dValue += dHand[i].GetValue();
            }

            if (pValue == 21)
            {
                player.won(bet);
                return "won";
            }
            else if (pValue > 21)
            {
                return "BUST";
            }
            else
            {
                return "number";
            }
            /*
            if(dValue >= 17 && dValue < 21)
            {
                dealerStand = true;
            }
            else
            {
                dealerStand = false;
            }
            */
            return status;
        }
        // Gets the bet for every player and pot.
        public void getBet(string sBet, int pot)
        {
            player.setBank(pot); // Sets the current bank pot for player.
            bet = int.Parse(sBet);
            player.settleBet(bet);
        }
        public aPlayer GetPlayer()
        {
            return player;
        }
        public aPlayer GetDealer()
        {
            return dealer;
        }
        public void EndGame()
        {

        }
        public Boolean playAgain()
        {
            return false;
        }

        public void reset()
        {
            player.reset();
            dealer.reset();
        }
    }
}
