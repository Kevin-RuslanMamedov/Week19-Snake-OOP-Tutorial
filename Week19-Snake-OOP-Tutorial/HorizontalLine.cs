using System;
using System.Collections.Generic;
using System.Text;

namespace Week19_Snake_OOP_Tutorial
{
    class HorizontalLine
    {
        List<Point> pointList;

        public HorizontalLine(int xLeft, int xRight, int y, char symb)
        {
            pointList = new List<Point>();

            for (int i = xLeft; i <= xRight; i++)
            {
                Point p = new Point(i, y, symb);
                pointList.Add(p);
            } 
            // ########
        }
        public void Draw()
        {
            foreach(Point point in pointList)
            {
                Console.SetCursorPosition(point.x, point.y);
                Console.Write(point.symb);
            }
        }

    }
}
