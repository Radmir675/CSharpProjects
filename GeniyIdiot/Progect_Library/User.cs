using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progect_Library
{
    public class User
    {
        public string Name;
        public int CorrectAnswers = 0;
        public string Diagnosis = string.Empty;
        public User(string name)
        {
            Name = name;

        }
    }
}
