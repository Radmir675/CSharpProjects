using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace Progect_Library
{
    public class QuestionStorage
    {
        private static string pathfile = "scores.json";
        private List<Question> questions = new List<Question>()
        {
            new Question("Сколько будет два плюс два умноженное на два?" ,6  ),
            new Question("Бревно нужно распилить на 10 частей. Сколько распилов нужно сделать?", 9),
            new Question("На двух руках 10 пальцев. Сколько пальцев на 5 руках?",25),
            new Question("Укол делают каждые полчаса. Сколько нужно минут, чтобы сделать три укола?",60),
            new Question("Пять свечей горело, две потухли. Сколько свечей осталось?",2)
        };

        DataStorageJson<Question> data = new DataStorageJson<Question>(pathfile);

        public QuestionStorage()
        {
            
            if (GetAll().Count() == 0)
            {
                data = default;
                data = new DataStorageJson<Question>(pathfile);

                foreach (var item in questions)
                {
                    data.SaveItemToStorage(item);
                }

            }
        }
        public List<Question> GetAll()
        {
            return data.ReadAllFromStorage();
        }

        public void Add(Question question)
        {
            data.SaveItemToStorage(question);

        }
        public void Remove(int questionNumberToRemove)
        {
            
            data.RemovefromStorage(questionNumberToRemove);

        }



    }


}
