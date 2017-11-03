using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Paint.API;
using static Paint.API.Figure;

namespace SuperPaint.UserControls
{
    public partial class DrawField : UserControl
    {
        public DrawField() { }

        public DrawField(XCommand cmd)
        {
            InitializeComponent();
            //try
            {
                cmd.df = this;
                //pbField.MouseMove += cmd.Status.Action;
                pbField.Image = new Bitmap(pbField.Width, pbField.Height);
                Action = cmd;
            }
            // catch { }
        }

        public XCommand Action { get; set; }
        public Point startPoint;

        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
                startPoint = e.Location;
        }

        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            // if (Action.data.Type == FType.Curve && e.Button == MouseButtons.Left)
            if (e.Button == MouseButtons.Left)
            {
                using (Graphics g = Graphics.FromImage(pbField.Image))
                {
                    g.DrawLine(new Pen(Action.data.Color, Action.data.StrokeWidth), startPoint, e.Location);
                    pbField.Invalidate();
                    startPoint = e.Location;
                }
            }

        }

        private void OnMouseUp(object sender, MouseEventArgs e)
        {
            // if (Action.data.Type != FType.Curve)
            {
                FigureControl figureControl = new FigureControl(startPoint, e.Location, new XData(Action.data));
                pbField.Controls.Add(figureControl);
            }
        }

        public List<FigureControl> GetListOfFigures()
        {
            List<FigureControl> list = new List<FigureControl>();
            foreach (Control figure in pbField.Controls)
            {
                if (figure is FigureControl)
                    list.Add(figure as FigureControl);
            }
            return list;
        }

        public void SetListOfFigures(List<FigureControl> list)
        {
            foreach (Control control in pbField.Controls)
            {
                if (control is FigureControl)
                    pbField.Controls.Remove(control);
            }
            foreach (FigureControl figure in list)
            {
                pbField.Controls.Add(figure);
            }
        }

        private void SetFigureListeners(object sender, ControlEventArgs e)
        {
            if (e.Control is FigureControl)
            {
                (e.Control as FigureControl).SetListeners(Action);
            }
        }
    }
}
