using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Figure
    {
        protected List<PoinOutput> pList;

        public virtual void Drow()
        {
            //Console.ForegroundColor = ConsoleColor.Yellow;
            foreach (PoinOutput p in pList)
            {
                p.Drow();
            }
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var p in pList)
            {
                if (figure.IsHit(p))
                    return true;
            }
            return false;
        }
        private bool IsHit(PoinOutput poinOutput)
        {
            foreach (var p in pList)
            {
                if (p.IsHit(poinOutput))
                    return true;
            }
            return false;
        }
    }
}
