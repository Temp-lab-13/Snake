using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class FoodCreator
    {
        private int mapWildth;
        private int mapHeilgth;
        private char symbol;

        Random random = new Random( );

        public FoodCreator(int mapWildth, int mapHeilgth, char symbol)
        {
            this.mapHeilgth = mapHeilgth;
            this.mapWildth = mapWildth;
            this.symbol = symbol;
        }

        public PoinOutput CreaterFood()
        {
            int x = random.Next(2, mapWildth - 2);
            int y = random.Next(2, mapHeilgth - 2);
            return new PoinOutput(x, y, symbol);
        }
    }
}
