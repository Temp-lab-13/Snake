using System;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(80, 25);

            PoinOutput p1 = new PoinOutput(1, 3, '*');
            p1.Draw();

            HorisonLine LineX = new HorisonLine(0, 78, 24, '+');
            LineX.Drow();
            HorisonLine xLine = new HorisonLine(0, 78, 0, '+');
            xLine.Drow();
            VerticalLine vLine = new VerticalLine(0, 24, 0, '+');
            vLine.Drow();
            VerticalLine LineV = new VerticalLine(0, 24, 78, '+');
            LineV.Drow();

            Console.ReadLine();

        }
    }
}
