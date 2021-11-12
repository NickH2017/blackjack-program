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
    public partial class BlackJack : Form
    {
        private int seed;
        private int decks;
        List<PictureBox> pics = new List<PictureBox>();
        List<aCard> playerHand, dealerHand;
        int playerValue, dealerValue = 0;
        
        aGame play;

        public BlackJack(int seed, int decks)
        {
            InitializeComponent();
            this.seed = seed;
            this.decks = decks;
            play = new aGame(seed, decks);

        }

        private void BlackJack_Load(object sender, EventArgs e)
        {
            btnHit.Visible = false;
            btnStand.Visible = false;
            txtDealerValue.Enabled = false;
            txtPlayerValue.Enabled = false;
            
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtPot.Text = "100"; // Default Money reset
            playerValue = 0;
            dealerValue = 0;
            btnPlay.Enabled = true;
            btnPlay.Visible = true;
            btnHit.Visible = false;
            btnStand.Visible = false;
            //pics.Clear();
            //Controls.Clear();
            playerHand.Clear();
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

        }

        private void btnStand_Click(object sender, EventArgs e)
        {
            play.checkBlackJack();
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            //aPlayer player, dealer;
            List<int> values;
            int pot = int.Parse(txtPot.Text);
            btnHit.Visible = true;
            btnStand.Visible = true;

            // Rules of the Game start here!;
            play.getBet(txtBet.Text, pot);
            
            values = play.dealCards(); // deals two cards to the player and dealer
            playerValue = values[0] + values[1];
            dealerValue = values[2] + values[3];
            /*
            for(int i = 0; i < 4; i++)
            {
                listBox1.Items.Add(values[i]);
                for (int j = 0; j < 2; j++)
                {
                    //listBox1.Items.Add(play.GetPlayer().getHand()[j].GetBrand());
                    //listBox1.Items.Add(play.GetDealer().getHand()[j].GetBrand());
                }
            }
            */
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
                p.Image = playerHand[i].GetImage();
                this.Controls.Add(p);
                //pics.Add(p);
            }
            
            for (int i = 0; i < 2; ++i)
            {
                PictureBox p = new PictureBox();
                p.Location = new Point(275 + (i * 25), 65);
                p.BackColor = System.Drawing.Color.Transparent;
                p.Name = "dealerHand" + i;
                p.Size = new Size(83, 126);
                p.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
                p.Image = dealerHand[i].GetImage();
                this.Controls.Add(p);
                //pics.Add(p);
            }

            string status = play.checkBlackJack();

            switch (status)
            {
                case "WON":
                    txtBet.Text = play.GetPlayer().GetBank().ToString();
                    txtPlayerValue.Text = "WIN";
                    break;
                case "BUST":
                    txtPlayerValue.Text = "BUST";
                    break;
                case "tie":
                default:
                    break;
            }

            btnPlay.Enabled = false;
            btnPlay.Visible = false;
        }

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
            p.Image = playerHand[playerHand.Count()-1].GetImage();
            this.Controls.Add(p);

            txtPlayerValue.Text = (playerValue + num).ToString();
            
            string status = play.checkBlackJack();

            switch (status)
            {
                case "WON":
                    txtBet.Text = play.GetPlayer().GetBank().ToString();
                    txtPlayerValue.Text = "WIN";
                    break;
                case "BUST":
                    txtPlayerValue.Text = "BUST";
                    break;
                case "TIE":
                default:
                    break;
            }


        }
    }
}
