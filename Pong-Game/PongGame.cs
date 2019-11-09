using System;
using System.Windows.Forms;

namespace Pong_Game
{
    public partial class PongGame : Form
    {
        int ballx = 5;
        int bally = 5;
        int score = 0;
        public PongGame()
        {
            InitializeComponent();
            timer1.Stop();
            racket.Visible = false;
            key_label.Visible = true;
            Cursor.Show();
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape) { Application.Exit(); }

            if (e.KeyCode == Keys.Space)
            {
                if (timer1.Enabled)
                {
                    timer1.Stop();
                }
                else
                {
                    timer1.Start();
                }
                
            }

            if (e.KeyCode == Keys.N || e.KeyCode == Keys.M || e.KeyCode == Keys.E)
            {
                Cursor.Hide();
                key_label.Visible = false;
                racket.Visible = true;
                racket.Width = 210;
                racket.Left = 300;
                ball.Left = 300;
                ball.Top = 150;
                score = 0;
                playerScore.Text = "" + score;
                timer1.Start();
            }
            
            if (e.KeyCode == Keys.N)
            {
                ballx = 5;
                bally = 5;
                racket.Width = 210;
            }

            if (e.KeyCode == Keys.M)
            {
                ballx = 10;
                bally = 10;
            }
            if (e.KeyCode == Keys.E)
            {
                ballx = 15;
                bally = 15;
                racket.Width = 140;
            }
        }

        private void TimerTick(object sender, EventArgs e)
        {
            racket.Left = Cursor.Position.X - (racket.Width / 2);
            playerScore.Text = "" + score;

            ball.Top -= bally;
            ball.Left -= ballx;

            if (ball.Top < 0)
            {
                bally = -bally;
            }

            if (ball.Right > ClientSize.Width || ball.Left < 0)
            {
                ballx = -ballx;
            }
                
            if (ball.Bounds.IntersectsWith(racket.Bounds))
            {
                bally = -bally;
                score++;
            }

            if (ball.Top > ClientSize.Height)
            {
                timer1.Stop();
                racket.Visible = false;
                key_label.Visible = true;
                Cursor.Show();
            }

            if (ball.Bounds.IntersectsWith(racket.Bounds) && score % 5 == 0)
            {
                ballx = -ballx;
                ballx += 4;
                bally += 4;
            }

            if (racket.Location.X > ClientSize.Width - racket.Width)
            {
                racket.Left = ClientSize.Width - racket.Width;
            }

            if (racket.Location.X < 0)
            {
                racket.Left = 0;
            }
        }
    }
}
