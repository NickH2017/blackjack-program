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
        private int value;
        private System.Drawing.Image card;

        // Default Constructor
        public aCard()
        {
            suit = "";
            brand = "";
            card = Properties.Resources.red_back; // Default Image
        }
        public void SetBrand(string brand)
        {
            this.brand = brand;
        }
        public string GetBrand()
        {
            return brand;
        }
        public void SetSuit(string suit)
        {
            this.suit = suit;
        }
        public void SetValue()
        {
            switch (brand)
            {
                case "J":
                case "Q":
                case "K":
                    value = 10;
                    break;
                case "A":
                    value = 11;
                    break;
                default:
                    value = int.Parse(brand);
                    break;
            }
        }
        public int GetValue()
        {
            return value;
        }
        public void SetImage(string path)
        {
            card = System.Drawing.Image.FromFile(path);
        }
        public System.Drawing.Image GetImage()
        {
            return card;
        }
    }
}
