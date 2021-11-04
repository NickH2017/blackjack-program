using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


/// <summary>
/// List of cards, remove card out once
/// Counter--;
/// </summary>

namespace blackjack
{
    class aDeckofCards
    {
        private List<aCard> deck;
        private List<string> suits = new List<string> { "Hearts", "Clubs", "Diamonds", "Spades" };
        private List<string> brands = new List<string> { "A", "K", "Q", "J", "10", "9", "8", "7", "6", "5", "4", "3", "2" };
        
        // Default Constructor
        public aDeckofCards()
        {
            for (int i = 0; i < suits.Count; i++)
            {
                for(int j = 0; j < brands.Count; j++)
                {
                    aCard newCard = new aCard();

                    newCard.setSuit(suits[i]);
                    newCard.setBrand(brands[i]);
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
