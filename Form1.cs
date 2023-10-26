using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab7
{
    public partial class Form1 : Form
    {
        public double val_x = 0.0;

        public Form1()
        {
            InitializeComponent();
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            double x_inicial = 0.1;
            double x_final = 1.0;
            val_x = x_inicial;
            int cont = 0;
            while (val_x <= x_final)
            {
                cont = 0;
                label4.Text += "\n" + val_x;
                label5.Text += "\n" + Convert.ToString(func_y(cont));
                label6.Text += "\n" + Convert.ToString(func_y(cont+1));

                val_x += xn(x_inicial, x_final);
            }

        }
        private double func_s(int cont)
        {
            if (cont >= 10) return 0.0;
            else return ((2.0 * cont + 1) / factorial(cont)) * Math.Pow(val_x, 2 * cont) + func_s(cont + 1);
        }
        private double func_y(int cont)
        {
            if (cont >= 10) return 0.0;
            else return (2.0 * Convert.ToDouble(cont + 1) / Convert.ToDouble(factorial(cont))) *Convert.ToDouble( Math.Pow(val_x,2.0 * cont))*10+ func_s((cont + 1));
        }
        private double xn(double x1, double x2)
        {
            return Math.Abs((x2 - x1) / 10);
        }
        private int factorial(int n)
        {
            if (n <= 1) return n;
            else return n *= factorial(n - 1);
        }
    }
}
