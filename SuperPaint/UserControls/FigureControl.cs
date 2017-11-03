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


using SuperPaint.API;
using System.Drawing.Drawing2D;
using static Paint.API.Figure;
using SuperPaint.Properties;

namespace SuperPaint.UserControls
{
    public partial class FigureControl : UserControl
    {
        
        public enum Side { left, topLeft, top, topRight, right, botRight, bot, botLeft, none, startLine, endLine, center };
        public XData Data { get => _data; }

        Point _moving;
        Side _resizing;

        Figure _figure;
        XData _data;

        int _space;

        #region Constructors
        public FigureControl(Point location, Point endPoint, XData data)
        {
            Init(location, endPoint, data);
        }
        public FigureControl() { }
        #endregion

        #region Initializations
        private void Init(Point location, Point endPoint, XData data)
        {
            InitializeComponent();
            SetControlStyle();

            _data = data;
            _figure = new Figure(location, endPoint, data.Color, data.StrokeWidth, data.Type);
            _space = 7 + data.StrokeWidth;

            Paint += OnPaintBackground;
            SetLocation();
        }
        public void SetListeners(XCommand cmd)
        {
            components = new Container();
            ctxMenu1 = new ContextMenu(cmd);
            SuspendLayout();
            ctxMenu1.Visible = false;

            ContextMenuStrip = ctxMenu1.contextMenuStrip1;
            MouseMove += cmd.Status.Action;
        }
        private void SetControlStyle()
        {
            SetStyle(ControlStyles.SupportsTransparentBackColor, true);
            SetStyle(ControlStyles.Selectable, true);
            this.TabStop = true;
            BackColor = Color.Transparent;
        }
        #endregion

