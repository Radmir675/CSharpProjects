using Ball_Library;
using FireworkFormsApp;
using System;
using System.Drawing;
using System.Windows.Forms;

namespace Angry_Birds
{
    public class Elastic_ball : Ball
    {
        public event EventHandler SwineBallIntersection;
        public event EventHandler OutOfSpace;
        public event EventHandler CreateNewSwine;
        private float g = 0.5f;
        bool IsIntersected = false;
        bool ToShow = true;


        public Elastic_ball(Form form) : base(form)
        {

            radius = 15;
            centerX = LeftSide();
            centerY = DownSide();
            vx = 0;
            vy = 0;

        }


        public bool IntesectBall(RectangleF rectangle1)
        {
            bool isIntersect = rectangle.IntersectsWith(rectangle1);
            return isIntersect;
        }
        public override void Move()
        {
            Clear();
            Go();
            if (ToShow)
            {
                Show();

            }
            else
            {
                OutOfSpace?.Invoke(this, EventArgs.Empty);
            }

            if (IntesectBall(SwineBall.swineArea) && IsIntersected == false)
            {
                SwineBallIntersection.Invoke(this, EventArgs.Empty);
                IsIntersected = true;
            }


        }
        public override void Show()
        {
            brush = Brushes.Aqua;
            Draw(brush);
            if (vx == 0 && vy == 0)
            {
                OutOfSpace?.Invoke(this, EventArgs.Empty);
            }
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
            if (centerX <= LeftSide())
            {
                ToShow = false;
                OutOfSpace?.Invoke(this, EventArgs.Empty);
            }
            if (centerX >= RightSide())
            {
                ToShow = false;
                OutOfSpace?.Invoke(this, EventArgs.Empty);
                CreateNewSwine?.Invoke(this, EventArgs.Empty);
            }
            if (centerY >= DownSide())
            {
                vx = (float)(vx * 0.5);
                vy = -(float)(vy * 0.5);
                if (vx < 0.5 && vy < 0.5)
                {
                    vx = 0;
                    vy = 0;
                    ToShow = false;
                    if (IsIntersected)
                    {
                        CreateNewSwine?.Invoke(this, EventArgs.Empty);

                    }
                }
            }
            if (centerY <= TopSide())
            {
                ToShow = false;
                OutOfSpace?.Invoke(this, EventArgs.Empty);
            }
            if (vx == 0 && vy == 0)
            {
                OutOfSpace?.Invoke(this, EventArgs.Empty);
            }
        }
    }
}
