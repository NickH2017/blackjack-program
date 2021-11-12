using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class aShoe : aRandomVariable, IDrawCard
    {
        private int numDecks;
        private int cardCount;
        private aDeckofCards deck;
        private List<aDeckofCards> fullDeck;
        private aRandomVariable randObj;

        // Default Constructor
        public aShoe(int seed, int numDecks)
        {
            randObj = new aRandomVariable(seed);
            //fullDeck = new List<aDeckofCards>(numDecks);
            //this.numDecks = numDecks;
            /*
            for(int i = 0; i < numDecks; i++)
            {
                deck = new aDeckofCards();
                fullDeck.Add(deck);
            }*/
            deck = new aDeckofCards();
            //this.cardCount = 52;
        }
        // Interface IDrawCard Draw card.
        public aCard Draw()
        {
            List<aCard> cards;
            //deck = new aDeckofCards();

            int number = randObj.getRand();

            cards = deck.getCards();

            return cards.ElementAt(number);
        }
    }
}
