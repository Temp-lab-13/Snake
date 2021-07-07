using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

           
            HorisonLine LineX = new HorisonLine(0, 78, 24, '+');
            LineX.Drow();
            HorisonLine xLine = new HorisonLine(0, 78, 0, '+');
            xLine.Drow();
            VerticalLine vLine = new VerticalLine(0, 24, 0, '+');
            vLine.Drow();
            VerticalLine LineV = new VerticalLine(0, 24, 78, '+');
            LineV.Drow();

            PoinOutput p = new PoinOutput(4, 5, '*');
            Snaake snake = new Snaake(p, 4, Direction.RIGHT);
            snake.Drow();

            while(true)
            {
                if(Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    if (key.Key == ConsoleKey.LeftArrow)
                        snake.direction = Direction.LEFT;
                    else if (key.Key == ConsoleKey.RightArrow)
                        snake.direction = Direction.RIGHT;
                    else if (key.Key == ConsoleKey.DownArrow)
                        snake.direction = Direction.DOWN;
                    else if (key.Key == ConsoleKey.UpArrow)
                        snake.direction = Direction.UP;
                }
                Thread.Sleep(100);
                snake.Move();
            }

           
            
        }
    }
}
