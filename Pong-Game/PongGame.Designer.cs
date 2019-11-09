namespace Pong_Game
{
    partial class PongGame
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
            this.racket = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.playerScore = new System.Windows.Forms.Label();
            this.key_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.racket)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            this.SuspendLayout();
            // 
            // racket
            // 
            this.racket.BackColor = System.Drawing.Color.Yellow;
            this.racket.Location = new System.Drawing.Point(263, 514);
            this.racket.Name = "racket";
            this.racket.Size = new System.Drawing.Size(210, 20);
            this.racket.TabIndex = 0;
            this.racket.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.Fuchsia;
            this.ball.Location = new System.Drawing.Point(369, 192);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(27, 26);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.TimerTick);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.BackColor = System.Drawing.Color.MidnightBlue;
            this.playerScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playerScore.ForeColor = System.Drawing.Color.Red;
            this.playerScore.Location = new System.Drawing.Point(13, 13);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(128, 25);
            this.playerScore.TabIndex = 2;
            this.playerScore.Text = "playerScore";
            // 
            // key_label
            // 
            this.key_label.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.key_label.AutoSize = true;
            this.key_label.BackColor = System.Drawing.Color.AliceBlue;
            this.key_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.key_label.Location = new System.Drawing.Point(311, 159);
            this.key_label.Name = "key_label";
            this.key_label.Size = new System.Drawing.Size(122, 46);
            this.key_label.TabIndex = 3;
            this.key_label.Text = "Press\r\nN - New Game\r\nM - Medium level\r\nE - Expert level\r\nSpace - Pause\r\nEsc - Exit\r\n";
            this.key_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // PongGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(930, 551);
            this.Controls.Add(this.key_label);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.racket);
            this.Name = "PongGame";
            this.Text = "Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            ((System.ComponentModel.ISupportInitialize)(this.racket)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox racket;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label key_label;
    }
}

