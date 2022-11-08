using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp6
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void noButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Шкода :(", "начальство");
        }

        private void yesButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ми знали що вас задовільняє ваша зарплата", "начальство");
        }

        private void noButton_MouseMove(object sender, MouseEventArgs e)
        {
            Text = $"{noButton.Top} {noButton.Left}---{e.X}  {e.Y}";
            noButton.Top -= e.Y;
            noButton.Left += e.X;
            if (noButton.Top < 200 || noButton.Top > 350)
            {
                noButton.Top = 300;
            }
            if (noButton.Left < -80 || noButton.Left > 450)
            {
                noButton.Left = 308;
            }
        }

        private void question1_Click(object sender, EventArgs e)
        {

        }
    }
}
