using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class aCard
    {
        private string suit;
        private string brand;
        //private int value;

        // Default Constructor
        public aCard()
        {
            this.suit = "";
            this.brand = "";
        }
        public void setBrand(string brand)
        {
            this.brand = brand;
        }
        public void setSuit(string suit)
        {
            this.suit = suit;
        }

    }
}
