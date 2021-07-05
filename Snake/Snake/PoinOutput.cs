using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class PoinOutput
    {
        public int x;
        public int y;
        public char symbol;

        public PoinOutput(int X, int Y, char Symbol)
        {
            x = X;
            y = Y;
            symbol = Symbol;
        }

        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
