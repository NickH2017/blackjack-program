using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    /// <summary>
    /// aShoe class with IDrawCard Interface and aRandomVariable Inheritance Reference
    /// </summary>
    class aShoe : aRandomVariable, IDrawCard
    {
        private int cardCount;
        private aDeckofCards deck; // Keeps all decks
        private aRandomVariable randObj;
        private List<aCard> fullDeck;
        private List<int> disCarded;

        /// <summary>
        /// Default constructor takes in an Integer Seed and Int Number of Decks from the starting form.
        /// </summary>
        /// <param name="seed"></param>
        /// <param name="numDecks"></param>
        public aShoe(int seed, int numDecks)
        {
            cardCount = numDecks * 52;
            randObj = new aRandomVariable(seed);
            fullDeck = new List<aCard>(cardCount);
            disCarded = new List<int>();
 
            for (int i = 0; i < numDecks; i++)
            {
                deck = new aDeckofCards();
                fullDeck.AddRange(deck.getCards());
            }

        }
        // Interface IDrawCard Draw card.
        public aCard Draw()
        {
            aCard card;
            int randNum;

            if (cardCount == 0)
            {
                disCarded.Clear();
                // "Reshuffles"
                cardCount = fullDeck.Count();
                //disCarded.Add(0);
            }

            do
            {
                randNum = randObj.getRand(fullDeck.Count());
            } while (disCarded.Contains(randNum));
            
            card = fullDeck.ElementAt(randNum);
            disCarded.Add(randNum);
            
            cardCount -= 1;

            return card;
        }

    }
}
