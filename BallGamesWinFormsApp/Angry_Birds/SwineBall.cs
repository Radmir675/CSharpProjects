using Ball_Library;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Angry_Birds
{
    class SwineBall:Ball
    {
         public static RectangleF swineArea;
        public SwineBall(Form form):base(form)
        {
            brush =Brushes.Pink;
            radius = 40;
            centerX = 500;
            centerY = DownSide();
        }
        public override void Show()
        {
            Draw(brush);
            swineArea = rectangle;

        }

    }
}
