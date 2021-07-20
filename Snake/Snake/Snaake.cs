﻿using System;
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

        public override void Drow()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;

            base.Drow();
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

        internal bool IsHitTail()
        {
            var head = pList.Last();
            for (int i = 0; i < pList.Count - 2; i++)
            {
                if (head.IsHit(pList[i]))
                    return true;
            }
            return false;
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

        internal bool Eat(PoinOutput food)
        {
            PoinOutput head = this.pList.Last();
            //PoinOutput head = GetNextPoint(); //вариант из видео заменён на вариант из коментариев.
            if (head.IsHit(food))
            {
                food.symbol = head.symbol;
                pList.Add(food);
                return true;
            }
            else
                return false;
        }
            

    }
}
