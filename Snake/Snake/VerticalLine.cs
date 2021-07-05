using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
        List<PoinOutput> pList;

        public VerticalLine(int yLeft, int yRight, int x, char symbol)
        {
            pList = new List<PoinOutput>();
            for (int y = yLeft; y <= yRight; y++)
            {
                PoinOutput p = new PoinOutput(x, y, symbol);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach (PoinOutput p in pList)
            {
                p.Draw();
            }
        }

    }
}
