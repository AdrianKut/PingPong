using System.Windows.Forms;

namespace PingPong
{
    class GameManager
    {

        Ball ball;
        Player playerLeft;
        Player playerRight;

        Label labelWinner;

        Panel panelBackground;

        bool isStarted = false;

        private int pointsToWin { get; set; }

        public GameManager(Player playerLeft, Player playerRight, Ball ball, Label labelWinner,Panel panelBackground, int pointsToWin)
        {
            this.ball = ball;

            this.playerLeft = playerLeft;
            this.playerRight = playerRight;

            this.panelBackground = panelBackground;

            this.labelWinner = labelWinner;

            this.pointsToWin = pointsToWin;

        }

        public void MoveObjects()
        {
            if (isStarted)
            {
                ball.Move(panelBackground.Width, panelBackground.Height);

                playerLeft.Move();
                playerRight.Move();
            }

        }

        public void HitBall()
        {
            if (ball.pictureBox.Bounds.IntersectsWith(playerLeft.pictureBox.Bounds)
                || ball.pictureBox.Bounds.IntersectsWith(playerRight.pictureBox.Bounds))
            {
               ball.IncreaseSpeed();
               ball.ChangeVelocity();
            }
        }

        public void ManageLabels()
        {
            playerLeft.label.Text = "" + playerLeft.points;
            playerRight.label.Text = "" + playerRight.points;
        }


        public void PointsGetter()
        {
            if (ball.xPos > panelBackground.Width - 20)
            {
                playerLeft.points++;
                ball.ResetSpeed();
                ball.ResetPosition();
            }

            if (ball.xPos <= 1)
            {
                playerRight.points++;
                ball.ResetPosition();
                ball.ResetSpeed();
            }

        }

        public void MovePlayers(KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Up)
            {
                playerRight.UpMoving = true;
                playerRight.DownMoving = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                playerRight.UpMoving = false;
                playerRight.DownMoving = true;
            }

            if (e.KeyCode == Keys.W)
            {
                playerLeft.UpMoving = true;
                playerLeft.DownMoving = false;
            }

            if (e.KeyCode == Keys.S)
            {
                playerLeft.UpMoving = false;
                playerLeft.DownMoving = true;
            }

        }

        public void GameOver()
        {
            if (playerLeft.points == pointsToWin)
            {
                isStarted = false;
                labelWinner.Visible = true;
                labelWinner.Text = "PLAYER LEFT WON! \n\n PRESS ENTER TO START";

            }

            else if (playerRight.points == pointsToWin)
            {
                isStarted = false;
                labelWinner.Visible = true;
                labelWinner.Text = "PLAYER RIGHT WON! \n\n PRESS ENTER TO START";
            }
        }

        private void ResetGame()
        {

            isStarted = true;
            labelWinner.Visible = false;

            playerRight.ResetPoints();
            playerLeft.ResetPoints();
        }

        public void StartGame(KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && !isStarted)
            {
                ResetGame();
            }
        }

    }
}

