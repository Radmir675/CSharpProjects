using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fruit_NinjaWinFormsApp
{
    class YellowBall : SnippedBall
    {
        public YellowBall(Form form, int velocity, float gravitation) : base(form)
        {
            vy = velocity;
            g = gravitation;
        }
    }
}
