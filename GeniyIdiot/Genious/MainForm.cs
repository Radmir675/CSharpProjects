using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Progect_Library;
namespace Genious
{
    public partial class MainForm : Form
    {
       
        int currentQuestionNumber = 0;
        public List<string> questions;
        QuestionStorage questionStorage;
        User user;
        QuestionsHandler counter;
        int totalQuestions;
        UsersStorage usersStorage = new UsersStorage();
       
        int i = 10;
        public MainForm()
        {
            InitializeComponent();
        }



        public string ShowNextQuestion()
        {
            currentQuestionNumber += 1;
            return $"Вопрос  №{currentQuestionNumber}";
        }
        public static int[] GetRandomArray(int countQuestions)
        {

            Random random = new Random();

            var numsForRandom = Enumerable.Range(0, countQuestions);

            var randomDate = numsForRandom.OrderBy(n => random.Next()).ToArray();

            return randomDate;
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            questionStorage = new QuestionStorage();
            
            totalQuestions = questionStorage.GetAll().Count();
           
            counter = new QuestionsHandler(totalQuestions);

            questionText.Text = ShowNextQuestion();
            TextQuestion.Text = counter.GetPresentQuestion();
            UserName inputName = new UserName();
            inputName.UserNameEntered += InputName_UserNameEntered;
            inputName.UserNameEntered += StartTimermy;
            inputName.ShowDialog();
            
        
           
            
        }

        private void StartTimermy(object sender, string e)
        {
            Timer.Start();
        }

        private void InputName_UserNameEntered(object sender, string e)
        {
            user = new User(e);
        }

        public void FinishGame()
        {
            user.Diagnosis = Diagnose.GetDiagnosis(user.CorrectAnswers);
            usersStorage.ToSave(user);
            DialogResult dialogResult = MessageBox.Show($"Вы прошли тест.\nКоличество правильных ответов " +
                $"равно {user.CorrectAnswers}. \nПоздравляем, ваш диагноз {user.Diagnosis}! \n" +
                " Хотите повторить тест", "Отчет по игре", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Application.Restart();
            }
            else this.Close();
        }
        private void nextButton_Click(object sender, EventArgs e)
        {
            AnswerBox.Focus();
            {

                int rightAnswer = counter.GetPresentAnswer();
                if (int.TryParse(AnswerBox.Text, out int currentAnswer))
                {
                    Timer.Stop();
                   
                    if (currentAnswer == rightAnswer)
                        user.CorrectAnswers++;
                    AnswerBox.Text = string.Empty;

                    if (currentQuestionNumber == totalQuestions)
                    {
                        FinishGame();
                        return;

                    }
                    TextQuestion.Text = counter.GetPresentQuestion();

                    questionText.Text = ShowNextQuestion();
                    Timer.Start();
                }
                else
                {
                    MessageBox.Show("Введите корректное число");
                    AnswerBox.Text = string.Empty;

                }
            }

        }

        private void ShowResultsUsers_Click(object sender, EventArgs e)
        {
            DataUsersGrid dataUsersGrid = new DataUsersGrid();
            dataUsersGrid.Show();
        }

        private void ExitClick_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RepeatGame_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void nextButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                nextButton.PerformClick();

        }

        private void ShowQuestionsStorage_Click(object sender, EventArgs e)
        {
            QuestionsReview questionsReview = new QuestionsReview();
            questionsReview.ShowDialog();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            i--;

            LeftTime.Text = i.ToString();
            if (i == 0) 
            {
               
                Timer.Stop();
                MessageBox.Show("Время вышло");
                i = 10;
                questionText.Text = ShowNextQuestion();
                TextQuestion.Text = counter.GetPresentQuestion();
                Timer.Start();
            }
        }

       
    }
}
