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
    public partial class StartForm : Form
    {
        public StartForm()
        {
            InitializeComponent();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            try
            {
                int seed = int.Parse(txtSeed.Text);
                int decks = int.Parse(cboDecks.Text);
                bool isSoftGame = checkSoft.Checked; 
                BlackJack newGame = new BlackJack(seed, decks, isSoftGame);
                newGame.Show();
            }
            catch(Exception err)
            {
                MessageBox.Show(err.Message);
            }
            
        }
    }
}
