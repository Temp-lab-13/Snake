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
            foreach (PoinOutput p in pList)
            {
                p.Drow();
            }
        }

    }
}
