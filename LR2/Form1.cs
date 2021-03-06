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
            
            int x1 = Convert.ToInt32(textBox1.Text);
            int x2 = Convert.ToInt32(textBox2.Text);
            int r = x1 + x2;
            textBox3.Text = Convert.ToString(r);
            label4.Text = "Сложение";
        }

        private void button2_Click(object sender, EventArgs e)   // вычитание
        {
            int x1 = Convert.ToInt32(textBox1.Text);
            int x2 = Convert.ToInt32(textBox2.Text);
            int r = x1 - x2;
            textBox3.Text = Convert.ToString(r);
            label4.Text = "Вычитание";
        }

        private void button3_Click(object sender, EventArgs e)   // умножение
        {
            int x1 = Convert.ToInt32(textBox1.Text);
            int x2 = Convert.ToInt32(textBox2.Text);
            int r = x1 * x2;
            textBox3.Text = Convert.ToString(r);
            label4.Text = "Умножение";
        }

        private void button4_Click(object sender, EventArgs e)   // деление
        {
            int x1 = Convert.ToInt32(textBox1.Text);
            int x2 = Convert.ToInt32(textBox2.Text);
            if (x2 != 0)
            {
                int r = x1 / x2;
                textBox3.Text = Convert.ToString(r);
                label4.Text = "Деление";
            }
            else textBox3.Text = "Выход за область допустимых значений";
        }
    }
}
