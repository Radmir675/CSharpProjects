using System.Linq;

namespace Progect_Library
{
    public class Diagnose
    {
        public static string GetDiagnosis(int amountOfRightAnswers)
        {
            var quantityOfQuestions = new QuestionStorage().GetAll().Count();
            double percentOfRightAnswers = (double)amountOfRightAnswers / quantityOfQuestions;

            if (percentOfRightAnswers == 0)
                return "кретин";
            if (percentOfRightAnswers <= 0.2)
                return "идиот";
            if (percentOfRightAnswers <= 0.4)
                return "дурак";
            if (percentOfRightAnswers <= 0.6)
                return "нормальный";
            if (percentOfRightAnswers <= 0.8)
                return "талант";
            if (percentOfRightAnswers == 1)
                return "гений";
            else
                return "Ошибка";

        }
    }
}
