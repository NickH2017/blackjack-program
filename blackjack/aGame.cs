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
        private int seed, numDecks;
        private double bet;
        private bool isEndGame;
        
        /// <summary>
        /// Default Constructor for the BlackJack Game. Takes care of most of the functionality of a blackjack game.
        /// Creates a player, a dealer, and a shoe randomvariable generator for numbers.
        /// Keeps track of bets taken from each player box.
        /// </summary>
        /// <param name="seed">
        /// Takes in a seed from the starting form. Can be later changed.
        /// </param>
        /// <param name="numDecks">
        /// Passed down from the starting form to blackjack game form to here to create a new show with seed and number of decks
        /// Can also be changed later on.
        /// </param>
        public aGame(int seed, int numDecks)
        {
            shoe = new aShoe(seed, numDecks);
            player = new aPlayer();
            dealer = new aPlayer();
            isEndGame = false;
        }
        // Draws 2 cards from the shoe to each player and 1 card to the dealer.
        public List<int> dealCards()
        {
            aCard newCard;
            List<aCard> pHand, dHand;
            List<int> nums = new List<int>(4);
            int num;

            // 2 Player cards drawn 
            for (int i = 0; i < 2; ++i)
            {
                newCard = shoe.Draw();
                num = newCard.GetValue();
                nums.Add(num);
                pHand = player.getHand();
                pHand.Add(newCard);
                player.setHand(pHand);
            }

            // 1 card is drawn to the dealer hand.
            newCard = shoe.Draw();
            num = newCard.GetValue();
            nums.Add(num);
            dHand = dealer.getHand();
            dHand.Add(newCard);
            dealer.setHand(dHand);

            return nums;
        }
        // Function that draws 1 new card to player card.
        // FOR FUTURE PLAYER BOXES, PASS PLAYER NAME.
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
            int ind = 0;


            for (int i = 0; i < pHand.Count(); i++)
            {
                pValue += pHand[i].GetValue();
                /*
                if(pHand[i].GetValue() == 11)
                {
                    player.AceFlag = true;
                    ind = i;
                }
                */
            }

            for(int i = 0; i < dHand.Count(); i++)
            {
                dValue += dHand[i].GetValue();
                /*
                if (pHand[i].GetValue() == 11)
                {
                    dealer.AceFlag = true;
                    ind = i;
                }
                */
            }

            if(isEndGame)
            {
                // If dealer has 21
                if (dValue == 21)
                {
                    // If player has 21
                    if (pValue == 21)
                    {
                        return "TIE";
                    }
                    else
                    {
                        return "BUST";
                    }
                }
                // Dealer Bust
                else if(dValue > 21)
                {
                    if(dealer.AceFlag)
                    {
                        dHand.ElementAt(ind).SetValue(1);
                        dealer.setHand(pHand);
                        return "ACE";
                    }
                    else
                    {
                        player.won(bet);
                        return "DBUST";
                    }
                    
                }
                else
                {
                    // player hand > dealer hand
                    if (dValue < pValue)
                    {
                        player.won(bet);
                        return "WON";
                    }
                    // Player Bust
                    else if (pValue > 21)
                    {
                        return "BUST";
                    }
                    //Player loses playerhand < dealerhand
                    else if (dValue > pValue)
                    {
                        return "LOST";
                    }
                }              
            }
            else
            {
                // ADD ACE VALUE list.contains(A or 11)
                // Player Bust
                if(pValue > 21)
                {
                    if(player.AceFlag)
                    {
                        pHand.ElementAt(ind).SetValue(1);
                        player.setHand(pHand);
                        return "ACE";
                    }
                    else
                    {
                        return "BUST";
                    }
                }

            }

            return "NUMBER";
        }
        /// <summary>
        ///  Dealer turn to play, draws cards until reaches soft 17 or hard 17.
        ///  All cards set to dealer hand
        /// </summary>
        /// <param name="isSoft">
        /// Checks to see if the game was started as a soft game. Passes true or false
        /// </param>
        public void dealerPlays(bool isSoft)
        {
            List<aCard> dHand = dealer.getHand();
            aCard newCard;
            int dValue = 0;
            int num;

            for (int i = 0; i < dHand.Count(); i++)
            {
                dValue += dHand[i].GetValue();
            }

            while (true) 
            {
                if (dValue >= 17 && dValue <= 21 && isSoft)
                {
                    break;
                }
                else if(dValue > 17 && dValue <= 21 && !isSoft)
                {
                    break;
                }
                else if(dValue > 21)
                {
                    break;
                }

                newCard = shoe.Draw();
                num = newCard.GetValue();
                dHand = dealer.getHand();
                dHand.Add(newCard);
                dealer.setHand(dHand);
                dValue += num;
            }
        }
        /// <summary>
        /// Gets the bet for every player and pot.
        /// Removes bet from pot and updates it.
        /// </summary>
        /// <param name="sBet">string bet taken from txtBet textbox </param>
        /// <param name="pot">double bot taken from txtPot textbox</param>
        public void getBet(string sBet, double pot)
        {
            player.setBank(pot); // Sets the current bank pot for player.
            bet = double.Parse(sBet); // Tracks bet through game
            player.settleBet(bet); // Remove bet from pot
        }
        // Function that returns the game player information and its components such as hand
        // FUTURE DEV NOTE: NAME PARAM FOR SPECIFIC PLAYER
        public aPlayer GetPlayer()
        {
            return player;
        }
        // Function that returns the dealer information and its components such as hand.
        public aPlayer GetDealer()
        {
            return dealer;
        }
        // Function ends the game and returns true
        public bool EndGame()
        {
            isEndGame = true;
            return isEndGame;
        }
        // Function reseeds the shoe when called in main form (Change seed button)
        public void reseed(int seed)
        {
            this.seed = seed;
            shoe.setSeed(seed);
        }
        // Function resets dealer and player values internally.
        public void reset()
        {
            player.reset();
            dealer.reset();
            isEndGame = false;
        }
    }
}
