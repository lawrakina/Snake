using System;
using System.Collections.Generic;
using System.Text;

namespace Snake
{
    class VerticalLine
    {
        public List<Point> pList;
        public VerticalLine(int x,int yTop,int yBottom, char sym) {
            pList = new List<Point>();
            for(int y = yTop; y<= yBottom; y++)
            {
                pList.Add(new Point(x, y, sym));
            }
        }
        public void Drow() {
            foreach(Point p in pList)
            {
                p.Draw();
            }
        }
    }
}
