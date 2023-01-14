using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Class_Library
{
    public class Ball
    {
        private MainForm form;
        protected int x = 150;
        protected int y = 150;
        protected int size = 65;
        protected int vx = 1;
        protected int vy = 1;
        private Rectangle area;
        private Rectangle rectangle;
        private Graphics graphics;

        public Ball(MainForm mainform)
        {
            form = mainform;
            var formSize = form.ClientSize;
            area = new Rectangle(new Point(0, 0), formSize);
        }
        public void Show()
        {

            graphics = form.CreateGraphics();
            var brush = Brushes.Aqua;
            rectangle = new Rectangle(x, y, size, size);
            Region region = new Region(rectangle);
            graphics.FillEllipse(brush, rectangle);

        }
        public void Refreshfield()
        {
            graphics.Clear(Color.AliceBlue);
        }


        public bool ContainBall()
        {
            var IsInterior = area.Contains(rectangle);
            return IsInterior;
        }
        private void Go()
        {
            x += vx;
            y += vy;
        }
        private void Clear()
        {
            var graphics = form.CreateGraphics();
            var brush = Brushes.White;
            var rectangle = new Rectangle(x, y, size, size);
            graphics.FillEllipse(brush, rectangle);
        }
        public void Move()
        {
            Clear();
            Go();
            Show();
        }
    }

}
