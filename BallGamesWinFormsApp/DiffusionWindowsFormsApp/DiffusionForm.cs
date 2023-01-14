using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using Ball_Library;
using Pool_tableWinForms;
namespace DiffusionWindowsFormsApp
{
    public partial class DiffusionForm : Form
    {
        RandomPointBallDevide randomPointBall1;
        RandomPointBallDevide randomPointBall2;
        private Graphics graphics;
        bool clicked = false;
        List<RandomPointBallDevide> randomPointBallDevide = new List<RandomPointBallDevide>();

        public DiffusionForm()
        {
            InitializeComponent();
        }


        private void CreateDevideLine()
        {
            graphics = this.CreateGraphics();
            Point point1 = new Point(ClientSize.Width / 2, 0);
            Point point2 = new Point(ClientSize.Width / 2, ClientSize.Height);
            Pen pen = new Pen(Color.Red,3);
            pen.DashStyle = DashStyle.Dash;
            graphics.DrawLine(pen, point1, point2);
        }

        private void Startbutton_Click(object sender, EventArgs e)
        {
            CreateDevideLine();
            StartMoving();
        }
        private void StartMoving() 
        {
            
            for (int i = 0; i < 2; i++)
            {

                randomPointBall1 = new RandomPointBallDevide(this,Side.Left,Brushes.Black);                
                randomPointBall1.Start();
                randomPointBallDevide.Add(randomPointBall1 );


                randomPointBall2 = new RandomPointBallDevide(this,Side.Right, Brushes.Red);
                randomPointBall2.Start();
                randomPointBallDevide.Add(randomPointBall2);
               
                
                randomPointBall1.OnHittedDevide += RandomPointBall1_OnHittedDevide;
                randomPointBall2.OnHittedDevide += RandomPointBall2_OnHittedDevide;
                randomPointBall1.OnHittedDevide += CheckFullDiffusion;

            }
            
        }
        private void CheckFullDiffusion(object sender, HitEventArgs e) 
        {
            if (int.Parse(BlackScoreLabelLeft.Text)==0)
            {
                return;
            }
            if (int.Parse(BlackScoreLabelLeft.Text)== int.Parse(RedScoreLabelLeft.Text)&& int.Parse(BlackScoreLabelRight.Text) == int.Parse(RedScoreLabelRight.Text))
            {

                foreach (var item in randomPointBallDevide)
                {
                    item?.Stop();
                }
                MessageBox.Show("Наступило полное смешение молекул");


            }
        }
        private void RandomPointBall2_OnHittedDevide(object sender, HitEventArgs e)
        {
            if (e.Side == Side.Right)
            {
                RedScoreLabelRight.Text = (Convert.ToInt32(RedScoreLabelRight.Text) + 1).ToString();
            }
            if (e.Side == Side.Left)
            {
                RedScoreLabelLeft.Text = (Convert.ToInt32(RedScoreLabelLeft.Text) + 1).ToString();
            }
            if (e.Side==Side.DowmL)
            {
                RedScoreLabelLeft.Text = (Convert.ToInt32(RedScoreLabelLeft.Text) + 1).ToString();
            }
            if(e.Side==Side.DownR)
            {
                RedScoreLabelRight.Text = (Convert.ToInt32(RedScoreLabelRight.Text) + 1).ToString();
            }
            if (e.Side == Side.TopL)
            {
                RedScoreLabelLeft.Text = (Convert.ToInt32(RedScoreLabelLeft.Text) + 1).ToString();
            }
            if (e.Side == Side.TopR)
            {
                RedScoreLabelRight.Text = (Convert.ToInt32(RedScoreLabelRight.Text) + 1).ToString();
            }
        }

        private void RandomPointBall1_OnHittedDevide(object sender, HitEventArgs e)
        {
            if (e.Side == Side.TopL)
            {
                BlackScoreLabelLeft.Text = (Convert.ToInt32(BlackScoreLabelLeft.Text) + 1).ToString();

            }
            if (e.Side == Side.TopR)
            {
                BlackScoreLabelRight.Text = (Convert.ToInt32(BlackScoreLabelRight.Text) + 1).ToString();
            }
            if (e.Side == Side.Right)
            {
                BlackScoreLabelRight.Text = (Convert.ToInt32(BlackScoreLabelRight.Text) + 1).ToString();
            }
            if (e.Side == Side.Left)
            {
                BlackScoreLabelLeft.Text = (Convert.ToInt32(BlackScoreLabelLeft.Text) + 1).ToString();
            }
            if (e.Side == Side.DowmL)
            {
                BlackScoreLabelLeft.Text = (Convert.ToInt32(BlackScoreLabelLeft.Text) + 1).ToString();

            }
            if (e.Side == Side.DownR)
            {
                BlackScoreLabelRight.Text = (Convert.ToInt32(BlackScoreLabelRight.Text) + 1).ToString();
            }
        }

        private void DiffusionForm_Click(object sender, EventArgs e)
        {
            if (clicked)
            {
                foreach (var item in randomPointBallDevide)
                {
                    item?.Start();
                }
                clicked = !clicked;
            }
            else
            {
                foreach (var item in randomPointBallDevide)
                {
                    item?.Stop();
                }

                clicked = !clicked;
            }

            
        }
    }
}
