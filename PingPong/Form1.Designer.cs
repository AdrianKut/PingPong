namespace PingPong
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.timerGame = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxRightPlayer = new System.Windows.Forms.PictureBox();
            this.pictureBoxLeftPlayer = new System.Windows.Forms.PictureBox();
            this.labelLeftPlayer = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.labelRightPlayer = new System.Windows.Forms.Label();
            this.pictureBoxBall = new System.Windows.Forms.PictureBox();
            this.panelBackground = new System.Windows.Forms.Panel();
            this.labelWinner = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftPlayer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBall)).BeginInit();
            this.panelBackground.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerGame
            // 
            this.timerGame.Interval = 25;
            this.timerGame.Tick += new System.EventHandler(this.timerGame_Tick_1);
            // 
            // pictureBoxRightPlayer
            // 
            this.pictureBoxRightPlayer.BackColor = System.Drawing.Color.Black;
            this.pictureBoxRightPlayer.Location = new System.Drawing.Point(761, 211);
            this.pictureBoxRightPlayer.Name = "pictureBoxRightPlayer";
            this.pictureBoxRightPlayer.Size = new System.Drawing.Size(20, 100);
            this.pictureBoxRightPlayer.TabIndex = 0;
            this.pictureBoxRightPlayer.TabStop = false;
            // 
            // pictureBoxLeftPlayer
            // 
            this.pictureBoxLeftPlayer.BackColor = System.Drawing.Color.Black;
            this.pictureBoxLeftPlayer.Location = new System.Drawing.Point(3, 211);
            this.pictureBoxLeftPlayer.Name = "pictureBoxLeftPlayer";
            this.pictureBoxLeftPlayer.Size = new System.Drawing.Size(20, 100);
            this.pictureBoxLeftPlayer.TabIndex = 1;
            this.pictureBoxLeftPlayer.TabStop = false;
            // 
            // labelLeftPlayer
            // 
            this.labelLeftPlayer.AutoSize = true;
            this.labelLeftPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelLeftPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelLeftPlayer.Location = new System.Drawing.Point(306, 9);
            this.labelLeftPlayer.Name = "labelLeftPlayer";
            this.labelLeftPlayer.Size = new System.Drawing.Size(51, 55);
            this.labelLeftPlayer.TabIndex = 2;
            this.labelLeftPlayer.Text = "0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(379, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 55);
            this.label2.TabIndex = 3;
            this.label2.Text = "|";
            // 
            // labelRightPlayer
            // 
            this.labelRightPlayer.AutoSize = true;
            this.labelRightPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelRightPlayer.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelRightPlayer.Location = new System.Drawing.Point(433, 9);
            this.labelRightPlayer.Name = "labelRightPlayer";
            this.labelRightPlayer.Size = new System.Drawing.Size(51, 55);
            this.labelRightPlayer.TabIndex = 4;
            this.labelRightPlayer.Text = "0";
            // 
            // pictureBoxBall
            // 
            this.pictureBoxBall.BackColor = System.Drawing.Color.DodgerBlue;
            this.pictureBoxBall.Location = new System.Drawing.Point(377, 233);
            this.pictureBoxBall.Name = "pictureBoxBall";
            this.pictureBoxBall.Size = new System.Drawing.Size(20, 20);
            this.pictureBoxBall.TabIndex = 5;
            this.pictureBoxBall.TabStop = false;
            // 
            // panelBackground
            // 
            this.panelBackground.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panelBackground.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelBackground.Controls.Add(this.labelWinner);
            this.panelBackground.Controls.Add(this.pictureBoxBall);
            this.panelBackground.Controls.Add(this.labelRightPlayer);
            this.panelBackground.Controls.Add(this.label2);
            this.panelBackground.Controls.Add(this.labelLeftPlayer);
            this.panelBackground.Controls.Add(this.pictureBoxLeftPlayer);
            this.panelBackground.Controls.Add(this.pictureBoxRightPlayer);
            this.panelBackground.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelBackground.Location = new System.Drawing.Point(0, 0);
            this.panelBackground.Name = "panelBackground";
            this.panelBackground.Size = new System.Drawing.Size(784, 561);
            this.panelBackground.TabIndex = 0;
            // 
            // labelWinner
            // 
            this.labelWinner.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.labelWinner.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.labelWinner.Location = new System.Drawing.Point(38, 211);
            this.labelWinner.Name = "labelWinner";
            this.labelWinner.Size = new System.Drawing.Size(693, 190);
            this.labelWinner.TabIndex = 6;
            this.labelWinner.Text = "PRESS ENTER TO START ";
            this.labelWinner.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.panelBackground);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ping Pong";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxRightPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLeftPlayer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxBall)).EndInit();
            this.panelBackground.ResumeLayout(false);
            this.panelBackground.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerGame;
        private System.Windows.Forms.PictureBox pictureBoxRightPlayer;
        private System.Windows.Forms.PictureBox pictureBoxLeftPlayer;
        private System.Windows.Forms.Label labelLeftPlayer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label labelRightPlayer;
        private System.Windows.Forms.PictureBox pictureBoxBall;
        private System.Windows.Forms.Panel panelBackground;
        private System.Windows.Forms.Label labelWinner;
    }
}

