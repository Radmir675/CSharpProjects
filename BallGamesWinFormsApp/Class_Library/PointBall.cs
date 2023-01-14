using Class_Library;

namespace BallGamesWinFormsApp
{
    public class PointBall:Ball
    {
        public PointBall(MainForm main, int x, int y) : base(main)
        {
           this.x=x;
           this.y=y;
        }
        
    }

}
