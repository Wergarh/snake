using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
//            p1.Draw();
            Point p2 = new Point(4, 5, '#');
//            p2.Draw();
/*
            List<Point> pList = new List<Point>();
            pList.Add(p1);
            pList.Add(p2);
*/

            HorizontalLine hLine1 = new HorizontalLine(1, 20, 1, '*');
            hLine1.Draw();
            VerticalLine vLine1 = new VerticalLine(1, 20, 1, '*');
            vLine1.Draw();
            HorizontalLine hLine2 = new HorizontalLine(1, 20, 20, '*');
            hLine2.Draw();
            VerticalLine vLine2 = new VerticalLine(1, 20, 20, '*');
            vLine2.Draw();

            Console.ReadLine();
        }
    }
}
