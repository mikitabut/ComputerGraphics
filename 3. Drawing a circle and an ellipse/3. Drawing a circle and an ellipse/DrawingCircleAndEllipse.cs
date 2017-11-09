using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _3.Drawing_a_circle_and_an_ellipse
{
    public partial class DrawingCircleAndEllipse : Form
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

        public DrawingCircleAndEllipse()
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

        private void buttonDrawCircle_Click(object sender, EventArgs e)
        {
            panel.Refresh();
            int radius = Convert.ToInt32(numericUpDownRadius.Value);
            FillPixels(radius);
        }

        private void FillPixels(int radius)
        {
            g.DrawEllipse(thinRed, center.X + (0 - radius) * CellSize, center.Y + (0 - radius) * CellSize, 2 * radius * CellSize, 2 * radius * CellSize);
        }

        private void DrawCircle(int radius)
        {
            //int firstX = Convert.ToInt32(numericUpDownFirstX.Value);
            //int firstY = Convert.ToInt32(numericUpDownFirstY.Value);
            //int secondX = Convert.ToInt32(numericUpDownSecondX.Value);
            //int secondY = Convert.ToInt32(numericUpDownSecondY.Value);
            //Point center = new Point(panelWidth / 2, panelHeight / 2);
            //Point firstPoint = new Point(center.X + firstX * CellSize, center.Y - firstY * CellSize);
            //Point secondPoint = new Point(center.X + secondX * CellSize, center.Y - secondY * CellSize);
            //g.DrawLine(thinRed, firstPoint, secondPoint);
        }

        private void buttonDrawEllipse_Click(object sender, EventArgs e)
        {

        }

        private void FillPixel(Point point)
        {
            int left = (int)(center.X + (point.X - 0.5) * CellSize);
            int top = (int)(center.Y - (point.Y + 0.5) * CellSize);
            g.FillRectangle(blackBrush, left, top, CellSize, CellSize);
        }
    }
}
