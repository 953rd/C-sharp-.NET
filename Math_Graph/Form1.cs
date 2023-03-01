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

namespace Math_Graph
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
            int count = (int)Ceiling((xk - x0) / dx) + 1;
            double[] x = new double[count];
            double[] y1 = new double[count];
            double[] y2 = new double[count];

            for (int i = 0; i < count; i++)
            {
                x0 = Round(x0, 2);
                x[i] = x0 + dx * i;
                y1[i] = a + Pow(x[i], 0.66) * Cos(x[i] + Exp(x[i]));
                y2[i] = Tan(x[i]);
            }

            chart1.ChartAreas[0].AxisX.Minimum = x0;
            chart1.ChartAreas[0].AxisX.Maximum = xk;
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = dx;
            chart1.Series[0].Points.DataBindXY(x, y1);
            chart1.Series[1].Points.DataBindXY(x, y2);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
        }
    }
}
