using Ball_Library;
using System;
using System.Windows.Forms;

namespace Pool_tableWinForms
{
    public class BilliardBall:MoveBall
    {
        public event EventHandler<HitEventArgs> OnHitted;
        public BilliardBall(Form form):base(form)
        {

        }
        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide() )
            {
                vx = -vx;
                OnHitted.Invoke(this, new HitEventArgs(Side.Left));
            }
            if ( centerX >= RightSide())
            {
                vx = -vx;
                OnHitted.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= TopSide() )
            {
                vy = -vy;
                OnHitted.Invoke(this, new HitEventArgs(Side.Top));
            }
            if ( centerY >= DownSide())
            {
                vy = -vy;
                OnHitted.Invoke(this, new HitEventArgs(Side.Down));
            } 
        }
    }
}
