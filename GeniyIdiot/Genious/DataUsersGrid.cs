using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Progect_Library;
namespace Genious
{
    public partial class DataUsersGrid : Form
    {
        public DataUsersGrid()
        {
            InitializeComponent();
        }

        private void DataUsersGrid_Load(object sender, EventArgs e)
        {
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Имя пользователя" );
            dataTable.Columns.Add("Диагноз", typeof(string));
            var AllUsers = new UsersStorage().GetUsers();
            foreach (var item in AllUsers)
            {
                dataTable.Rows.Add(item.Name, item.Diagnosis);
            }
           
            dataGridUsers.DataSource = dataTable;
        }

        
    }
}
