using System;

namespace Snake
{
    internal class FoodCreator
    {
        private int mapWight;
        private int mapHeight;
        private char sym;

        Random random = new Random();

        public FoodCreator(int mapWight, int mapHeight, char sym)
        {
            this.mapWight = mapWight;
            this.mapHeight = mapHeight;
            this.sym = sym;
        }

        internal Point CreateFood()
        {
            int x = random.Next(2, mapWight - 2);
            int y = random.Next(2, mapHeight- 2);
            return new Point(x, y, sym);
        }
    }
}