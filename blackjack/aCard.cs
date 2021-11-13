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
        private string ImageLocation;

        /// <summary>
        /// Default card constructor creates an empty card.
        /// </summary>
        public aCard(string brand, string suit)
        {
            this.suit = suit;
            this.brand = brand;
        }
        //Function that sets the numerical value for the cards
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
        //Function that sets a SPECIFIC numerical value for the cards (ACE)
        public void SetValue(int value)
        {
            value = 1;
        }
        // Function that obtains the numerical value for an aCard
        public int GetValue()
        {
            return value;
        }
        // Sets the image for the card to add dynamically
        public void SetImage(string path)
        {
            ImageLocation = path;
        }
        // Returns the card image as a System.Drawing.Image object
        public string GetImageLoc()
        {
            return ImageLocation;
        }
    }
}
