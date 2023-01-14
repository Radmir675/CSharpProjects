namespace BallGamesWinFormsApp
{
    public class RandomSizePointBall:RandomPointBall 
    {
        public RandomSizePointBall(MainForm mainForm):base(mainForm)
        {
            size = random.Next(10, 55);
        }
    }

}
