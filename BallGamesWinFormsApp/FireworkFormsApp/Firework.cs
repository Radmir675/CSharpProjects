using System;
using System.Windows.Forms;

namespace FireworkFormsApp
{
    public partial class Firework : Form
    {
        Random random = new Random();
        RandomeSaluteBall randomeSaluteBall;
        public Firework()
        {
            InitializeComponent();
        }

        private void Firework_MouseDown(object sender, MouseEventArgs e)
        {
            Random random = new Random();

            for (int i = 0; i < random.Next(1, 10); i++)
            {
                var salute = new Salute(this, e.X, e.Y);
                salute.Start();
                
            }

            timerToSalutStart.Interval = random.Next(1000, 6000);
            timerToSalutStart.Start();

        }

        public void StartSingleSalute() 
        {
            randomeSaluteBall = new RandomeSaluteBall(this);
            randomeSaluteBall.Start();
            
            
            randomeSaluteBall.DeleteBall += RandomeSaluteBall_DeleteBall;

        }
        private void RandomeSaluteBall_DeleteBall(object sender, PositionArgs e )
        {
            for (int i = 0; i < random.Next(10, 20); i++)
            {
                var salute = new Salute(this,e.centerX,e.centerY);
                salute.Start();
            }
            randomeSaluteBall.Stop();
            randomeSaluteBall.Clear();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            StartSingleSalute();
        }
    }
}
