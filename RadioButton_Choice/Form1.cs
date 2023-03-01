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

namespace RadioButton_Choice
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double y = Convert.ToDouble(textBox2.Text);
            double z = Convert.ToDouble(textBox3.Text);
            double r = 0;
            if (radioButton1.Checked)
            {
                r = Max(Min((Exp(2) - Exp(-2)) / 2, y), z);
                listBox1.Items.Add($"r = {r}");
            }
            if (radioButton2.Checked)
            {
                r = Max(Min(Pow(x, 2), y), z);
                listBox1.Items.Add($"r = {r}");
            }
            if (radioButton3.Checked)
            {
                r = Max(Min(Exp(x), y), z);
                listBox1.Items.Add($"r = {r}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
