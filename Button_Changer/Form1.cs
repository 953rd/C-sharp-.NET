using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Button_Changer
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.Size = new Size(100, 35);
            button2.Size = new Size(150, 70);
            button3.Size = new Size(150, 70);
            button4.Size = new Size(150, 70);
            button1.Location = new Point(0, 0);
            button2.Location = new Point(624, 0);
            button3.Location = new Point(0, 293);
            button4.Location = new Point(624, 293);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Size = new Size(200, 100);
            button2.Size = new Size(100, 35);
            button3.Size = new Size(200, 100);
            button4.Size = new Size(200, 100);
            button1.Location = new Point(287, 0);
            button2.Location = new Point(674, 171);
            button3.Location = new Point(287, 343);
            button4.Location = new Point(0, 171);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            button1.Size = new Size(250, 150);
            button2.Size = new Size(250, 150);
            button3.Size = new Size(100, 35);
            button4.Size = new Size(250, 150);
            button1.Location = new Point(410, 66);
            button2.Location = new Point(110, 66);
            button3.Location = new Point(167, 238);
            button4.Location = new Point(410, 238);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            button1.Size = new Size(300, 200);
            button2.Size = new Size(300, 200);
            button3.Size = new Size(300, 200);
            button4.Size = new Size(100, 35);
            button1.Location = new Point(65, 230);
            button2.Location = new Point(415, 15);
            button3.Location = new Point(65, 15);
            button4.Location = new Point(415, 230);
        }
    }
}
