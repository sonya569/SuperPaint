using SuperPaint.API;
using SuperPaint.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint.API
{
    public class XCommand
    {
        public ActionWidth Width;
        public ActionColor Color;
        public ActionType Type;
        public ActionSave Save;
        public ActionOpen Open;
        public ActionStatus Status;

        Point _point;
        public DrawField df;
        public Point point
        {
            get
            {
                return _point;
            }
            set
            {
                _point = value;
                CoordsChanged(_point);
            }
        }
        public XData data;

        public delegate void coordDelegate(Point p);
        public event coordDelegate CoordsChanged;

        public XCommand()
        {
            Width = new ActionWidth(this);
            Color = new ActionColor(this);
            Type = new ActionType(this);
            Save = new ActionSave(this);
            Open = new ActionOpen(this);
            Status = new ActionStatus(this);
        }
    }
}
