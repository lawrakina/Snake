using System;
using System.Collections.Generic;
using System.Threading;

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

            Point p = new Point(3,4,'*');
            Snake snake = new Snake(p,4,Direction.RIGHT);
            snake.Drow();

            while (true)
            {
                if (Console.KeyAvailable)
                {
                    ConsoleKeyInfo key = Console.ReadKey();
                    snake.HandlKey(key.Key);
                }

                snake.Move();
                Thread.Sleep(100);
            }
            

            Console.ReadKey();
        }
    }
}
