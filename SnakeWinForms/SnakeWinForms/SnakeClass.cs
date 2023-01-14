using System.Drawing;
using System.Windows.Forms;
using static SnakeWinForms.MainForm;

namespace SnakeWinForms
{
    public class Snake
    {
        Form currentForm;
        public PictureBox snakePictureBox;
        public readonly int snakeSize = 30;
        public int vx;
        public int vy;
        Direction direction;
        public Point LocationOld;
        private Point currentLocationinternal;
        public Point currentLocation
        {
            get { return currentLocationinternal; }
            set
            {
                
                if (currentLocationinternal != value)
                {
                    LocationOld.X = currentLocationinternal.X;
                    LocationOld.Y = currentLocationinternal.Y;
                   
                }
                
                    currentLocationinternal.X = value.X;
                    currentLocationinternal.Y = value.Y;
                
            }
        }



        public Snake(Form form, int x, int y)
        {
            currentForm = form;
            currentLocation = new Point(x, y);


        }

        public void Move(int vX, int vY)
        {
            vx = vX;
            vy = vY;
            currentLocation = new Point(currentLocation.X + vx, currentLocation.Y + vy);
            snakePictureBox.Location = currentLocation;
        }
        public void Move()
        {
            snakePictureBox.Location = LocationOld;
        }

        public Direction GetDirection()
        {

            if (vx == 0 && vy > 0)
            {
                direction = Direction.Down;
                return direction;
            }
            if (vx == 0 && vy < 0)
            {
                direction = Direction.Up;
                return direction;
            }
            if (vx > 0 && vy == 0)
            {
                direction = Direction.Right;
                return direction;
            }
            if (vx < 0 && vy == 0)
            {
                direction = Direction.Left;
                return direction;
            }
            return 0;


        }

        public void CreateSnake()
        {
            snakePictureBox = new PictureBox();
            currentForm.Controls.Add(snakePictureBox);
            snakePictureBox.BackgroundImageLayout = ImageLayout.Zoom;
            snakePictureBox.Image = Properties.Resources.Новый_проект;
            snakePictureBox.Location = new Point(currentLocation.X, currentLocation.Y);
            snakePictureBox.Size = new Size(snakeSize, snakeSize);
            snakePictureBox.TabIndex = 0;
            snakePictureBox.TabStop = false;
            snakePictureBox.Visible = true;
            snakePictureBox.Show();
         
        }

    }
}







