using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CompGraphics_Laba6
{
    public partial class Form1 : Form
    { // Size: 1 000, 600
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            #region // кисти
            Graphics g = e.Graphics;
            SolidBrush sun = new SolidBrush(Color.Yellow); 
            SolidBrush clouds = new SolidBrush(Color.Gray);
            SolidBrush road = new SolidBrush(Color.DarkSlateGray);
            SolidBrush tile = new SolidBrush(Color.White);
            #endregion

            #region // небо
            g.FillPie(sun, 115, 23, 95, 95, 0, -180);
            g.FillEllipse(clouds, 75, 45, 155, 75);
            g.FillEllipse(clouds, 250, 20, 130, 45);
            g.FillEllipse(clouds, 432, 55, 180, 80);
            g.FillEllipse(clouds, 650, 25, 130, 70);
            g.FillEllipse(clouds, -50, 35, 100, 70);
            #endregion

            #region // дома
            GraphicsPath myGraphicsPath = new GraphicsPath();
            Point[] pBuilding1 = new Point [4] {new Point(0, this.ClientRectangle.Width), new Point(0, 150), new Point(75, 150),
                new Point(75, this.ClientRectangle.Height - 75) };
            Point[] pBuilding2 = new Point[4] {new Point(65, this.ClientRectangle.Width), new Point(65, 175), new Point(140, 175),
                new Point(140, this.ClientRectangle.Height - 75) };
            g.FillPolygon(Brushes.Crimson, pBuilding1);
            g.DrawPolygon(Pens.Black, pBuilding1);
            g.FillPolygon(Brushes.Crimson, pBuilding2);
            g.DrawPolygon(Pens.Black, pBuilding2);

            Point[] pBuilding3 = new Point[4]
            {
                new Point(this.ClientRectangle.Width, this.ClientRectangle.Height), new Point(this.ClientRectangle.Width, 120),
                new Point(this.ClientRectangle.Width - 60, 120), new Point(this.ClientRectangle.Width - 60, this.ClientRectangle.Height)
            };

            g.FillRectangle(Brushes.Crimson, this.ClientRectangle.Width - 150, 170, 500, 500);
            g.DrawRectangle(Pens.Black, this.ClientRectangle.Width - 150, 170, 500, 500);

            g.FillRectangle(Brushes.Crimson, this.ClientRectangle.Width - 200, 225, 500, 500);
            g.DrawRectangle(Pens.Black, this.ClientRectangle.Width - 200, 225, 500, 500);

            g.FillPolygon(Brushes.Crimson, pBuilding3);
            g.DrawPolygon(Pens.Black, pBuilding3);

            #endregion

            #region // дорога
            Rectangle rectRoad = new Rectangle(-10, this.ClientRectangle.Height - 75,
                this.ClientRectangle.Width + 15, this.ClientRectangle.Height + 15);
            Pen pRoad = new Pen(Brushes.Black, 7);
            g.FillRectangle(road, rectRoad);
            g.DrawRectangle(pRoad, rectRoad);

            Rectangle[] rcs = new Rectangle[11];
            int x = 10;
            for (int i = 0; i < 11; i++)
            {
                rcs[i] = new Rectangle(x, this.ClientRectangle.Height - 40, 50, 15);
                x += 70;

            }

            e.Graphics.FillRectangles(Brushes.White, rcs);
            #endregion
        }
    }
}
