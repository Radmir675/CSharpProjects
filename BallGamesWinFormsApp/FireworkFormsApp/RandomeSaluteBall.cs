using Ball_Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FireworkFormsApp
{
    class RandomeSaluteBall : Ball
    {
        Random random = new Random();
        static int randomeAppear;
        public event EventHandler<PositionArgs> DeleteBall;
        Form currentForm;
        float g = 0.5f;
        static RandomeSaluteBall()
        {
            randomeAppear = new Random().Next(10, 500);
        }
        public RandomeSaluteBall(Form form) : base(form)
        {
            currentForm = form;
            vy = -15;
            centerY = 400;
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
            vx = 0;
            centerX = randomeAppear;
      
        }

        public override void Move()
        {
            Clear();
            Go();
            Show();
            if (vy == 0)
            {
                DeleteBall.Invoke(this, new PositionArgs(randomeAppear,centerY));
            }
        }
    }
     public class PositionArgs:EventArgs 
    {
        public float centerX;
        public float centerY;
        public PositionArgs(float centerX, float centerY)
        {
            this.centerX = centerX;
            this.centerY = centerY;
        }
    }
}
