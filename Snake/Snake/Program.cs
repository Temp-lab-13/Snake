using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            PoinOutput p1 = new PoinOutput(1, 3, '*');
            p1.Draw();
            PoinOutput p2 = new PoinOutput(4, 5, '#');
            p2.Draw();

            HorisonLine LineX = new HorisonLine(1, 15, 10, '-');
            LineX.Drow();
            HorisonLine xLine = new HorisonLine(1, 15, 0, '-');
            xLine.Drow();
            VerticalLine vLine = new VerticalLine(0, 10, 0, '|');
            vLine.Drow();
            VerticalLine LineV = new VerticalLine(0, 10, 16, '|');
            LineV.Drow();

            Console.ReadLine();

        }
    }
}
