using System.Windows.Forms;

namespace Ball_Library
{
    public class PointBall : Ball
    {
        public PointBall(Form main, int x, int y) : base(main)
        {
            this.centerX = x;
            this.centerY = y;
        }

    }

}
