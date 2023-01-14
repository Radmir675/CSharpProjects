using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Progect_Library;
namespace Where
{
    public class PrintTable
    {
        static int tableWidth = 73;

        private List<User> persons;
        public PrintTable() 
        {
            persons = new UsersStorage().GetUsers();//ReadAllFromStorage();
        }

        public void PrintAlignM()
        {

            Console.Clear();
            PrintLine();
            PrintRow("ФИО", "Кол-во правильных ответов", "Диагноз");
            PrintLine();
            PrintRow(persons);
            PrintLine();
            

        }

        static void PrintLine()
        {
            Console.WriteLine(new string('-', tableWidth));
        }

        static void PrintRow(params string[] columns)
        {
            int width = (tableWidth - columns.Length) / columns.Length;
            string row = "|";

            foreach (string column in columns)
            {
                row += AlignCentre(column, width) + "|";
            }

            Console.WriteLine(row);
        }
        static void PrintRow(List<User> persons)
        {
            int intersection = 3;
            int width1 = (tableWidth - 3) / 3;

            foreach (var item in persons)
            {
                string row = "|";
                row += AlignCentre(item.Name, width1) + "|";
                row += AlignCentre(item.CorrectAnswers.ToString(), width1) + "|";
                row += AlignCentre(item.Diagnosis, width1) + "|";

                Console.WriteLine(row);
            }

        }

        static string AlignCentre(string text, int width)
        {
            text = text.Length > width ? text.Substring(0, width - 3) + "..." : text;

            if (string.IsNullOrEmpty(text))
            {
                return new string(' ', width);
            }
            else
            {
                return text.PadRight(width - (width - text.Length) / 2).PadLeft(width);
            }
        }

        public void PrintTotalUsers()
        {
            
           
            if (persons.Count == 0)
                Console.WriteLine("Нет пользователей прошедших тест");
            else
               PrintAlignM();

        }
    }
}
