using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine : Figure
    {
        public VerticalLine(int yLeft, int yRight, int x, char symbol)
        {
            pList = new List<PoinOutput>();
            for (int y = yLeft; y <= yRight; y++)
            {
                PoinOutput p = new PoinOutput(x, y, symbol);
                pList.Add(p);
            }
        }




    }
}
