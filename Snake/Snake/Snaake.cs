using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Snaake : Figure
    {
        public Snaake(PoinOutput tail, int lenght, Direction direction)
        {
            pList = new List<PoinOutput>();
            for (int i = 0; i < lenght; i++)
            {
                PoinOutput p = new PoinOutput(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }
    }
}
