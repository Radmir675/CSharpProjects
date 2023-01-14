using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angry_Birds
{
    public partial class Angry_birds_Form : Form
    {
        Elastic_ball elastic_Ball;
        SwineBall swineBall;
        public Angry_birds_Form()
        {
            InitializeComponent();
        }

        private void Elastic_Ball_OutOfSpace(object sender, EventArgs e)
        {
            elastic_Ball.Stop();
            elastic_Ball.Clear();

            CreateNewBall();
        }

        private void StartGameButton_Click(object sender, EventArgs e)
        {
            CreateNewBall();
            swineBall = new SwineBall(this);
            swineBall.Show();

        }

        private void Angry_birds_Form_MouseClick(object sender, MouseEventArgs e)
        {
            try
            {
                elastic_Ball.OutOfSpace += Elastic_Ball_OutOfSpace;
                elastic_Ball.CreateNewSwine += Elastic_Ball_CreateNewSwine;
                if (elastic_Ball.vx == 0 && elastic_Ball.vy == 0)
                {
                    float forceX = e.X/ 10-15 ;
                    float forceY = (435-e.Y)/10-5;
                    elastic_Ball.vx = forceX;
                    elastic_Ball.vy = -forceY;
                    elastic_Ball.Start();
                    elastic_Ball.SwineBallIntersection += Elastic_Ball_SwineBallIntersection;
                }

            }
            catch (NullReferenceException)
            {
            }
        }

        private void Elastic_Ball_CreateNewSwine(object sender, EventArgs e)
        {
            swineBall = new SwineBall(this);
            swineBall.Show();
        }

        private void Elastic_Ball_SwineBallIntersection(object sender, EventArgs e)
        {

            swineBall.Clear();
            Scorelabel.Text = (Convert.ToInt32(Scorelabel.Text) + 1).ToString();
        }

        public void CreateNewBall()
        {
            elastic_Ball = new Elastic_ball(this);
            elastic_Ball.Show();
        }

    }
}
