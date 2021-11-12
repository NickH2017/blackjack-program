using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


/// <summary>
/// List of cards, remove card out once
/// Counter--;
/// </summary>

namespace blackjack
{
    class aDeckofCards
    {
        private List<aCard> deck = new List<aCard>(52);
        private List<string> suits = new List<string> { "H", "C", "D", "S" };
        private List<string> brands = new List<string> { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
        
        // Default Constructor
        public aDeckofCards()
        {
            string name;
            var projectPath = Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName;
            for (int i = 0; i < suits.Count; i++)
            {
                for(int j = 0; j < brands.Count; j++)
                {
                    aCard newCard = new aCard();
                    name = (brands[j] + suits[i]);
                    // Clean up later
                    newCard.SetSuit(suits[i]);
                    newCard.SetBrand(brands[j]);
                    string filePath = Path.Combine(projectPath, "Resources/" + name + ".png");
                    newCard.SetImage(filePath);
                    newCard.SetValue();
                    this.deck.Add(newCard);
                }    
            }
        }
        public List<aCard> getCards()
        {
            return deck;
        }
    }
}
