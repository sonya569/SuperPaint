using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Paint.API
{
    public class Figure
    {
        public enum FType { Rectangle, Line, Ellipse, RRectangle };

        public Color Color { get; set; }
        public int StrokeWidth { get; set; }
        public FType Type { get; set; }
        public Point End { get; private set; }
        public Point Start { get; private set; }
        public Size Size { get; private set; }

        public Figure(Point startPoint, Point endPoint, Color color, int strokeWidth, FType type)
        {
            Init(startPoint, endPoint, color, strokeWidth, type);
        }

        public void UpdatePoints(Point startPoint, Point endPoint)
        {
            SetPoints(startPoint, endPoint);
            Size = new Size(Math.Abs(End.X - Start.X), Math.Abs(End.Y - Start.Y));
        }

        private void Init(Point startPoint, Point endPoint, Color color, int strokeWidth, FType type)
        {
            Color = color;
            Type = type;
            StrokeWidth = strokeWidth;
            SetPoints(startPoint, endPoint);
            Size = new Size(Math.Abs(End.X - Start.X), Math.Abs(End.Y - Start.Y));
        }

        private void SetPoints(Point start, Point end)
        {
            if (Type != FType.Line)
            {
                Start = new Point(Math.Min(start.X, end.X), Math.Min(start.Y, end.Y));
                End = new Point(Math.Max(start.X, end.X), Math.Max(start.Y, end.Y));
            }
            else
            {
                Start = start;
                End = end;
            }
        }
    }
}
