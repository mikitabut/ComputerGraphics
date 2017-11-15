using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace ComputerGraphics
{
    public partial class ComputerGraphics : Form
    {
        #region Initialization
        public const int CellSize = 15;
        public int panelWidth;
        public int panelHeight;
        Point center;
        Graphics g;
        Pen thinBlack = new Pen(Color.Black, 1);
        Pen thickBlack = new Pen(Color.Black, 4);
        Pen thinRed = new Pen(Color.Red, 2);
        SolidBrush blackBrush = new SolidBrush(Color.Gray);
        int radius;
        #endregion

        public ComputerGraphics()
        {
            InitializeComponent();
            panelWidth = panel.Width; //x
            panelHeight = panel.Height; //y
            center = new Point(panelWidth / 2, panelHeight / 2);
            g = panel.CreateGraphics();
        }     

        private void panel_Paint(object sender, PaintEventArgs e)
        {
            for (int x = CellSize / 2; x < panelWidth; x += CellSize)
            {
                g.DrawLine(thinBlack, new Point(x, 0), new Point(x, 600));
            }
            for (int y = CellSize / 2; y < panelHeight; y += CellSize)
            {
                g.DrawLine(thinBlack, new Point(0, y), new Point(900, y));
            }
            g.DrawLine(thickBlack, new Point(center.X, 0), new Point(center.X, panelHeight));
            g.DrawLine(thickBlack, new Point(0, center.Y), new Point(panelWidth, center.Y));
        }

        private void buttonDrawCircle_Click(object sender, EventArgs e)
        {
            panel.Refresh();
            radius = Convert.ToInt32(numericUpDownRadius.Value);
            DrawExtemePoints();
            DrawCircleByBresenhamAlgorithm();
        }

        private void DrawExtemePoints()
        {
            DrawPixel(0, radius);
            DrawPixel(radius, 0);
            DrawPixel(0, -radius);
            DrawPixel(-radius, 0);
        }

        private void DrawCircleByBresenhamAlgorithm()
        {
            #region Initialization
            var points = new List<Point>();
            int x = 0;
            int y = radius;
            int d = 3 - 2 * radius;
            int u = 6;
            int v = 10 - 4 * radius;
            #endregion
            while (v < 10)
            {
                if (d < 0)
                {
                    d += u;
                    u += 4;
                    v += 4;
                    x++;
                }
                else
                {
                    d += v;
                    u += 4;
                    v += 8;
                    x++;
                    y--;
                }
                points.Add(new Point(x, y));
                DrawPixel(x, y);
            }
            DrawSymmetricPoints(points);
        }

        private void DrawSymmetricPoints(List<Point> points)
        {
            foreach (var point in points)
            {
                DrawPixel(point.Y, point.X);
                DrawPixel(point.Y, -point.X);
                DrawPixel(point.X, -point.Y);
                DrawPixel(-point.X, -point.Y);
                DrawPixel(-point.Y, -point.X);
                DrawPixel(-point.Y, point.X);
                DrawPixel(-point.X, point.Y);
            }
        }

        private void DrawPixel(int x, int y)
        {
            DrawPixel(new Point(x, y));
        }

        private void DrawPixel(Point point)
        {
            Thread.Sleep(100);
            FillPixel(point.X, point.Y);
            DrawRealCircle();
        }

        private void DrawRealCircle()
        {
            g.DrawEllipse(thinRed, center.X + (0 - radius) * CellSize, center.Y + (0 - radius) * CellSize, 2 * radius * CellSize, 2 * radius * CellSize);
        }

        private void buttonDrawEllipse_Click(object sender, EventArgs e)
        {

        }

        private void FillPixel(int x, int y)
        {
            FillPixel(new Point(x, y));
        }

        private void FillPixel(Point point)
        {
            int left = (int)(center.X + (point.X - 0.5) * CellSize);
            int top = (int)(center.Y - (point.Y + 0.5) * CellSize);
            g.FillRectangle(blackBrush, left, top, CellSize, CellSize);
        }

        private void buttonDraw_Click(object sender, EventArgs e)
        {
            panel.Refresh();
            Point first = GetFirstPoint();
            Point second = GetSecondPoint();
            DrawLineByBresenhamAlgorithm(first, second);
        }

        private Point GetFirstPoint()
        {
            int firstX = Convert.ToInt32(numericUpDownFirstX.Value);
            int firstY = Convert.ToInt32(numericUpDownFirstY.Value);
            return new Point(firstX, firstY);
        }

        private Point GetSecondPoint()
        {
            int secondX = Convert.ToInt32(numericUpDownSecondX.Value);
            int secondY = Convert.ToInt32(numericUpDownSecondY.Value);
            return new Point(secondX, secondY);
        }

        private void DrawLineByBresenhamAlgorithm(Point start, Point finish)
        {
            double error = -0.5;
            double k = ( (double)( finish.Y - start.Y ) / ( finish.X - start.X ) );
            int dx = Math.Abs(finish.X - start.X);
            int dy = Math.Abs(finish.Y - start.Y);
            int stepX = Math.Sign(finish.X - start.X);
            int stepY = Math.Sign(finish.Y - start.Y);
            int x = start.X;
            int y = start.Y;
            if(dy > dx)
            {
                k = 1 / k;
            }
            FillPixel(start);
            DrawRealLine(start, finish);
            for(int i = 1; i <= Math.Max(dx, dy); i++)
            {
                error += Math.Abs(k);
                if(dy > dx)
                {
                    y += stepY;
                    if(error >= 0)
                    {
                        x += stepX;
                        error--;
                    }
                }
                else
                {
                    x += stepX;
                    if(error >= 0)
                    {
                        y += stepY;
                        error--;
                    }
                }
                Thread.Sleep(1000);
                FillPixel(new Point(x, y));
                DrawRealLine(start, finish);
            }
        }

        private void DrawRealLine(Point start, Point finish)
        {
            Point firstPixel = new Point(center.X + start.X * CellSize, center.Y - start.Y * CellSize);
            Point secondPixel = new Point(center.X + finish.X * CellSize, center.Y - finish.Y * CellSize);
            g.DrawLine(thinRed, firstPixel, secondPixel);
        }
    }
}
