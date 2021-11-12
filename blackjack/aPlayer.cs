using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    /// <summary>
    /// Player class creates a player object for the main user and the dealer.
    /// It keep track of the player hand and dealer's hand.
    /// Two constructors are included for a dealer and any players+ in-game.
    /// </summary>
    class aPlayer
    {
        private List<aCard> hand; //Can have up to 10 cards in hand
        private int bank;
        private bool bust;
        private bool win;
        private bool tie;

        // Player/Dealer Constructor
        public aPlayer()
        {
            hand = new List<aCard>(10);
            bust = false;
            win = false;
            tie = false;
        }
        // Get hand from a player
        public List<aCard> getHand()
        {
            return hand;
        }

        public void setHand(List<aCard> newHand)
        {
            this.hand = newHand;
        }

        public void setBank(int pot)
        {
            this.bank = pot;
        }
        public int GetBank()
        {
            return bank;
        }
        public void won(int bet)
        {
            bank += (3/2) * bet;
            win = true;
        }
        public void settleBet(int bet)
        {
            bank -= bet; 
        }

        public void reset()
        {
            hand.Clear();
        }
    }
}
