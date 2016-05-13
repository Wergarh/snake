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
            Point p1 = new Point();
            p1.x = 1; p1.y = 3;
            p1.sym = '*';

            Point p2 = new Point();
            p2.x = 4; p2.y = 5;
            p2.sym = '#';

            Point p3 = new Point(6, 7, '%');
            p3.Draw();

            p1.Draw();
            p2.Draw();

            Console.ReadLine();
        }
    }
}
