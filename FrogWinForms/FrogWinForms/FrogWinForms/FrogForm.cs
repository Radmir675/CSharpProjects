using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace FrogWinForms
{
    public partial class FrogForm : Form
    {
        private readonly int middlePositionX = 450;
        private readonly int boundaryRightPointXToWin = 560;
        private readonly int minMoveCount = 24;
        List<PictureBox> leftPictures;
        public FrogForm()
        {
            InitializeComponent();
            leftPictures = new List<PictureBox>(4) { leftPictureBox1, leftPictureBox2, leftPictureBox3, leftPictureBox4 };
        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {
            Swap((PictureBox)sender);
        }
        private void Swap(PictureBox clickedPicture)
        {
            var distance = Math.Abs(clickedPicture.Location.X - emptyPictureBox.Location.X) / emptyPictureBox.Size.Width;
            if (distance > 2)
            {
                MessageBox.Show("Так нельзя!");
            }
            else
            {

                var location = clickedPicture.Location;
                clickedPicture.Location = emptyPictureBox.Location;
                emptyPictureBox.Location = location;
                stepCountLabel.Text = (Convert.ToInt32(stepCountLabel.Text) + 1).ToString();
                CheckEndGame();
            }
        }
        public void CheckEndGame()
        {
            bool finishPostions = leftPictures.All(x => x.Location.X >= boundaryRightPointXToWin) && emptyPictureBox.Location.X == middlePositionX;
            if (finishPostions && Convert.ToInt32(stepCountLabel.Text)==minMoveCount)
            {
                MessageBox.Show("Ура, вы выйграли за минимальное число ходов");
                Application.Restart();
            }
            if (finishPostions)
            {
                MessageBox.Show("Ура, вы выйграли не за минимальное число ходов");
                Application.Restart();
            }
        }
    }
}
