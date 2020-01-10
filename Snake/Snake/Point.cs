using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class Point
    {
        public int x;
        public int y;
        public int sym;
        public Point() { }

        public Point(int x,int y, char sym) {
            this.x = x;
            this.y = y;
            this.sym = sym;
        }
        public void Draw()
        {
            Console.SetCursorPosition(x, y);
            Console.Write(sym);
        }
    }
}
