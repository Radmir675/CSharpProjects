using System;
using System.Windows.Forms;

namespace Ball_Library
{
    public class RandomPointBall : Ball
    {
        protected static Random random = new Random();

        public RandomPointBall(Form main) : base(main)
        {

            centerX = random.Next(LeftSide(), RightSide());
            centerY = random.Next(TopSide(),DownSide());
        }


    }

}
