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

        public PoinOutput()
        {
        }

        public PoinOutput(int X, int Y, char Symbol)
        {
            x = X;
            y = Y;
            symbol = Symbol;
        }

        public PoinOutput(PoinOutput p)
        {
            x = p.x;
            y = p.y;
            symbol = p.symbol;
        }

        public void Move(int offset, Direction direction)
        {
            if (direction == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (direction == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (direction == Direction.UP)
            {
                y = y - offset;
            }
            else if (direction == Direction.DOWN)
            {
                y = y + offset;
            }
        }


        public override string ToString()
        {
            return x + ", " + y + ", " + symbol;
        }

        public void Drow()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(symbol);
        }
    }
}
