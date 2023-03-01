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

namespace Calculation
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(textBox1.Text);
            double c = Convert.ToDouble(textBox2.Text);
            double d = Convert.ToDouble(textBox3.Text);
            double x = Convert.ToDouble(textBox4.Text);
            double r = Sqrt((c - d * Pow(x, 2)) / x) + ((Log10(Pow(x, 2) + c)) / 0.7 * x + a * d) - (Pow(10, -2) / (c - d * Pow(x, 3)));
            listBox1.Items.Add($"r = {r}");
        }
    }
}
