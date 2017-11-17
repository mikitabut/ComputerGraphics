using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ComputerGraphics.Algorithms
{
    class DrawingLines
    {
        //void DrawLine()
        //{
        //    panel.Refresh();
        //    Point first = GetFirstPoint();
        //    Point second = GetSecondPoint();
        //    DrawLineByBresenhamAlgorithm(first, second);
        //}

        //private Point GetFirstPoint()
        //{
        //    int firstX = Convert.ToInt32(numericUpDownFirstX.Value);
        //    int firstY = Convert.ToInt32(numericUpDownFirstY.Value);
        //    return new Point(firstX, firstY);
        //}

        //private Point GetSecondPoint()
        //{
        //    int secondX = Convert.ToInt32(numericUpDownSecondX.Value);
        //    int secondY = Convert.ToInt32(numericUpDownSecondY.Value);
        //    return new Point(secondX, secondY);
        //}

        //private void DrawLineByBresenhamAlgorithm(Point start, Point finish)
        //{
        //    double error = -0.5;
        //    double k = ( (double)( finish.Y - start.Y ) / ( finish.X - start.X ) );
        //    int dx = Math.Abs(finish.X - start.X);
        //    int dy = Math.Abs(finish.Y - start.Y);
        //    int stepX = Math.Sign(finish.X - start.X);
        //    int stepY = Math.Sign(finish.Y - start.Y);
        //    int x = start.X;
        //    int y = start.Y;
        //    if(dy > dx)
        //    {
        //        k = 1 / k;
        //    }
        //    FillPixel(start);
        //    DrawRealLine(start, finish);
        //    for(int i = 1; i <= Math.Max(dx, dy); i++)
        //    {
        //        error += Math.Abs(k);
        //        if(dy > dx)
        //        {
        //            y += stepY;
        //            if(error >= 0)
        //            {
        //                x += stepX;
        //                error--;
        //            }
        //        }
        //        else
        //        {
        //            x += stepX;
        //            if(error >= 0)
        //            {
        //                y += stepY;
        //                error--;
        //            }
        //        }
        //        Thread.Sleep(1000);
        //        FillPixel(new Point(x, y));
        //        DrawRealLine(start, finish);
        //    }
        //}

        //private void DrawRealLine(Point start, Point finish)
        //{
        //    Point firstPixel = new Point(center.X + start.X * cellSize, center.Y - start.Y * cellSize);
        //    Point secondPixel = new Point(center.X + finish.X * cellSize, center.Y - finish.Y * cellSize);
        //    g.DrawLine(thinRed, firstPixel, secondPixel);
        //}

        //private void FillPixel(Point point)
        //{
        //    int left = (int)(center.X + (point.X - 0.5) * cellSize);
        //    int top = (int)(center.Y - (point.Y + 0.5) * cellSize);
        //    g.FillRectangle(blackBrush, left, top, cellSize, cellSize);
        //}
    }
}
