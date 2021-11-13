using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace blackjack
{
    class aDeckofCards
    {
        private List<aCard> deck = new List<aCard>(52);
        private List<string> suits = new List<string> { "H", "C", "D", "S" };
        private List<string> brands = new List<string> { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };

        /// <summary>
        /// Class a DeckofCards creates a deck of 52 cards with 4 suits and 13 brands, returns a list of aCards
        /// </summary>
        public aDeckofCards()
        {
            string name;
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            string filePath;
            
            for (int i = 0; i < suits.Count; i++)
            {
                for(int j = 0; j < brands.Count; j++)
                {
                    aCard newCard = new aCard(brands[j],suits[i]);
                    name = (brands[j] + suits[i]);
                    filePath = Path.Combine(projectPath, "Resources/" + name + ".png");
                    newCard.SetImage(filePath);
                    newCard.SetValue();
                    this.deck.Add(newCard);
                }    
            }
        }

        /// <summary>
        /// Provides a method to obtain the list of cards in a deck
        /// </summary>
        /// <returns>
        /// Card Full Deck
        /// </returns>
        public List<aCard> getCards()
        {
            return deck;
        }
    }
}
