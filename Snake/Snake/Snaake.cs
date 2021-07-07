using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Snake
{
    class Snaake : Figure
    {
        Direction direction;
        public Snaake(PoinOutput tail, int lenght, Direction _direction)
        {
            direction = _direction;
            pList = new List<PoinOutput>();
            for (int i = 0; i < lenght; i++)
            {
                PoinOutput p = new PoinOutput(tail);
                p.Move(i, direction);
                pList.Add(p);
            }
        }

        internal void Move()
        {
            PoinOutput tail = pList.First();
            pList.Remove(tail);
            PoinOutput head = GetNextPoint();
            pList.Add(head);

            tail.Clear();
            head.Drow();
        }

        public PoinOutput GetNextPoint()
        {
            PoinOutput head = pList.Last();
            PoinOutput nextPoint = new PoinOutput(head);
            nextPoint.Move(1, direction);
            return nextPoint;
        }

        public void HandKey(ConsoleKey key)
        {
            if (key == ConsoleKey.LeftArrow)
                direction = Direction.LEFT;
            else if (key == ConsoleKey.RightArrow)
                direction = Direction.RIGHT;
            else if (key == ConsoleKey.DownArrow)
                direction = Direction.DOWN;
            else if (key == ConsoleKey.UpArrow)
                direction = Direction.UP;
        }
    }
}
