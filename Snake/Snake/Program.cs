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
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();
            Thread.Sleep(300);
            snake.Move();


            Console.ReadLine();

        }
    }
}
