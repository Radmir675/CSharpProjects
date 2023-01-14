using System;
using System.Collections.Generic;
using System.Windows.Forms;
using Ball_Library;

namespace CatchBallsWindowsFormsApp
{
    public partial class Form1 : Form
    {
       List<Ball> moveBalls;
        int CatchingCount = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void CreateBalls_Click(object sender, EventArgs e)
        {
            moveBalls = new List<Ball>();

            for (int i = 0; i < 10; i++)
            {
                var moveBall = new MoveBall(this);
                moveBalls.Add(moveBall);
                moveBall.Start();
            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            foreach (var item in moveBalls)
            {
                if (item.ContainMouse(e.X, e.Y))
                {
                    CatchingCount++;
                    ScoreLabel.Text = CatchingCount.ToString();
                    item.Stop();
                    item.Clear();
                }

            }

        }
    }
}
