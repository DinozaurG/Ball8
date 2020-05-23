using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ball8
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        double pForEightOne = 0.5;
        double[] possibilites = new double[10] {0.07, 0.05, 0.12, 0.02, 0.08, 0.21, 0.01, 0.10, 0.30, 0.04};
        String[] astrs = new String[10] {"Вы будете счастливы","Вы уснёте","Вы встанете со стула","Вы отмените занятие", "Вы выпьете коньячку", "Вы посмотрите фильм 'Джентльмены'","Вы поставите кому-то 0","Вы выйдете на улицу погулять","Приятного аппетита","Вы погладите кошку"};
        public Form1()
        {
            InitializeComponent();
        }
        private void buttonForAnswer_Click(object sender, EventArgs e)
        {
            if (textBoxForQuestion.Text == "")
            {
                MessageBox.Show("А вопрос где?");
            }
            else
            {
                if(rnd.NextDouble() % 1 >= pForEightOne)
                {
                    labelForAnswer.Text = "Yes!";
                }
                else
                {
                    labelForAnswer.Text = "No!";
                }
            }
        }
        private void buttonForGuess_Click(object sender, EventArgs e)
        {
            double a = rnd.NextDouble() % 1;
            for (double i = 0; i <= 1; i += 0.1)
            {
                if ((a - i) <= 0)
                {
                    labelForNum.Text = (i * 10).ToString();
                    break;
                }
            }
        }
        private void buttonForAstr_Click(object sender, EventArgs e)
        {
            double a = rnd.NextDouble() % 1;
            for (int i = 0; i < 10; i++)
            {
                a -= possibilites[i];
                if (a <= 0)
                {
                    labelForAstr.Text = astrs[i];
                    break;
                }
            }
        }
    }
}
