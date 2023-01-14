using Ball_Library;
using Pool_tableWinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DiffusionWindowsFormsApp
{
    public class RandomPointBallDevide : MoveBall
    {
        public event EventHandler<HitEventArgs> OnHittedDevide;
        Brush ballsColor;
        public RandomPointBallDevide(Form main, Side side, Brush brush) : base(main)
        {
            ballsColor = brush;
            switch (side)
            {
                case Side.Left:
                    centerX = random.Next(LeftSide(), HalfSide());
                    centerY = random.Next(TopSide(), DownSide());


                    break;
                case Side.Right:
                    centerX = random.Next(HalfSide(), RightSide());
                    centerY = random.Next(TopSide(), DownSide());

                    break;

                default:
                    break;
            }

        }

        public override void Show()
        {
            var brush = ballsColor;
            Draw(brush);
        }

        protected override void Go()
        {
            base.Go();
            if (centerX <= LeftSide())
            {
                vx = -vx;
                OnHittedDevide.Invoke(this, new HitEventArgs(Side.Left));
            }
            if (centerX >= RightSide())
            {
                vx = -vx;
                OnHittedDevide.Invoke(this, new HitEventArgs(Side.Right));
            }
            if (centerY <= TopSide())
            {
                vy = -vy;
                if (centerX < HalfSide()) 
                {

                OnHittedDevide.Invoke(this, new HitEventArgs(Side.TopL));
                }
                else
                {
                    OnHittedDevide.Invoke(this, new HitEventArgs(Side.TopR));
                }
            }
            if (centerY >= DownSide())
            {
                vy = -vy;
                if (centerX < HalfSide())
                {
                    OnHittedDevide.Invoke(this, new HitEventArgs(Side.DowmL));
                }
                else
                {
                    OnHittedDevide.Invoke(this, new HitEventArgs(Side.DownR));
                }
                
            }
        }
    }
}
