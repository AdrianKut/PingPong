using System;
using System.Windows.Forms;

namespace PingPong
{
    class Ball : IPos
    {
        public int xPos { get; set; }
        public int yPos { get; set; }

        public PictureBox pictureBox;

        public float angleX = 6, angleY = 6;

        public Ball(int xPos, int yPos, PictureBox pictureBox)
        {
            this.xPos = xPos;
            this.yPos = yPos;
            this.pictureBox = pictureBox;
        }


        public void Move(int widthPanel, int heightPanel)
        {
            if (xPos < 0 || xPos > widthPanel - 20)
            {
                angleX = -angleX;
            }

            if (yPos < 0 || yPos > heightPanel - 20)
            {
                angleY = -angleY;
            }

            xPos = xPos + (int)angleX;
            yPos = yPos + (int)angleY;
            pictureBox.Location = new System.Drawing.Point(xPos, yPos);
        }

        public void ResetPosition()
        {
            Random random = new Random();
            yPos = random.Next(100,450);
            xPos = 379;
            ChangeVelocity();
        }

        public void IncreaseSpeed()
        {
            angleX *= 1.1f;
            angleY *= 1.1f;
        }

        public void ChangeVelocity()
        {
            angleX = -angleX;
        }

        public void ResetSpeed()
        {
            angleX = 6;
            angleY = 6;
        }

    }
}
