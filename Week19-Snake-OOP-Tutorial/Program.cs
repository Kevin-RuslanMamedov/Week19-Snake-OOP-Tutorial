
using System;
using System.Collections.Generic;

namespace Week19_Snake_OOP_Tutorial
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(10, 10, '*');
            Point p2 = new Point(11, 10, '*');

            HorizontalLine hLine = new HorizontalLine(10, 14, 5, '*');
            hLine.Draw();

            Console.ReadLine();
        }

    }
}
