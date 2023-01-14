using System;
using System.Data;
using System.Windows.Forms;
using Progect_Library;
namespace Genious
{
    public partial class QuestionsReview : Form
    {
        int rowSelectedIndex;
        DataTable questionsTable;
        QuestionStorage questionStorage;
        public QuestionsReview()
        {
            InitializeComponent();
        }
        public void UpdateGrid() 
        {
            questionsTable.Clear();
            var updatedTable= questionStorage.GetAll();
            foreach (var item in updatedTable)
            {
                questionsTable.Rows.Add(updatedTable.IndexOf(item) + 1, item.Text, item.Answer);
            }
            QuestionsList.DataSource = questionsTable;

        }
        private void QuestionsReview_Load(object sender, EventArgs e)
        {
             questionsTable = new DataTable();
            questionsTable.Columns.Add("№");
            questionsTable.Columns.Add("Ответ на вопрос");
            questionsTable.Columns.Add("Название вопроса");

             questionStorage = new QuestionStorage();
            var total_questions=questionStorage.GetAll();
            
            foreach (var item in total_questions)
            {
                questionsTable.Rows.Add(total_questions.IndexOf(item)+1, item.Text, item.Answer);
            }
            QuestionsList.DataSource = questionsTable;
            
        }

        private void QuestionsList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            rowSelectedIndex = e.RowIndex;
            
        }

        private void RemoveQuestion_Click(object sender, EventArgs e)
        {
            QuestionStorage questionStorage = new QuestionStorage();
            questionStorage.Remove(rowSelectedIndex);
            UpdateGrid();

        }

        private void RefreshTable_Click(object sender, EventArgs e)
        {

            UpdateGrid();
            this.Refresh();
           



        }
    }
}
