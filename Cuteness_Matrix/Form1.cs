using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cuteness_Matrix
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            label4.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int n = Convert.ToInt32(textBox1.Text);
            int m = Convert.ToInt32(textBox2.Text);
            int check = 0;
            dataGridView1.RowCount = n;
            dataGridView1.ColumnCount = m;
            int[,] Matrix = new int[n, m];
            Random rand = new Random();
            

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Matrix[i, j] = rand.Next(0, 2);
                }
            }

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    dataGridView1.Columns[i].Width = 40;
                    dataGridView1.Rows[i].Cells[j].Value = Matrix[i, j].ToString();
                }
            }

            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < m - 1; j++)
                {
                    if (check == 1)
                    {
                        break;
                    }

                    if (Matrix[i, j] + Matrix[i, j + 1] + Matrix[i + 1, j] + Matrix[i + 1, j + 1] == 0 || Matrix[i, j]
                        + Matrix[i, j + 1] + Matrix[i + 1, j] + Matrix[i + 1, j + 1] == 4)
                    {
                        label4.Text = "Матрица не симпатична";
                        dataGridView1.Rows[i].Cells[j].Style.BackColor = Color.LightPink;
                        dataGridView1.Rows[i + 1].Cells[j].Style.BackColor = Color.LightPink;
                        dataGridView1.Rows[i].Cells[j + 1].Style.BackColor = Color.LightPink;
                        dataGridView1.Rows[i + 1].Cells[j + 1].Style.BackColor = Color.LightPink;
                        check = 1;
                    }
                    else
                    {
                        label4.Text = "Матрица симпатична";
                    }
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
        }
    }
}
