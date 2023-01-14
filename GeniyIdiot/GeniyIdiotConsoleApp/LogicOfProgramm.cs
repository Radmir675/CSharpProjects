using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using System.IO;
using Progect_Library;

namespace Where
{
    class LogicOfProgramm
    {
        public static int[] GetRandomArray(int countQuestions)
        {

            Random random = new Random();

            var numsForRandom = Enumerable.Range(0, countQuestions);

            var randomDate = numsForRandom.OrderBy(n => random.Next()).ToArray();

            return randomDate;
        }


        public static void StartProgramm()
        {
            UsersStorage usersStorage = new UsersStorage();
            QuestionStorage questionStorage = new QuestionStorage();
            //Console.WriteLine("Добавляем вопрос");
            //questionStorage.Add(new Question("Сколько будет два плюс 3",5));

            Console.WriteLine("Хотите ли вы увидеть всех пользователей прошедших тест?");
            var opinion = Console.ReadLine();
            if (opinion.ToLower() == "да")
            {
                PrintTable printtable = new PrintTable();
                printtable.PrintTotalUsers();

            }
            List<string> questions = questionStorage.GetAll().Select(x=>x.Text).ToList();
            int countQuestions = questions.Count();
            List<int> answers = questionStorage.GetAll().Select(x => x.Answer).ToList();

            var crossednum = GetRandomArray(countQuestions);
           
          
            Console.WriteLine("Введите ваше имя");

            string nameofUser = Console.ReadLine();
            var user = new User(nameofUser);
            user.CorrectAnswers = 0;
            int userAnswer = 0;
            for (int i = 0; i < countQuestions; i++)
            {
                Console.WriteLine("Вопрос №" + (i + 1));

                int randomQuestionIndex = crossednum[i];

                Console.WriteLine(questions[randomQuestionIndex]);

                do
                {
                    bool correctOfparcing = int.TryParse(Console.ReadLine(), out userAnswer);
                    if (correctOfparcing)
                    {
                        break;
                    }
                    else Console.WriteLine("Пожалуйста введите число");

                } while (true);



                int rightAnswer = answers[randomQuestionIndex];

                if (userAnswer == rightAnswer)
                {
                    user.CorrectAnswers++;
                }
            }

            Console.WriteLine("Количество правильных ответов: " + user.CorrectAnswers);
            user.Diagnosis = Diagnose.GetDiagnosis(user.CorrectAnswers);

            Console.WriteLine($"{user.Name}, ваш диагноз:" +user.Diagnosis ); ;

            usersStorage.ToSave(user);//SaveUsersToStorage(user);


            Console.WriteLine("Хотите ли вы пройти тест снова?");


            string reply = Console.ReadLine();

            if (reply.ToLower() == "да")
            {
                StartProgramm();
            }

            else Environment.Exit(0);

        }



        static void Main()
        {

            StartProgramm();

        }
    }


}
