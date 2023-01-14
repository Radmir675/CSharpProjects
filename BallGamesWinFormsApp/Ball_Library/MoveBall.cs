using System;
using System.Windows.Forms;
namespace Ball_Library
{
  public  class MoveBall : RandomPointBall
    {
        public MoveBall(Form mainForm) : base(mainForm)
        {
            vx = random.Next(-10, 10);
            vy = random.Next(-10, 10);
            
            
        }
    }
}
