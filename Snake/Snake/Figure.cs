using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure
    {
        protected List<PoinOutput> pList;

        public void Drow()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            foreach (PoinOutput p in pList)
            {
                p.Drow();
            }
        }

    }
}
