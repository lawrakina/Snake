using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.SetBufferSize(120,30);

            HorisontalLine upLine = new HorisontalLine(0,78,0,'#');
            VerticalLine leftLine = new VerticalLine(0,0,23,'#');
            HorisontalLine downLine = new HorisontalLine(0,78,23,'#');
            VerticalLine rightLine = new VerticalLine(78,0,23,'#');

            upLine.Drow();
            leftLine.Drow();
            downLine.Drow();
            rightLine.Drow();

            HorisontalLine hLine = new HorisontalLine(3,10,8,'-');
            hLine.Drow();

            VerticalLine vLine = new VerticalLine(8,3,10,'|');
            vLine.Drow();

            Console.ReadKey();
        }
    }
}
