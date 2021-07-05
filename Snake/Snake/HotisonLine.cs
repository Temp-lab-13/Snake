﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class HorisonLine
    {
        List<PoinOutput> pList;

        public HorisonLine(int xLeft, int xRight, int y, char symbol)
        {
            pList = new List<PoinOutput>();
            for(int x = xLeft; x <= xRight; x++)
            {
                PoinOutput p = new PoinOutput(x, y, symbol);
                pList.Add(p);
            }
        }

        public void Drow()
        {
            foreach(PoinOutput p in pList)
            {
                p.Draw();
            }
        }

    }
}
