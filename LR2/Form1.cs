using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LR2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Focus();
        }

        private void button1_Click(object sender, EventArgs e)   // сложение
        {
            
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);
            double r = x1 + x2;
            textBox3.Text = Convert.ToString(r);
            label4.Text = "Сложение";
        }

        private void button2_Click(object sender, EventArgs e)   // вычитание
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);
            double r = x1 - x2;
            textBox3.Text = Convert.ToString(r);
            label4.Text = "Вычитание";
        }

        private void button3_Click(object sender, EventArgs e)   // умножение
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);
            double r = x1 * x2;
            textBox3.Text = Convert.ToString(r);
            label4.Text = "Умножение";
        }

        private void button4_Click(object sender, EventArgs e)   // деление
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double x2 = Convert.ToDouble(textBox2.Text);
            if (x2 != 0)
            {
                double r = x1 / x2;
                textBox3.Text = Convert.ToString(r);
                label4.Text = "Деление";
            }
            else textBox3.Text = "Выход за область допустимых значений";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            double x1 = Convert.ToDouble(textBox1.Text);
            double koren = Math.Sqrt(x1);
            textBox3.Text = Convert.ToString(koren);
            label4.Text = "Корень";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
        }
    }
}
