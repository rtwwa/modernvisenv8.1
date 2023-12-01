using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace modenrvisenv8._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(textBox1.Text, out double a) ||
                !double.TryParse(textBox2.Text, out double b) ||
                !double.TryParse(textBox3.Text, out double c))
            {
                label4.Text = "Пожалуйста, введите корректные числа во все поля.";
                return;
            }

            double valueA = CalculateFunction(a);
            double valueB = CalculateFunction(b);
            double valueC = CalculateFunction(c);

            double minValue = Math.Min(valueA, Math.Min(valueB, valueC));

            string result = "Минимальное значение функции: ";

            if (minValue == valueA)
            {
                result += $"a ({a}) = {Math.Round(minValue, 5)}";
                label4.Text = result;
                return;
            }
            if (minValue == valueB)
            {
                result += $"b ({b}) = {Math.Round(minValue, 5)}";
                label4.Text = result;
                return;
            }

            result += $"c ({c}) = {Math.Round(minValue, 5)}";
            label4.Text = result;
            return;
        }

        private double CalculateFunction(double x)
        {
            return Math.Sin(x) + Math.Cos(2 * x);
        }
    }
}