        #region MouseEvents
        private void OnMouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                _moving = e.Location;
                _resizing = GetSide(e.Location);
                Focus();
            }
        }
        private void OnMouseMove(object sender, MouseEventArgs e)
        {
            ChangeCursor(GetSide(e.Location));

            if (e.Button == MouseButtons.Left)
            {
                if (_resizing == Side.center)
                    Translate(e.Location);
                else
                    ChangeSize(e.Location, _resizing);
            }
        }
        private void OnMouseLeave(object sender, EventArgs e)
        {
            if (Focused == false)
                BorderStyle = BorderStyle.None;
        }
        private void OnMouseEnter(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }
        #endregion

        #region Move&Resize
        private void Translate(Point newLocation)
        {
            int deltaX = newLocation.X - _moving.X;
            int deltaY = newLocation.Y - _moving.Y;

            Point newStart = new Point(_figure.Start.X + deltaX, _figure.Start.Y + deltaY);
            Point newEnd = new Point(_figure.End.X + deltaX, _figure.End.Y + deltaY);

            _figure.UpdatePoints(newStart, newEnd);

            SetLocation();
        }
        private void ChangeSize(Point point, Side side)
        {
            Point resizedPoint = new Point(_figure.Start.X + point.X, _figure.Start.Y + point.Y);

            _resizing = side;

            int x1 = _figure.Start.X;
            int y1 = _figure.Start.Y;
            int x2 = _figure.End.X;
            int y2 = _figure.End.Y;

            if (_resizing == Side.top)
            {
                y1 = resizedPoint.Y;
                if (y1 > y2)
                    _resizing = Side.bot;
            }
            else if (_resizing == Side.topRight)
            {
                y1 = resizedPoint.Y;
                x2 = resizedPoint.X;
                if (y1 > y2)
                    _resizing = Side.botRight;
                else if (x2 < x1)
                    _resizing = Side.topLeft;
            }
            else if (_resizing == Side.right)
            {
                x2 = resizedPoint.X;
                if (x2 < x1)
                    _resizing = Side.left;
            }
            else if (_resizing == Side.botRight || _resizing == Side.endLine)
            {
                x2 = resizedPoint.X;
                y2 = resizedPoint.Y;
                if (y2 < y1 && _resizing != Side.endLine)
                    _resizing = Side.topRight;
                else if (x2 < x1 && _resizing != Side.endLine)
                    _resizing = Side.botLeft;
            }
            else if (_resizing == Side.bot)
            {
                y2 = resizedPoint.Y;
                if (y2 < y1)
                    _resizing = Side.top;
            }
            else if (_resizing == Side.botLeft)
            {
                x1 = resizedPoint.X;
                y2 = resizedPoint.Y;
                if (y2 < y1)
                    _resizing = Side.topLeft;
                else if (x1 > x2)
                    _resizing = Side.botRight;
            }
            else if (_resizing == Side.left)
            {
                x1 = resizedPoint.X;
                if (x1 > x2)
                    _resizing = Side.right;
            }
            else if (_resizing == Side.topLeft || _resizing == Side.startLine)
            {
                x1 = resizedPoint.X;
                y1 = resizedPoint.Y;
                if (y1 > y2 && _resizing != Side.startLine)
                    _resizing = Side.botLeft;
                else if (x1 > x2 && _resizing != Side.startLine)
                    _resizing = Side.topRight;
            }


            Point newStart = new Point(Math.Min(x1, x2), Math.Min(y1, y2));
            Point newEnd = new Point(Math.Max(x1, x2), Math.Max(y1, y2));
            _figure.UpdatePoints(newStart, newEnd);

            SetLocation();
        }
        #endregion

        #region Helfull methods
        private Side GetSide(Point point)
        {
            Side pos = Side.none;
            int x = point.X;
            int y = point.Y;
            if (0 <= y && y <= _space)
            {
                if (0 <= x && x <= _space)
                    pos = Side.topLeft;
                else if (_space <= x && x <= Width - _space)
                    pos = Side.top;
                else if (Width - _space <= x && x <= Width)
                    pos = Side.topRight;
            }
            else if (_space <= y && y <= Height - _space)
            {
                if (0 <= x && x <= _space)
                    pos = Side.left;
                else if (_space <= x && x <= Width - _space)
                    pos = Side.center;
                else if (Width - _space <= x && x <= Width)
                    pos = Side.right;
            }
            else if (Height - _space <= y && y <= Height)
            {
                if (0 <= x && x <= _space)
                    pos = Side.botLeft;
                else if (_space <= x && x <= Width - _space)
                    pos = Side.bot;
                else if (Width - _space <= x && x <= Width)
                    pos = Side.botRight;
            }
            return pos;
        }
        private void ChangeCursor(Side pos)
        {
            if (pos == Side.top || pos == Side.bot)
                Cursor.Current = Cursors.SizeNS;
            else if (pos == Side.topRight || pos == Side.botLeft)
                Cursor.Current = Cursors.SizeNESW;
            else if (pos == Side.botRight || pos == Side.topLeft)
                Cursor.Current = Cursors.SizeNWSE;
            else if (pos == Side.right || pos == Side.left)
                Cursor.Current = Cursors.SizeWE;
            else if (pos == Side.startLine || pos == Side.endLine || pos == Side.center)
                Cursor.Current = Cursors.SizeAll;
            else
                Cursor.Current = Cursors.Arrow;
        }
        private void SetLocation()
        {
            if (_figure.Type != Figure.FType.Line)
                Location = _figure.Start;
            else
                Location = new Point(Math.Min(_figure.Start.X, _figure.End.X), Math.Min(_figure.Start.Y, _figure.End.Y));

            Refresh();
        }
        #endregion

        #region Updating
        public void UpdateData()
        {
            _figure = new Figure(_figure.Start, _figure.End, Data.Color, Data.StrokeWidth, Data.Type);
            _space = 7 + Data.StrokeWidth;

            SetLocation();
        }
        #endregion

        #region Memento
        public void SetMemento(FigureMemento memento)
        {
            Figure figure = memento.GetState();
            XData data = new XData();

            data.Color = figure.Color;
            data.StrokeWidth = figure.StrokeWidth;
            data.Type = figure.Type;

            Init(figure.Start, figure.End, data);
        }
        public FigureMemento GetMemento()
        {
            return new FigureMemento(_figure);
        }
        #endregion

        #region Key Events
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            _moving = _figure.Start;
            int delta = 5;

            if (keyData == (Keys.Shift | Keys.Up))
                ChangeSize(new Point(0, -delta), Side.top);
            else if (keyData == Keys.Up)
                Translate(new Point(_figure.Start.X, _figure.Start.Y - delta));

            else if (keyData == (Keys.Shift | Keys.Down))
                ChangeSize(new Point(0, _figure.Size.Height + delta), Side.bot);
            else if (keyData == Keys.Down)
                Translate(new Point(_figure.Start.X, _figure.Start.Y + delta));

            else if (keyData == (Keys.Shift | Keys.Right))
                ChangeSize(new Point(_figure.Size.Width + delta, 0), Side.right);
            else if (keyData == Keys.Right)
                Translate(new Point(_figure.Start.X + delta, _figure.Start.Y));

            else if (keyData == (Keys.Shift | Keys.Left))
                ChangeSize(new Point(-delta, 0), Side.left);
            else if (keyData == Keys.Left)
                Translate(new Point(_figure.Start.X - delta, _figure.Start.Y));

            return true;
        }
        #endregion

        #region Focus Events
        private void OnGotFocus(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.FixedSingle;
        }
        private void OnLostFocus(object sender, EventArgs e)
        {
            BorderStyle = BorderStyle.None;
        }
        #endregion

        #region Drawing
        private void OnPaintBackground(object sender, PaintEventArgs e)
        {
            Pen figurePen = new Pen(_figure.Color, _figure.StrokeWidth);
            Rectangle drawRect = new Rectangle(new Point(_figure.StrokeWidth / 2, _figure.StrokeWidth / 2), _figure.Size);
            Size = Size.Add(_figure.Size, new Size(_figure.StrokeWidth, _figure.StrokeWidth));

            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            e.Graphics.DrawPath(figurePen, GetFigureShape(drawRect));
        }

        private GraphicsPath GetFigureShape(Rectangle drawClip)
        {
            GraphicsPath shape = new GraphicsPath();
            switch (_figure.Type)
            {
                case FType.Rectangle: shape.AddRectangle(drawClip); break;
                case FType.RRectangle: shape.AddPath(GetRRectanglePath(drawClip), true); break;
                case FType.Ellipse: shape.AddEllipse(drawClip); break;
                case FType.Line: shape.AddPath(GetLinePath(), true); break;
            }
            return shape;
        }
        private GraphicsPath GetLinePath()
        {
            GraphicsPath line = new GraphicsPath();

            Point topLeft = new Point(Math.Min(_figure.Start.X, _figure.End.X), Math.Min(_figure.Start.Y, _figure.End.Y));

            Point startLine = new Point(_figure.Start.X - topLeft.X, _figure.Start.Y - topLeft.Y);
            Point endLine = new Point(_figure.End.X - topLeft.X, _figure.End.Y - topLeft.Y);

            line.AddLine(startLine, endLine);

            return line;
        }
        private GraphicsPath GetRRectanglePath(Rectangle drawClip)
        {
            GraphicsPath path = new GraphicsPath();

            int diameter = 20;

            Size size = new Size(diameter, diameter);
            Rectangle arc = new Rectangle(drawClip.Location, size);

            path.AddArc(arc, 180, 90);
            arc.X = drawClip.Right - diameter;
            path.AddArc(arc, 270, 90);
            arc.Y = drawClip.Bottom - diameter;
            path.AddArc(arc, 0, 90);
            arc.X = drawClip.Left;
            path.AddArc(arc, 90, 90);
            arc.Y = drawClip.Top;
            path.CloseFigure();

            return path;
        }
        #endregion
    }
}
