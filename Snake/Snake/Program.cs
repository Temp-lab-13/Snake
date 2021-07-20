using System;
using System.Threading;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            Walls walls = new Walls(80, 25);
            walls.Drow();
           
            //Отрисовка точек.
            PoinOutput p = new PoinOutput(4, 5, '*');
            Snaake snake = new Snaake(p, 4, Direction.RIGHT);
            snake.Drow();

            //Отрисовка еды.
            FoodCreator foodCreator = new FoodCreator(80, 25, '#');
            PoinOutput food = foodCreator.CreaterFood();
            food.Drow();

            while (true)
            {
                if (walls.IsHit(snake) || snake.IsHitTail())
                {
                    break;
                }
                if(snake.Eat(food))
                {
                    food = foodCreator.CreaterFood();
                    food.Drow();
                }
                else
                {
                    snake.Move();
                }

                Thread.Sleep(100);

                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandKey(key.Key);
                }
            }

            GameOver.WriteGameOver();
            Console.ReadLine();
        }
    }
}
