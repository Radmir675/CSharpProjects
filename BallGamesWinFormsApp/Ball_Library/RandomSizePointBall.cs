using System.Windows.Forms;

namespace Ball_Library
{
    public class RandomSizePointBall : RandomPointBall
    {
        public RandomSizePointBall(Form mainForm) : base(mainForm)
        {
            radius = random.Next(10, 45);
        }
    }

}
