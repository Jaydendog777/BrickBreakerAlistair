using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{
    internal class Bricks
    {

        public static int width = 40;
        public static int height = 40;
        public static int numRows = 5;
        public static int numCols = 10;
        public static int spacing = 5;
        public Rectangle Rect { get; set; }
        public Brush Color { get; set; }

        int X_;

        public Bricks(int x, int y, int width, int height)
        {

            Rect = new Rectangle(x, y, width, height);
            X_ = x;

        }

        public int returnX()
        {
            return X_;
        }

    }
}
