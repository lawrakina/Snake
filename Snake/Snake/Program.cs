using System;
using System.Collections.Generic;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point(1, 3, '*');
            //p1.Draw();

            Point p2 = new Point(4, 5, '#');
            //p2.Draw();

            List<int> list = new List<int>();
            list.Add(p1.x);
            list.Add(1);
            list.Add(2);

            int x = list[0];
            int y = list[1];
            int z = list[2];

            foreach(int i in list)
            {
                Console.WriteLine(i);
            }

            list.RemoveAt(0);

            List<Point> pList = new List<Point>();

            Console.WriteLine($"p1.x = {p1.x}, x = {x}, list(0)={list[0]}");
            Console.WriteLine($"y = {y}, list(1)={list[1]}");

            p1.x++;
            Console.WriteLine($"p1.x = {p1.x}, x = {x}, list(0)={list[0]}");
            Console.WriteLine($"y = {y}, list(1)={list[1]}");

            Console.ReadKey();
        }
    }
}
