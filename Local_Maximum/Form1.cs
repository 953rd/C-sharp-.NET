using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Local_Maximum
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        int[] GenArray = new int[30];
        List<int> LocMaxList = new List<int>();

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            for (int i = 0; i < GenArray.Length; i++)
            {
                GenArray[i] = rand.Next(-30, 30);
                listView1.Items.Add($"{i + 1}-й элемент массива = {GenArray[i]}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (GenArray[0] > GenArray[1])
            {
                LocMaxList.Add(GenArray[1]);
                listView1.Items[1].BackColor = Color.LightGreen;
            }

            for (int i = 1; i < GenArray.Length - 1; i++)
            {
                if (GenArray[i - 1] < GenArray[i] && GenArray[i] > GenArray[i + 1])
                {
                    LocMaxList.Add(GenArray[i]);
                    listView1.Items[i].BackColor = Color.LightGreen;
                }
            }

            if (GenArray[28] < GenArray[29])
            {
                LocMaxList.Add(GenArray[29]);
                listView1.Items[29].BackColor = Color.LightGreen;
            }

            int[] LocMaxArray = LocMaxList.ToArray();

            for (int i = 0; i < LocMaxArray.Length; i++)
            {
                listView2.Items.Add($"{i + 1}-й локальный максимум = {LocMaxArray[i]}");
            }
        }
    }
}
