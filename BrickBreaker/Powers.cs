using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrickBreaker
{
    internal class Powers
    {
        public int x, y, size;
        public string type;
        public SolidBrush color;
        public Powers(int x, int y, string type)
        {
            this.x = x;
            this.y = y;
            this.size = 15; // Power-up size
            this.type = type;

            // Assign colors based on power-up type
            if (type == "ExtraLife") color = new SolidBrush(Color.Green);
            else if (type == "SpeedBoost") color = new SolidBrush(Color.Blue);
            else if (type == "BigPaddle") color = new SolidBrush(Color.Orange);
            else if (type == "Bullet") color = new SolidBrush(Color.Black);

        }

        // Move power-up down
        public void Move()
        {
            y += 2;
        }
    }
}