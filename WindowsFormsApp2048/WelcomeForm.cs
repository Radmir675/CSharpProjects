using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2048
{
    public partial class Welcome : Form
    {
        private int SizeFiled = 0;
        private string UserName = "Неизвестно";
        public Welcome()
        {
            InitializeComponent();
        }

        private void UserNameTextBox_MouseClick(object sender, MouseEventArgs e)
        {
            UserNameTextBox.Clear();
            UserNameTextBox.ForeColor = SystemColors.ControlText;
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            pictureBox1.BorderStyle = BorderStyle.FixedSingle;
            SizeFiled = 4;
            pictureBox2.BorderStyle = BorderStyle.None;
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

            pictureBox2.BorderStyle = BorderStyle.FixedSingle;
            SizeFiled = 6;
            pictureBox1.BorderStyle = BorderStyle.None;
        }

        private void ОК_button_Click(object sender, EventArgs e)
        {
            if (UserNameTextBox.Text!= "Неизвестно" && (pictureBox1.BorderStyle == BorderStyle.FixedSingle || pictureBox2.BorderStyle == BorderStyle.FixedSingle))
            {
                UserName = UserNameTextBox.Text;
                MainForm mainForm = new MainForm(UserName, SizeFiled);
                this.Hide();
                mainForm.Show();
                mainForm.Closed += (s, args) => this.Close();

            }
            else MessageBox.Show("Выбрете картинку и заполните имя","Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
      
        
    }
}
