using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            PoinOutput p1 = new PoinOutput(1, 3, '*');
            //p1.x = 1;
            //p1.y = 3;
            //p1.symbol = '*';
            p1.Draw();

            PoinOutput p2 = new PoinOutput(4, 5, '#');
            //p2.x = 4;
            //p2.y = 5;
            //p2.symbol = '#';
            p2.Draw();
        }
    }
}
