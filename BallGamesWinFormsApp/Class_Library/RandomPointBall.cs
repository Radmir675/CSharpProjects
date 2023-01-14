using Class_Library;
using System;

namespace BallGamesWinFormsApp
{
    public class RandomPointBall : Ball
    {
        protected static Random random = new Random();

        public RandomPointBall(MainForm main) : base(main)
        {

             x = random.Next(0, main.ClientSize.Width);
             y = random.Next(0, main.ClientSize.Height);


        }

    }

}
