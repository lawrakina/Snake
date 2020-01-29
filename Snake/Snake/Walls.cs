using System.Collections.Generic;

namespace Snake
{
    internal class Walls
    {
        List<Figure> wallList;
        public Walls(int wight, int height) {
            wallList = new List<Figure>();

            HorisontalLine upLine = new HorisontalLine(0, wight - 2, 0, '#');
            VerticalLine leftLine = new VerticalLine(0, 0, height-2, '#');
            HorisontalLine downLine = new HorisontalLine(0, wight-2, height-2, '#');
            VerticalLine rightLine = new VerticalLine(wight-2, 0, height-2, '#');

            wallList.Add(upLine);
            wallList.Add(leftLine);
            wallList.Add(downLine);
            wallList.Add(rightLine);
        }

        internal bool IsHit(Figure f)
        {
            foreach (var wall in wallList)
            {
                if (wall.IsHit(f)) { return true; } 
            }
            return false;
        }

        public void Draw() {
            foreach (var wall in wallList) { 
                wall.Draw();
            }
        }
    }
}