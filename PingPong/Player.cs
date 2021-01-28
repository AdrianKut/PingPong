using System.Windows.Forms;

namespace PingPong
{
    class Player : IPos
    {

        public int points { get;  set; }
        public int xPos { get; set; }
        public int yPos { get; set; }

        public bool UpMoving { get; set; }
        public bool DownMoving { get; set; }

        public PictureBox pictureBox;
        public Label label { get; set; }

        public Player(int points, int xPos, int yPos, PictureBox pictureBox, Label label)
        {
            this.points = points;
            this.xPos = xPos;
            this.yPos = yPos;

            this.pictureBox = pictureBox;
            this.label = label;

            UpMoving = false;
            DownMoving = false;
        }

        public void Move()
        {
            if (UpMoving)
            {
                if (yPos > 0)
                {
                    yPos = yPos - 10;
                    pictureBox.Location = new System.Drawing.Point(xPos, yPos);
                }
            }
            else if (DownMoving)
            {
                if (yPos < 458)
                {
                    yPos = yPos + 10;
                    pictureBox.Location = new System.Drawing.Point(xPos, yPos);
                }
            }
        }

        public void ResetPoints()
        {
            points = 0;
        }
    }
}
