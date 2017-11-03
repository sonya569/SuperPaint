using Paint.API;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Paint.API.Figure;

namespace SuperPaint
{
    [Serializable()]
    public class FigureMemento
    {
        public int X1 { get; set; }
        public int Y1 { get; set; }
        public int X2 { get; set; }
        public int Y2 { get; set; }
        public int Color { get; set; }
        public int Width { get; set; }
        public int Type { get; set; }

        public FigureMemento(Figure figure)
        {
            X1 = figure.Start.X;
            Y1 = figure.Start.Y;
            X2 = figure.End.X;
            Y2 = figure.End.Y;
            Color = figure.Color.ToArgb();
            Width = figure.StrokeWidth;
            Type = (int)figure.Type;
        }

        public FigureMemento()
        {

        }

        public Figure GetState()
        {
            return new Figure(new Point(X1, Y1), new Point(X2, Y2), System.Drawing.Color.FromArgb(Color), Width, (FType)Type);
        }

    }
}
