using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace SnakeWinForms
{
    public partial class MainForm : Form
    {
        List<Snake> snakeParts = new List<Snake>() { };
        Snake snake;
        PictureBox applePictureBox;
        public int vXnew;
        public int vYnew;
        private readonly int appleSize = 40;
        int initialPointX = 210;
        int initialPointY = 170;
        public Direction endDirection;
        public MainForm()
        {
            InitializeComponent();

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

            CreateApple();
            applePictureBox.Show();
            snake = new Snake(this, initialPointX, initialPointY);
            snakeParts.Add(snake);
            snake.CreateSnake();
            this.DoubleBuffered = true;
            moveTimer.Start();//начало игры
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
        }




        private void moveTimer_Tick(object sender, EventArgs e)
        {
            snakeParts.First().Move(vXnew, vYnew);
            
            for (int i = 1; i < snakeParts.Count(); i++)
            {
                snakeParts[i].currentLocation = snakeParts[i-1].LocationOld;
                snakeParts[i].Move();
            }

            if (IsIntersectApple())
            {
                applePictureBox.Hide();
                Random random = new Random();
                applePictureBox.Location = new Point(random.Next(0, ClientSize.Width - appleSize), random.Next(0, ClientSize.Height - appleSize*3));
                applePictureBox.Show();
                currentScoreLabel.Text = (Convert.ToInt32(currentScoreLabel.Text) + 1).ToString();
                var lastSnake = GetLocationToConnect(snakeParts.Last());
                Snake newSnake = new Snake(this, lastSnake.X, lastSnake.Y);
                newSnake.CreateSnake();
                snakeParts.Add(newSnake);
            }
            if (Self_Intersection()|| InsideForm())
            {
                moveTimer.Stop();
                MessageBox.Show("Игра окончена!");
            }

        }
        public Point GetLocationToConnect(Snake snake)
        {

            Point location = snake.currentLocation;
            int locationX;
            int locationY;
            if (snake.GetDirection() == Direction.Down)
            {

                locationX = location.X;
                locationY = location.Y - snake.snakeSize;
                return new Point(locationX, locationY);
            }
            if (snake.GetDirection() == Direction.Up)
            {

                locationX = location.X;
                locationY = location.Y + snake.snakeSize;
                return new Point(locationX, locationY);
            }

            if (snake.GetDirection() == Direction.Left)
            {

                locationX = location.X + snake.snakeSize;
                locationY = location.Y;
                return new Point(locationX, locationY);
            }
            else
            {

                locationX = location.X - snake.snakeSize;
                locationY = location.Y;
                return new Point(locationX, locationY);
            }

        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up)
            {
                vXnew = 0;
                vYnew = -15;
             

            }
            if (e.KeyCode == Keys.Down)
            {
                vXnew = 0;
                vYnew = 15;
              

            }
            if (e.KeyCode == Keys.Right)
            {
                vXnew = 15;
                vYnew = 0;
               

            }
            if (e.KeyCode == Keys.Left)
            {
                vXnew = -15;
                vYnew = 0;

            }


        }
        

        private void CreateApple()
        {
            applePictureBox = new PictureBox();
            Controls.Add(applePictureBox);
            applePictureBox.BackColor = Color.Transparent;
            applePictureBox.Image = Properties.Resources.pngwing_com;
            applePictureBox.Location = new Point(90, 210);
            applePictureBox.Size = new Size(appleSize, appleSize);
            applePictureBox.SizeMode = PictureBoxSizeMode.Zoom;
            

        }

        private bool IsIntersectApple()
        {

            if (snake.snakePictureBox.Bounds.IntersectsWith(applePictureBox.Bounds))
            {
                return true;

            }
            return false;
        }
        private bool Self_Intersection() 
        {
            foreach (var item in snakeParts.Skip(2).ToArray())
            {
                if (snake.snakePictureBox.Bounds.IntersectsWith(item.snakePictureBox.Bounds))
                {
                    return true;
                }
            }
            return false;
            
        }
        private bool InsideForm()
        {
            if (snake.snakePictureBox.Bounds.IntersectsWith(ClientRectangle))
            {
                return false;
            }
            return true;
        }


    }


}

