using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Abstraction_Picture
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            SolidBrush SB = new SolidBrush(Color.Purple);
            this.BackColor = Color.Cyan;
            Point point1 = new Point(0, 0);
            Point point2 = new Point(408, 0);
            Point point3 = new Point(204, 245);
            Point[] Triangle1Points = { point1, point2, point3 };
            g.FillPolygon(SB, Triangle1Points);
            SB = new SolidBrush(Color.Yellow);
            Point point4 = new Point(508, 0);
            Point point5 = new Point(1016, 0);
            Point point6 = new Point(588, 345);
            Point[] Triangle2Points = { point4, point5, point6 };
            g.FillPolygon(SB, Triangle2Points);
            Point point7 = new Point(0, 300);
            Point point8 = new Point(200, 290);
            Point point9 = new Point(0, 489);
            Point[] Triangle3Points = { point7, point8, point9 };
            g.FillPolygon(SB, Triangle3Points);
            SB = new SolidBrush(Color.White);
            Point point10 = new Point(130, 489);
            Point point11 = new Point(260, 290);
            Point point12 = new Point(590, 390);
            Point point13 = new Point(605, 489);
            Point[] TrapezoidPoints = { point10, point11, point12, point13 };
            g.FillPolygon(SB, TrapezoidPoints);
            SB = new SolidBrush(Color.Red);
            g.FillRectangle(SB, 50, 100, 230, 230);
            Point point14 = new Point(530, 100);
            Point point15 = new Point(892, 100);
            Point point16 = new Point(588, 420);
            Point[] Triangle4Points = { point14, point15, point16 };
            g.FillPolygon(SB, Triangle4Points);
            Rectangle rect = new Rectangle(107, 30, 173, 173);
            g.FillEllipse(SB, rect);
            Pen P = new Pen(Color.White, 25);
            g.DrawEllipse(P, rect);
            SB = new SolidBrush(Color.LightGreen);
            g.FillRectangle(SB, 74, 150, 125, 125);
            SB = new SolidBrush(Color.Purple);
            rect = new Rectangle(84, 225, 40, 40);
            g.FillEllipse(SB, rect);
            rect = new Rectangle(483, 40, 200, 200);
            g.FillEllipse(SB, rect);
            SB = new SolidBrush(Color.Red);
            rect = new Rectangle(520, 120, 100, 100);
            g.FillEllipse(SB, rect);
            SB = new SolidBrush(Color.Orange);
            rect = new Rectangle(500, 180, 75, 75);
            g.FillEllipse(SB, rect);
            SB = new SolidBrush(Color.Green);
            rect = new Rectangle(507, 207, 40, 40);
            g.FillEllipse(SB, rect);
        }
    }
}
