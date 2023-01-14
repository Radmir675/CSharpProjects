using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progect_Library;
namespace Genious
{
    public class QuestionsHandler
    {
        public static int quantityOfInvokes;
        int[] randomArray;
        QuestionStorage questionStorage;
        int index;
        public QuestionsHandler(int quantityOfQuestions)
        {
            randomArray = MainForm.GetRandomArray(quantityOfQuestions);
            questionStorage = new QuestionStorage();
        }

        public string GetPresentQuestion()
        {
            index = randomArray[quantityOfInvokes];
            string answersText = questionStorage.GetAll().Select(x => x.Text).ElementAt(index);
            quantityOfInvokes++;

            return answersText;
        }
        public int GetPresentAnswer()
        {

            return questionStorage.GetAll().Select(x => x.Answer).ElementAt(index);

        }

    }
}
