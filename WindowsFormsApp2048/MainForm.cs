using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2048
{
    public partial class MainForm : Form
    {
        private Label[,] labelsMap;
        string UserName;
         int mapSize = 0;
        private static Random random = new Random();
        private int score = 0;
        private int bestGameScore = Properties.Settings.Default.InternalIntScore;
        Random randome=new Random();
        
       
        public MainForm(string UserName, int FieldSize )
        {
            InitializeComponent();
            mapSize = FieldSize;
            this.UserName = UserName;
            bestScore.Text = Properties.Settings.Default.InternalIntScore.ToString();
        }
     
        public void CheckBestScore() 
        {
            if (score>bestGameScore)
            {
                bestGameScore = score;
                bestScore.Text = bestGameScore.ToString();
            }
            Properties.Settings.Default.InternalIntScore = score ;
            Properties.Settings.Default.Save();
        }
        private void EndGame()
        {
            MessageBox.Show("Игра окончена");

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            bestScore.Text = bestGameScore.ToString();
            InitializeMap();
            GenerateNumbers();
            ShowScore();
        }

        
        private void ShowScore()
        {
            scoreLabel.Text = score.ToString();
        }
        public bool FindEmptyPlace()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        return true;
                    }


                }
            }
            return false;
        }
        private void InitializeMap()
        {
            labelsMap = new Label[mapSize, mapSize];

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    var newLabel = CreateLabel(i, j);
                    Controls.Add(newLabel);
                    labelsMap[i, j] = newLabel;
                }
            }
        }

        private int GenerateRandomeNumber()
        {
            var rundomNumber = random.Next(1, 100);
            if (rundomNumber <= 75)
            {
                return 2;
            }
            else return 4;

        }
        private void GenerateNumbers()
        {
                
            while (true)
            {
                var randomeNumberLabel = random.Next(mapSize * mapSize);
                var indexRow = randomeNumberLabel / mapSize;
                var indexColumn = randomeNumberLabel % mapSize;
                if (labelsMap[indexRow, indexColumn].Text == string.Empty)
                {
                    int randomNumber= GenerateRandomeNumber();
                    labelsMap[indexRow, indexColumn].Text = randomNumber.ToString();
                    labelsMap[indexRow, indexColumn].BackColor = GetColor(randomNumber.ToString()) ;
                    break;
                }
            }
        }

        private Label CreateLabel(int indexRow, int indexColumn)
        {
            var label = new Label();
            label.Anchor = AnchorStyles.None;
            label.BackColor = GetColor("");
            label.Font = new Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            label.ForeColor = Color.DarkBlue;
            label.Size = new Size(60, 60);
            label.Anchor = (AnchorStyles.Top | AnchorStyles.Left);
            label.TextAlign = ContentAlignment.MiddleCenter;

            int x = 20 + indexColumn * 66;
            int y = 50 + indexRow * 66;
            label.Location = new Point(x, y);
            label.TextChanged += Label_TextChanged;
            return label;
        }

        private void Label_TextChanged(object sender, EventArgs e)
        {
            var label = (Label)sender;
            label.BackColor=GetColor(label.Text);

        }

        private static Color GetColor(string number)
        {
            switch (number)
            {
                case "": return Color.FromArgb(205,193,108);
                case "2": return Color.FromArgb(238, 228, 218); 
                case "4": return Color.Cyan; 
                case "8": return Color.LawnGreen; 
                case "16": return Color.DarkRed; 
                case "32": return Color.LightSalmon;

            }
                    return Color.Blue;
        }

        private void MainForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode!=Keys.Right && e.KeyCode != Keys.Left && e.KeyCode != Keys.Up && e.KeyCode != Keys.Down )
            {
                return;
            }
            if (e.KeyCode == Keys.Right)
            {
                MoveRight();
            }
            if (e.KeyCode == Keys.Left)
            {
                MoveLeft();
            }
            if (e.KeyCode == Keys.Up)
            {
                MoveUp();
            }
            if (e.KeyCode == Keys.Down)
            {
                MoveDown();
            }


            if (FindEmptyPlace())
            {
                CheckBestScore();
                GenerateNumbers();
                ShowScore();
            }
            else
                EndGame();
        }

        private void MoveDown()
        {
            for (int j = 0; j < mapSize; j++)
            {

                for (int i = mapSize - 1; i >= 0; i--)
                {


                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {

                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }

                }

            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = mapSize - 1; i >= 0; i--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i - 1; k >= 0; k--)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;

                                break;
                            }
                        }
                    }

                }
            }
        }

        private void MoveUp()
        {
            for (int j = 0; j < mapSize; j++)
            {

                for (int i = 0; i < mapSize; i++)
                {


                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {

                                if (labelsMap[i, j].Text == labelsMap[k, j].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[k, j].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }

                }

            }

            for (int j = 0; j < mapSize; j++)
            {
                for (int i = 0; i < mapSize; i++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = i + 1; k < mapSize; k++)
                        {
                            if (labelsMap[k, j].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[k, j].Text;
                                labelsMap[k, j].Text = string.Empty;

                                break;
                            }
                        }
                    }

                }
            }
        }

        private void MoveLeft()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {

                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }

                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = 0; j < mapSize; j++)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j + 1; k < mapSize; k++)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;

                                break;
                            }
                        }
                    }

                }
            }
        }

        private void MoveRight()
        {
            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text != string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {

                                if (labelsMap[i, j].Text == labelsMap[i, k].Text)
                                {
                                    var number = int.Parse(labelsMap[i, j].Text);
                                    score += number * 2;
                                    labelsMap[i, j].Text = (number * 2).ToString();
                                    labelsMap[i, k].Text = string.Empty;
                                }
                                break;
                            }
                        }
                    }

                }
            }

            for (int i = 0; i < mapSize; i++)
            {
                for (int j = mapSize - 1; j >= 0; j--)
                {
                    if (labelsMap[i, j].Text == string.Empty)
                    {
                        for (int k = j - 1; k >= 0; k--)
                        {
                            if (labelsMap[i, k].Text != string.Empty)
                            {
                                labelsMap[i, j].Text = labelsMap[i, k].Text;
                                labelsMap[i, k].Text = string.Empty;

                                break;
                            }
                        }
                    }

                }
            }
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void GameRules_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Перемещайте клавишами цифры и достигните максимального результата! ");
        }

        private void RestartButton_Click(object sender, EventArgs e)
        {
            Application.Restart();
            
        }

        private void EightSection_Click(object sender, EventArgs e)
        {
            mapSize = 8;
        }
    }
}




