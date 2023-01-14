using System;
using System.Windows.Forms;
using System.Linq;
namespace Genious
{
    public partial class UserName : Form
    {
        public event EventHandler<string> UserNameEntered;
     
        public UserName()
        {
            InitializeComponent();
            TopMost = true;
        }

        private void AcceptName_Click(object sender, EventArgs e)
        {
            if (NameInput.Text == string.Empty || !NameInput.Text.All(input => char.IsLetter(input)))
            {
                errorProviderName.SetError(NameInput,"Некорректный ввод данных");
            }
            else
            {
                errorProviderName.Clear();
                string Name = NameInput.Text;
                UserNameEntered.Invoke(this, Name);
                this.Close();

            }

        }

        private void NameInput_TextChanged(object sender, EventArgs e)
        {
            if (NameInput.Text != string.Empty & NameInput.Text.All(input=>char.IsLetter(input)))
            {
                errorProviderName.Clear();
            }
        }
    }
}
