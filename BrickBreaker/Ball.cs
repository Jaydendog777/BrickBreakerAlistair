using System;
using System.Drawing;
using System.Windows.Forms;

namespace BrickBreaker
{
    public class Ball
    {
        public int x, y, xSpeed, ySpeed, size;
        public Color colour;

        public static Random rand = new Random();

        public Ball(int _x, int _y, int _xSpeed, int _ySpeed, int _ballSize)
        {
            x = _x;
            y = _y;
            xSpeed = _xSpeed;
            ySpeed = _ySpeed;
            size = _ballSize;
        }

        public void Move()
        {
            x += xSpeed;
            y += ySpeed;
        }

        public bool Collision(Rectangle rect)
        {

            //Rectangle blockRec = new Rectangle(b.x, b.y, b.width, b.height);
            //Rectangle ballRec = new Rectangle(x, y, size, size);


            //if (ballRec.IntersectsWith(blockRec))
            //{
            //    ySpeed *= -1;
            //    //if (xSpeed < 6 && )
            //    //{
            //        //xSpeed++;
            //    //}

            //    //SpeedLimitY();
            //    //SpeedLimitX();
            //}

            //return blockRec.IntersectsWith(ballRec);
            return false;
        }

        public void PaddleCollision(Paddle p)
        {
            Rectangle ballRec = new Rectangle(x, y, size, size);
            Rectangle paddleRec = new Rectangle(p.x, p.y, p.width, p.height);

            if (ballRec.IntersectsWith(paddleRec))
            {
                ySpeed *= -1;

                if (ballRec.X < paddleRec.X + p.width / 2 && xSpeed > 0 || ballRec.X > paddleRec.X + p.width / 2 && xSpeed < 0)
                {
                    xSpeed *= -1;
                }

                //SpeedLimitY();
            }
        }

        public void SpeedLimitY()
        {
            if (ySpeed > 0 && ySpeed < 11)
            {
                ySpeed++;
            }
            else if (ySpeed < 0 && ySpeed > -11)
            {
                ySpeed--;
            }
        }

        public void SpeedLimitX()
        {
            if (xSpeed > 0 && xSpeed < 11)
            {
                xSpeed++;
            }
            else if (xSpeed < 0 && xSpeed > -11)
            {
                xSpeed--;
            }
        }

        public void OverallSpeedLimit()
        {
            if (xSpeed == 10 || ySpeed == 10  || ySpeed == -10)
            {
                ySpeed = 6;
                xSpeed = 6;
            }
            else if (xSpeed == -10)
            {
                xSpeed = -6;
            }
        }


        public void WallCollision(UserControl UC)
        {
            // Collision with left wall
            if (x <= 0)
            {
                xSpeed *= -1;
                //SpeedLimitX();
            }
            // Collision with right wall
            if (x >= (UC.Width - size))
            {
                xSpeed *= -1;
                //SpeedLimitX();
            }
            // Collision with bottom wall
            if (y >= UC.Height)
            {
                ySpeed *= -1;
                //SpeedLimitX();
            }
        }

        public bool TopCollision(UserControl UC)
        {
            Boolean didCollide = false;

            if (y <= 0)
            {
                didCollide = true;
            }

            return didCollide;
        }

    }
}
