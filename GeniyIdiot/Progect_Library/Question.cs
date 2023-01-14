using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Progect_Library
{
    public class Question
    {
        public string Text;
        public int Answer;


        public Question(string text, int answer = 0)
        {
            Text = text;
            Answer = answer;
        }
    }
}
