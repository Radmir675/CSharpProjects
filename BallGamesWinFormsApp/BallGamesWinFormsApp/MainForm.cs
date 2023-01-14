using Ball_Library;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BallGamesWinFormsApp
{
    public partial class MainForm : Form
    {
        List<MoveBall> moveBalls;
        PointBall pointBall;
        public MainForm()
        {
            InitializeComponent();
        }


        private void RandomDrawing_Click(object sender, EventArgs e)
        {
            pointBall.Move();

        }

        private void MainForm_MouseDown(object sender, MouseEventArgs e)
        {
            pointBall = new PointBall(this, e.X, e.Y);
            pointBall.Show();

        }

        private void Draw(object sender, EventArgs e)
        {

            moveBalls = new List<MoveBall>();

            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void StopBalls_Click(object sender, EventArgs e)
        {
            int numberInteriorBall = 0;
            if (moveBalls == null)
            {
                MessageBox.Show("Игра еще не начата");
                return;
            }

            for (int i = 0; i < 10; i++)
            {
                moveBalls[i].Stop();
                if (moveBalls[i].ContainBall())
                {
                    numberInteriorBall++;

                }

            }
            MessageBox.Show($"Удалось поймать {numberInteriorBall} штук");
        }

        private void Clear_button_Click(object sender, EventArgs e)
        {
            foreach (var ball in moveBalls)
            {
                ball.Clear();
            }
        }
    }
}
