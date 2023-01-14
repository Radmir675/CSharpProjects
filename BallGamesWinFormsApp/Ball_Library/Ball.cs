using System;
using System.Drawing;
using System.Windows.Forms;

namespace Ball_Library
{
    public class Ball
    {
        public Form form;
        private Timer timer;
        protected float centerX = 150;
        protected float centerY = 150;
        protected int radius=25;
        public float vx = 1;
        public float vy = 1;
        protected RectangleF area;
        protected RectangleF rectangle;
        private Graphics graphics;
        protected Brush brush;
        

        public Ball(Form mainform)
        {
            form = mainform;
            area = new Rectangle(new Point(0, 0), form.ClientSize);
            timer = new Timer();
            timer.Interval = 20;
            timer.Tick += Timer_Tick;
        }
        private void Timer_Tick(object sender, EventArgs e)
        {
            Move();
        }

        public virtual void Show()
        {
           brush = Brushes.Aqua;
            Draw(brush);
        }
        

        public bool ContainMouse(int X, int Y)
        {
            var dx = X - centerX;
            var dy = Y - centerY;
           
            return dx*dx + dy*dy <= radius * radius;

        
        }
        public void Start()
        {
            timer.Start();
        }
        public void Stop()
        {
            timer.Stop();
        }

        public bool ContainBall()
        {
            var isInterior = area.Contains(rectangle);
            return isInterior;
        }
        
        protected virtual void Go()
        {
            centerX += vx;
            centerY += vy;
            
        }
        public void Clear()
        {
            
            var brush = new SolidBrush(form.BackColor);
            Draw(brush);
            
        }
        public virtual void Move()
        {
            Clear();
            Go();
            Show();
        }
        protected void  Draw (Brush brush)
        {
            graphics = form.CreateGraphics();
            rectangle = new RectangleF(centerX - radius, centerY - radius, 2 * radius, 2 * radius);            
            graphics.FillEllipse(brush, rectangle);

        }
        public int LeftSide() 
        {
            return  radius;
        }
        public int RightSide()
        {
            return form.ClientSize.Width - radius;
        }
        public int TopSide()
        {
            return radius;
        }
        public int DownSide()
        {
            return form.ClientSize.Height - radius;
        }
        public int HalfSide()
        {
            return form.ClientSize.Width/2;
        }
    }

}
