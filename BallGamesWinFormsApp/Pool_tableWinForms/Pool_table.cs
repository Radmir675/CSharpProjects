using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ball_Library;

namespace Pool_tableWinForms
{
    public partial class Pool_table : Form
    {
        public Pool_table()
        {
            InitializeComponent();
        }



        private void Pool_table_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                var ball = new BilliardBall(this);
                ball.OnHitted += Ball_OnHitted;
                ball.Start();

            }


        }

        private void Ball_OnHitted(object sender, HitEventArgs e)
        {
            switch (e.Side)
            {
                case Side.Left:
                    Leftlabel.Text = (Convert.ToInt32(Leftlabel.Text) + 1).ToString();
                    break;
                case Side.Right:
                    Rightlabel.Text = (Convert.ToInt32(Rightlabel.Text) + 1).ToString();
                    break;
                case Side.Top:
                    Toplabel.Text = (Convert.ToInt32(Toplabel.Text) + 1).ToString();
                    break;
                case Side.Down:
                    Downlabel.Text = (Convert.ToInt32(Downlabel.Text) + 1).ToString();
                    break;
                default:
                    break;
            }
        }
    }
}
