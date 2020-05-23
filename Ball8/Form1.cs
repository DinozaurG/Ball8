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
                if(rnd.NextDouble() % 1 >= 0.5)
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
    }
}
