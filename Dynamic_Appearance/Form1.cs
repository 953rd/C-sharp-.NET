using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dynamic_Appearance
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int x = 20;
        int y = 20;

        private void Panel1_MouseClick(object sender, MouseEventArgs e)
        {

            if ((x + 75 > panel1.Width) || (x + 100 > panel1.Width))
            {
                x = 20;
                y += 20;
            }

            if ((y + 20 > panel1.Height) || (y + 23 > panel1.Height))
            {
                x = 20;
                y = 20;
                panel1.Controls.Clear();
            }

            if (e.Button == MouseButtons.Left)
            {
                TextBox textbox = new TextBox();
                textbox.Location = new Point(x, y);

                panel1.Controls.Add(textbox);
                x += 100;
                y += 20;
            }

            if (e.Button == MouseButtons.Right)
            {
                Button button = new Button();
                button.Location = new Point(x, y);

                panel1.Controls.Add(button);


                x += 75;
                y += 23;
            }
        }

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
        }
    }
}
