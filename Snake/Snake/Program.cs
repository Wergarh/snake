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
            Console.SetBufferSize(80, 25);

            HorizontalLine hLine1 = new HorizontalLine(1, 78, 1, '*');
            HorizontalLine hLine2 = new HorizontalLine(1, 78, 24, '*');
            VerticalLine vLine1 = new VerticalLine(1, 24, 1, '*');
            VerticalLine vLine2 = new VerticalLine(1, 24, 78, '*');
            hLine1.Draw();
            hLine2.Draw();
            vLine1.Draw();
            vLine2.Draw();

            Console.ReadLine();
        }
    }
}
