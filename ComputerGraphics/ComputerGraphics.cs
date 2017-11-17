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
        public int cellSize = 15;
        public int panelWidth;
        public int panelHeight;
        public Point center;
        public Graphics g;
        public Pen thinBlack = new Pen(Color.Black, 1);
        public Pen thickBlack = new Pen(Color.Black, 4);
        public Pen thinRed = new Pen(Color.Red, 2);
        public SolidBrush blackBrush = new SolidBrush(Color.Gray);
        public int delayInMilliseconds = 100;

        public Point start;
        public Point finish;
        public int radius;
        public int a;
        public int b;
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
            for (int x = cellSize / 2; x < panelWidth; x += cellSize)
            {
                g.DrawLine(thinBlack, new Point(x, 0), new Point(x, 600));
            }
            for (int y = cellSize / 2; y < panelHeight; y += cellSize)
            {
                g.DrawLine(thinBlack, new Point(0, y), new Point(900, y));
            }
            g.DrawLine(thickBlack, new Point(center.X, 0), new Point(center.X, panelHeight));
            g.DrawLine(thickBlack, new Point(0, center.Y), new Point(panelWidth, center.Y));
        }

        #region Second task - Drawing lines
        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            panel.Refresh();
            start = GetFirstPoint();
            finish = GetSecondPoint();
            DrawLineByBresenhamAlgorithm();
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

        private void DrawLineByBresenhamAlgorithm()
        {
            double error = -0.5;
            double k = ((double)(finish.Y - start.Y) / (finish.X - start.X));
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
            DrawPixelUnderLine(start.X, start.Y);
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
                DrawPixelUnderLine(x, y);
            }
        }

        private void DrawPixelUnderLine(int x, int y)
        {
            DrawPixel(new Point(x, y));
            DrawRealLine();
        }

        private void DrawRealLine()
        {
            Point firstPixel = new Point(center.X + start.X * cellSize, center.Y - start.Y * cellSize);
            Point secondPixel = new Point(center.X + finish.X * cellSize, center.Y - finish.Y * cellSize);
            g.DrawLine(thinRed, firstPixel, secondPixel);
        }
        #endregion

        #region Third task - Drawing a circle and an ellipse

        #region Drawing a circle

        private void buttonDrawCircle_Click(object sender, EventArgs e)
        {
            panel.Refresh();
            radius = Convert.ToInt32(numericUpDownRadius.Value);
            DrawCircleByBresenhamAlgorithm();
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
            DrawExtemePoints();
            while(v < 10)
            {
                if(d < 0)
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
                DrawPixelUnderCircle(x, y);
            }
            DrawSymmetricPoints(points);
        }

        private void DrawExtemePoints()
        {
            DrawPixelUnderCircle(0, radius);
            DrawPixelUnderCircle(radius, 0);
            DrawPixelUnderCircle(0, -radius);
            DrawPixelUnderCircle(-radius, 0);
        }

        private void DrawSymmetricPoints(List<Point> points)
        {
            foreach (var point in points)
            {
                DrawPixelUnderCircle(point.Y, point.X);
                DrawPixelUnderCircle(point.Y, -point.X);
                DrawPixelUnderCircle(point.X, -point.Y);
                DrawPixelUnderCircle(-point.X, -point.Y);
                DrawPixelUnderCircle(-point.Y, -point.X);
                DrawPixelUnderCircle(-point.Y, point.X);
                DrawPixelUnderCircle(-point.X, point.Y);
            }
        }

        private void DrawPixelUnderCircle(int x, int y)
        {
            DrawPixel(x, y);
            DrawRealCircle();
        }

        private void DrawRealCircle()
        {
            g.DrawEllipse(thinRed, center.X + (0 - radius) * cellSize, center.Y + (0 - radius) * cellSize, 2 * radius * cellSize, 2 * radius * cellSize);
        }

        #endregion

        #region Drawing an ellipse

        private void buttonDrawEllipse_Click(object sender, EventArgs e)
        {
            panel.Refresh();
            a = Convert.ToInt32(numericUpDownA.Value);
            b = Convert.ToInt32(numericUpDownB.Value);
            DrawEllipseByBresenhamAlgorithm();
        }
        
        private void DrawEllipseByBresenhamAlgorithm()
        {
            #region Initialization
            var points = new List<Point>();
            int x = 0;
            int y = b;
            int d = 4 * b * b + a * a - 4 * a * b * b;
            int L = a * b;
            int u = 12 * b * b;
            int v = 12 * b * b + 8 * a * a * (1 - b);
            #endregion

            DrawPixelUnderEllipse(x, y);
            while(L > 0)
            {
                if(d < 0)
                {
                    d += u;
                    u += 8 * b * b;
                    v += 8 * b * b;
                    L -= b;
                    x++;
                }
                else
                {
                    d += v;
                    u += 8 * b * b;
                    v += 8 * (a * a + b * b);
                    L -= (a + b);
                    x++;
                    y--;
                }
                points.Add(new Point(x, y));
                DrawPixelUnderEllipse(x, y);
            }
            x = a;
            y = 0;
            d = 4 * b * b + a * a - 4 * a * b * b;
            L = a * b;
            points.Add(new Point(x, y));
            DrawPixelUnderEllipse(x, y);
            while(L > 0)
            {
                if(d < 0)
                {
                    d += u;
                    u += 8 * b * b;
                    v += 8 * b * b;
                    L -= b;
                    y++;
                }
                else
                {
                    d += v;
                    u += 8 * b * b;
                    v += 8 * (a * a + b * b);
                    L -= (a + b);
                    x--;
                    y++;
                }
                points.Add(new Point(x, y));
                DrawPixelUnderEllipse(x, y);
            }
            //DrawSymmetricPoints(points);
        }

        private void DrawPixelUnderEllipse(int x, int y)
        {
            DrawPixel(x, y);
            DrawRealEllipse();
        }

        private void DrawRealEllipse()
        {
            g.DrawEllipse(thinRed, center.X + (0 - a) * cellSize, center.Y + (0 - b) * cellSize, 2 * a * cellSize, 2 * b * cellSize);
        }


        #endregion

        #endregion

        #region Supporting functions

        private void DrawPixel(int x, int y)
        {
            DrawPixel(new Point(x, y));
        }

        private void DrawPixel(Point point)
        {
            Thread.Sleep(delayInMilliseconds);
            FillPixel(point.X, point.Y);
        }

        private void FillPixel(int x, int y)
        {
            FillPixel(new Point(x, y));
        }

        private void FillPixel(Point point)
        {
            int left = (int)(center.X + (point.X - 0.5) * cellSize);
            int top = (int)(center.Y - (point.Y + 0.5) * cellSize);
            g.FillRectangle(blackBrush, left, top, cellSize, cellSize);
        }

        #endregion
    }
}
