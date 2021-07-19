using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Walls
    {
        List<Figure> wallList;

        public Walls(int mapWisdth, int mapHeigth)
        {
            wallList = new List<Figure>();

            //Рисуется рамка из горизонтальных и вертикальных линий.
            HorisonLine LineX = new HorisonLine(0, mapWisdth - 2, mapHeigth - 1, '+');            
            HorisonLine xLine = new HorisonLine(0, mapWisdth - 2, 0, '+');  
            VerticalLine vLine = new VerticalLine(0, mapHeigth - 1, 0, '+');
            VerticalLine LineV = new VerticalLine(0, mapHeigth - 1, mapWisdth - 2, '+');

            wallList.Add(LineX);
            wallList.Add(xLine);
            wallList.Add(vLine);
            wallList.Add(LineV);
        }

        internal bool IsHit(Figure figure)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(figure))
                {
                    return true;
                }
            }
            return false;
        }

        public void Drow()
        {
            foreach (var wall in wallList)
            {
                wall.Drow();
            }
        }
    }
}
