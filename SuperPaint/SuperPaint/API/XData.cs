using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Paint.API.Figure;

namespace Paint.API
{
    public class XData
    {
        public FType Type { get; set; }
        public Color Color { get; set; }
        public int StrokeWidth { get; set; }

        public XData()
        {
            Type = FType.Line;
            Color = Color.Black;
            StrokeWidth = 1;
        }

        public XData(XData data)
        {
            Type = data.Type;
            Color = data.Color;
            StrokeWidth = data.StrokeWidth;
        }
    }
}
