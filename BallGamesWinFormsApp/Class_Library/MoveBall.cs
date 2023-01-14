using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace BallGamesWinFormsApp
{
    class MoveBall:RandomPointBall
    {
        
        private Timer timer;
        public MoveBall(MainForm mainForm):base(mainForm)
        {
            vx = random.Next(1,10);
            vy = random.Next(1,10);
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
            //this.Refreshfield();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public void Start() 
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }
        public void ShowTotalBallsinScreen() 
        {
           
        }

    }
}
