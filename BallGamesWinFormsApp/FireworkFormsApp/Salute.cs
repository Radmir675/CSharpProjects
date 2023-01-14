using Ball_Library;
using System;
using System.Windows.Forms;

namespace FireworkFormsApp
{
    public class Salute:MoveBall
    {
        private float g = 0.2f;
        public Salute(Form form, float pointX, float pointY):base( form)
        {
            centerX = pointX;
            centerY = pointY;
            vy = -Math.Abs(vy);
            radius = 15;
        }
        protected override void Go()
        {
            base.Go();
            vy += g;
        }
    }
}
