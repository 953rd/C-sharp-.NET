using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Math;

namespace Step
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x0 = Convert.ToDouble(textBox1.Text);
            double xk = Convert.ToDouble(textBox2.Text);
            double dx = Convert.ToDouble(textBox3.Text);
            double a = Convert.ToDouble(textBox4.Text);
            double y;
            while (x0 <= xk)
            {
                y = a + Pow(x0, 0.66) * Cos(x0 + Exp(x0));
                listBox1.Items.Add($"x = {x0}; y = {y}");
                x0 = Round(x0, 2);
                x0 += dx;
            }
        }
    }
}
