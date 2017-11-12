using System;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace _2.Drawing_lines
{
    public partial class DrawingLines : Form
    {
        #region Initialization
        public const int CellSize = 30;
        public int panelWidth;
        public int panelHeight;
        Point center;
        Graphics g;
        Pen thinBlack = new Pen(Color.Black, 1);
        Pen thickBlack = new Pen(Color.Black, 4);
        Pen thinRed = new Pen(Color.Red, 2);
        SolidBrush blackBrush = new SolidBrush(Color.Gray);

        public DrawingLines()
        {
            InitializeComponent();
            panelWidth = panel.Width; //x
            panelHeight = panel.Height; //y
            center = new Point(panelWidth / 2, panelHeight / 2);
            g = panel.CreateGraphics();
        }
        #endregion

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
            double k = ((double)(finish.Y - start.Y) / (finish.X - start.X));
            int dx = Math.Abs(finish.X - start.X);
            int dy = Math.Abs(finish.Y - start.Y);
            int stepX = Math.Sign(finish.X - start.X);
            int stepY = Math.Sign(finish.Y - start.Y);
            int x = start.X;
            int y = start.Y;
            if (dy > dx)
            {
                k = 1 / k;
            }
            FillPixel(start);
            DrawRealLine(start, finish);
            for (int i = 1; i <= Math.Max(dx, dy); i++)
            {
                error += Math.Abs(k);
                if(dy > dx)
                {
                    y += stepY;
                    if (error >= 0)
                    {
                        x += stepX;
                        error--;
                    }
                }
                else
                {
                    x += stepX;
                    if (error >= 0)
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

        private void FillPixel(Point point)
        {
            int left = (int)(center.X + (point.X - 0.5) * CellSize);
            int top = (int)(center.Y - (point.Y + 0.5) * CellSize);
            g.FillRectangle(blackBrush, left, top, CellSize, CellSize);
        }
    }
}
