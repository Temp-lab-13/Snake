using System;
using System.Collections.Generic;

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
            PoinOutput p3 = new PoinOutput(6, 1, '*');
            p3.Draw();
            PoinOutput p4 = new PoinOutput(8, 2, '*');
            p4.Draw();
            PoinOutput p5 = new PoinOutput(2, 0, '*');
            p5.Draw();
            PoinOutput p6 = new PoinOutput(6, 6, '*');
            p6.Draw();

            //Пример использования класса "лист".
            //List<int> numList = new List<int>();
            //numList.Add(0);
            //numList.Add(1);
            //numList.Add(2);

            //int x = numList[0];
            //int y = numList[1];
            //int z = numList[2];

            //foreach (int i in numList)
            //{
            //    Console.WriteLine(i);
            //}

            //numList.RemoveAt(0);

            List<Char> symlist = new List<Char>();
            symlist.Add('*');
            symlist.Add('#');

            List<PoinOutput> pList = new List<PoinOutput>();
            pList.Add(p1);
            pList.Add(p2);
            pList.Add(p3);
            pList.Add(p4);
            pList.Add(p5);
            pList.Add(p6);



            Console.ReadKey();
        }
    }
}
