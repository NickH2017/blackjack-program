using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace blackjack
{
    /// <summary>
    /// BlackJack Game Form can be opened multiple times from the starting form.
    /// </summary>
    public partial class BlackJack : Form
    {
        private int seed;
        private int decks;
        private bool isSoftGame;
        List<PictureBox> pics = new List<PictureBox>();
        List<aCard> playerHand, dealerHand;
        int playerValue, dealerValue = 0;
        bool isEndGame;
        
        aGame play;
        /// <summary>
        /// Default Constructor for each "Table" game of Blackjack
        /// </summary>
        /// <param name="seed"> Seed from Starting Form</param>
        /// <param name="decks">Number of decks for Shoe</param>
        /// <param name="isSoftGame">Checked if it is a Soft 17 game</param>
        public BlackJack(int seed, int decks, bool isSoftGame)
        {
            InitializeComponent();
            this.seed = seed;
            this.decks = decks;
            this.isSoftGame = isSoftGame;
            play = new aGame(seed, decks);

        }
        // Buttons and Textboxes enabled/disabled as form loads
        private void BlackJack_Load(object sender, EventArgs e)
        {
            btnHit.Visible = false;
            btnStand.Visible = false;
            txtDealerValue.Enabled = false;
            txtPlayerValue.Enabled = false;
            picCaby.Visible = false;
            txtSeed.Text = seed.ToString();
            txtSeed.Enabled = false;
            btnChangeSeed.Visible = false;
        }
        // Function for reset button event handler, Clears all and resets game and allows for seed to be changed.
        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPot.Text = "100"; // Default Money reset
            txtPot.Enabled = true;
            txtBet.Enabled = true;
            btnChangeSeed.Visible = true;
            txtSeed.Enabled = true;
            playerValue = 0;
            dealerValue = 0;
            isEndGame = false;
            btnPlay.Enabled = true;
            btnPlay.Visible = true;
            btnHit.Visible = false;
            btnStand.Visible = false;
            btnPlayAgain.Visible = false;
            playerHand.Clear();
            dealerHand.Clear();
            play.reset();
            foreach (Control child in this.Controls)
            {
                if (child is PictureBox)
                {
                    ((PictureBox)child).Dispose();
                    continue;
                }
            }
            foreach (Control child in this.Controls)
            {
                if (child is PictureBox)
                {
                    ((PictureBox)child).Dispose();
                }
            }
            foreach (Control child in this.Controls)
            {
                if (child is PictureBox)
                {
                    ((PictureBox)child).Dispose();
                }
            }

        }
        /// <summary>
        /// Function for stand button event handler, allows dealer to start playing along with calling the game to end.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStand_Click(object sender, EventArgs e)
        {

            play.dealerPlays(isSoftGame);

            dealerHand = play.GetDealer().getHand();

            //Dealer hand already contains 2 cards, index starts at 2 for 3rd card.
            for(int i = 1; i < dealerHand.Count(); i++)
            {
                PictureBox p = new PictureBox();
                p.Location = new Point(275 + (i * 25), 65);
                p.BackColor = System.Drawing.Color.Transparent;
                p.Name = "dealerHand" + i;
                p.Size = new Size(83, 126);
                p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                p.Image = Image.FromFile(dealerHand[i].GetImageLoc());
                this.Controls.Add(p);

                dealerValue += dealerHand[i].GetValue();
            }


            txtDealerValue.Text = dealerValue.ToString();

            play.EndGame();

            string status = play.checkBlackJack();

            switch (status)
            {
                case "WON":
                    txtPlayerValue.Text = "WIN";
                    break;
                case "BUST":
                    txtPlayerValue.Text = "BUST";
                    picCaby.Visible = true;
                    break;
                case "DBUST":
                    txtDealerValue.Text = "BUST";
                    txtPlayerValue.Text = "WON";
                    break;
                case "TIE":
                    txtPlayerValue.Text = "TIE";
                    break;
                case "LOST":
                    txtPlayerValue.Text = "LOST";
                    txtDealerValue.Text = "WON";
                    break;
                default:
                    break;
            }

            txtPot.Text = play.GetPlayer().GetBank().ToString();

            btnHit.Visible = false;
            btnStand.Visible = false;
            btnPlayAgain.Visible = true;
            txtBet.Enabled = true;

            //dealer draws card until hand value > 17
        }
        //Function for playing again button event handler, instead of reseting entire game, it keeps progress of player bank and bets.
        private void btnPlayAgain_Click(object sender, EventArgs e)
        {
            isEndGame = false;
            playerValue = 0;
            dealerValue = 0;
            playerHand.Clear();
            dealerHand.Clear();
            btnHit.Visible = true;
            btnStand.Visible = true;
            play.reset();
            foreach (Control child in this.Controls)
            {
                if (child is PictureBox)
                {
                    //((PictureBox)child).Dispose();
                    ((PictureBox)child).Dispose();
                    continue;
                }
            }
            foreach (Control child in this.Controls)
            {
                if (child is PictureBox)
                {
                    //((PictureBox)child).Dispose();
                    ((PictureBox)child).Dispose();
                }
            }
            foreach (Control child in this.Controls)
            {
                if (child is PictureBox)
                {
                    //((PictureBox)child).Dispose();
                    ((PictureBox)child).Dispose();
                }
            }
            btnPlay_Click(sender, e);
        }
        // Function to change the seed, click event handler.
        private void btnChangeSeed_Click(object sender, EventArgs e)
        {
            seed = int.Parse(txtSeed.Text);
            play.reseed(seed);
            txtSeed.Enabled = false;
            btnChangeSeed.Visible = false;
        }
        // Function to start the game for the first time or when reseting and/or changing the seed.
        private void btnPlay_Click(object sender, EventArgs e)
        {
            List<int> values;
            double pot = double.Parse(txtPot.Text);
            btnPlayAgain.Visible = false;
            txtPot.Enabled = false;
            btnHit.Visible = true;
            btnStand.Visible = true;

            // Rules of the Game start here!;
            play.getBet(txtBet.Text, pot);
            txtBet.Enabled = false;
            
            values = play.dealCards(); // deals two cards to the player and one card to dealer
            playerValue = values[0] + values[1];
            dealerValue = values[2];

            txtPlayerValue.Text = (playerValue).ToString();
            txtDealerValue.Text = (dealerValue).ToString();

            playerHand = play.GetPlayer().getHand();
            dealerHand = play.GetDealer().getHand();

            // Create picture boxes for player hand
            for(int i = 0; i < 2; ++i)
            {  
                PictureBox p = new PictureBox();
                p.Location = new Point(275 + (i * 25), 217);
                p.BackColor = System.Drawing.Color.Transparent;
                p.Name = "playerHand" + i;
                p.Size = new Size(83, 126);
                p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                p.Image = Image.FromFile(playerHand[i].GetImageLoc());
                this.Controls.Add(p);
            }
            // Create picture box for dealer hand
            for (int i = 0; i < 1; ++i)
            {
                PictureBox p = new PictureBox();
                p.Location = new Point(275 + (i * 25), 65);
                p.BackColor = System.Drawing.Color.Transparent;
                p.Name = "dealerHand" + i;
                p.Size = new Size(83, 126);
                p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                p.Image = Image.FromFile(dealerHand[i].GetImageLoc());
                this.Controls.Add(p);
            }

            string status = play.checkBlackJack();

            switch (status)
            {
                case "WON":
                case "BUST":
                case "TIE":
                    txtPlayerValue.Text = status; 
                    isEndGame = play.EndGame();
                    break;
                default:
                    break;
            }

            if(isEndGame)
            {
                picCaby.Visible = true;
                btnPlayAgain.Visible = true;
                btnHit.Visible = false;
                btnStand.Visible = false;
                txtBet.Enabled = true;
            }

            txtPot.Text = play.GetPlayer().GetBank().ToString();
            btnPlay.Enabled = false;
            btnPlay.Visible = false;
        }
        // Function for button Hit click event handler. Will give player a new card for each click.
        private void btnHit_Click(object sender, EventArgs e)
        {
            int num = play.hitCard();
            playerHand = play.GetPlayer().getHand();

            PictureBox p = new PictureBox();
            p.Location = new Point(275 + ((playerHand.Count()-1) * 25), 217);
            p.BackColor = System.Drawing.Color.Transparent;
            p.Name = "playerHand" + playerHand.Count();
            p.Size = new Size(83, 126);
            p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            p.Image = Image.FromFile(playerHand[playerHand.Count()-1].GetImageLoc());

            this.Controls.Add(p);

            if(playerValue > 21 && num == 11)
            {
                num = 1;
            }

            // Checks for blackjack
            string status = play.checkBlackJack();

            //PLayer value updated.
            txtPlayerValue.Text = (playerValue + num).ToString();

            switch (status)
            {
                case "WON":
                case "BUST":
                case "TIE":
                    txtPlayerValue.Text = status;
                    isEndGame = play.EndGame();
                    break;
                default:
                    break;
            }
            //Checks if game has ended to start a new game.
            if (isEndGame)
            {
                picCaby.Visible = true;
                btnPlayAgain.Visible = true;
                btnHit.Visible = false;
                btnStand.Visible = false;
                txtBet.Enabled = true;
            }
            txtPot.Text = play.GetPlayer().GetBank().ToString();

        }
    }
}
