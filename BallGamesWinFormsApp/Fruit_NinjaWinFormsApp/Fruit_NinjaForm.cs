using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Fruit_NinjaWinFormsApp
{
    public partial class Fruit_NinjaForm : Form
    {
        public static event EventHandler FirstEvent;
        SnippedBall snippedBall;
        List<SnippedBall> snippedBalls = new List<SnippedBall>();
        public Fruit_NinjaForm()
        {
            InitializeComponent();
        }

        private void StartGame_button_Click(object sender, EventArgs e)
        {
            TakeOff_timer.Start();
        }

        private void TakeOff_timer_Tick(object sender, EventArgs e)
        {
            TakeOff_timer.Interval = new Random().Next(500, 1500);
            if (SlowMoretimer.Enabled)
            {
                YellowBall yellowBall = new YellowBall(this, -6, 0.1f);
                yellowBall.Start();
                snippedBalls.Add(yellowBall);
            }
            else
            {
                snippedBall = new SnippedBall(this);
                snippedBall.Start();
                snippedBalls.Add(snippedBall);
            }
        }


        private void Fruit_NinjaForm_MouseMove(object sender, MouseEventArgs e)
        {
            foreach (var colorball in snippedBalls)
            {
                if (colorball.ContainMouse(e.X, e.Y) && e.Button == MouseButtons.Left)
                {
                    if (colorball.brush.Color.Name == "Black")
                    {
                        TakeOff_timer.Stop();
                        foreach (var selectedBall in snippedBalls)
                        {
                            selectedBall.Stop();
                        }
                        MessageBox.Show("Игра окончена");
                    }

                    if (colorball.brush.Color.Name == "Yellow")
                    {
                        SlowMoretimer.Start();
                    }
                    colorball.Stop();
                    colorball.Clear();
                    foreach (var item in snippedBalls)
                    {
                        item.Clear();
                    }
                }
            }

        }

        private void SlowMoretimer_Tick(object sender, EventArgs e)
        {
            SlowMoretimer.Stop();
        }

       
    }

   
}
