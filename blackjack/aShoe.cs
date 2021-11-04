using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace blackjack
{
    class aShoe : IDrawCard
    {
        private int seed;
        private int numDecks;
        // Default Constructor
        public aShoe(int seed, int numDecks)
        {
            this.seed = seed;
            this.numDecks = numDecks;
        }
        // Interface IDrawCard Draw card.
        public aCard Draw()
        {
            throw new NotImplementedException();
        }
    }
}
