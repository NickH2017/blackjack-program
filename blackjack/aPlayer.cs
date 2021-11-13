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
        private double bank;
        private bool aceFlag;

        // Player/Dealer Constructor
        public aPlayer()
        {
            hand = new List<aCard>(10);
            aceFlag = false;
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

        public void setBank(double pot)
        {
            this.bank = pot;
        }
        public double GetBank()
        {
            return bank;
        }
        //Player bank is set once won
        public void won(double bet)
        {
            bank += (1.5 * bet);
        }
        // Settle the bet for game start
        public void settleBet(double bet)
        {
            bank -= bet; 
        }
        /// <summary>
        /// Get/Set Aceflag returns a bool to check if player has an ace
        /// </summary>
        public bool AceFlag
        {
            get { return aceFlag; }
            set { aceFlag = true; }
        }
        /// <summary>
        /// Reset player profile including hand.
        /// </summary>
        public void reset()
        {
            aceFlag = false;
            hand.Clear();
        }
    }
}
