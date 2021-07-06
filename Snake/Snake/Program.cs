using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            PoinOutput p1 = new PoinOutput(1, 3, '*');
            p1.Draw();
            Snaake snake = new Snaake(p, 5, Direction.RIGHT);
            snake.Draw();

       
        }
    }
}
