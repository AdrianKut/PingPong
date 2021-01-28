using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PingPong
{
    public partial class Form1 : Form
    {
        GameManager gameManager;

        public Form1()
        {
            InitializeComponent();
            timerGame.Start();

            Player[] players = new Player[2]
         {
                new Player(0,761,211,pictureBoxRightPlayer,labelRightPlayer),
                new Player(0,3,211,pictureBoxLeftPlayer,labelLeftPlayer)
         };

            Ball ball = new Ball(panelBackground.Width/2, panelBackground.Height/2, pictureBoxBall);

            gameManager = new GameManager(players[1],players[0],ball,labelWinner, panelBackground,6);
        }

        private void timerGame_Tick_1(object sender, EventArgs e)
        {
            gameManager.MoveObjects();
            gameManager.PointsGetter();
            gameManager.HitBall();
            gameManager.ManageLabels();
            gameManager.GameOver();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            gameManager.StartGame(e);
            gameManager.MovePlayers(e);
        }


    }
}
