using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SuperPaint.API;
using Paint.API;
using System.Windows.Forms;
using SuperPaint.UserControls;
using Painting;
using static Paint.API.Figure;

namespace SuperPaint.API
{
    public class ActionWidth
    {
        XCommand cmd;
        public ActionWidth(XCommand cmd)
        {
            this.cmd = cmd;
        }
        public void Action(object sender, EventArgs e)
        {
            MessageBox.Show("ActionWidth");
            cmd.data.StrokeWidth = Convert.ToInt32(((ComboBox)sender).SelectedItem.ToString());
        }

        public void Action(object sender, ToolStripItemClickedEventArgs e)
        {
            MessageBox.Show("ActionWidth");
            if (sender is ToolStripMenuItem && (sender as ToolStripMenuItem).Owner is ContextMenuStrip)
            {
                FigureControl fc = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as FigureControl;
                fc.Data.StrokeWidth = Convert.ToInt32(e.ClickedItem.Text);
                fc.UpdateData();
            }
            else
            {
                cmd.data.StrokeWidth = Convert.ToInt32(e.ClickedItem.Text);
            }
        }
    }
    public class ActionColor
    {
        XCommand cmd;
        public ActionColor(XCommand cmd)
        {
            this.cmd = cmd;
        }
        public void Action(object sender, EventArgs e)
        {
            MessageBox.Show("ActionColor");
            ColorDialog clrDlg = new ColorDialog();
            if (clrDlg.ShowDialog() == DialogResult.OK)
            {
                if (sender is ToolStripMenuItem && (sender as ToolStripMenuItem).Owner is ContextMenuStrip)
                {
                    FigureControl fc = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as FigureControl;
                    fc.Data.Color = clrDlg.Color;
                    fc.UpdateData();

                }
                else
                {
                    cmd.data.Color = clrDlg.Color;
                }
            }
        }
    }

    public class ActionType
    {
        XCommand cmd;
        public ActionType(XCommand cmd)
        {
            this.cmd = cmd;
        }
        public void Action(object sender, EventArgs e)
        {
            string type = "Rectangle";
            try
            {
                type = (sender as Button).Text;
            }
            catch { }
            switch (type)
            {
                case "Rectangle": cmd.data.Type = FType.Rectangle; break;
                case "RRectangle": cmd.data.Type = FType.RRectangle; break;
                case "Ellipse": cmd.data.Type = FType.Ellipse; break;
                case "Line": cmd.data.Type = FType.Line; break;
            }
        }

        public void Action(object sender, ToolStripItemClickedEventArgs e)
        {
            string type = e.ClickedItem.Text;
            if (sender is ToolStripMenuItem && (sender as ToolStripMenuItem).Owner is ContextMenuStrip)
            {
                FigureControl fc = ((sender as ToolStripMenuItem).Owner as ContextMenuStrip).SourceControl as FigureControl;
                switch (type)
                {
                    case "Rectangle": fc.Data.Type = FType.Rectangle; break;
                    case "RRectangle": fc.Data.Type = FType.RRectangle; break;
                    case "Ellipse": fc.Data.Type = FType.Ellipse; break;
                    case "Line": fc.Data.Type = FType.Line; break;
                }
                fc.UpdateData();
            }
            else
            {
                switch (type)
                {
                    case "Rectangle": cmd.data.Type = FType.Rectangle; break;
                    case "RRectangle": cmd.data.Type = FType.RRectangle; break;
                    case "Ellipse": cmd.data.Type = FType.Ellipse; break;
                    case "Line": cmd.data.Type = FType.Line; break;
                }
            }
        }
    }
    public class ActionSave
    {
        XCommand cmd;
        public ActionSave(XCommand cmd)
        {
            this.cmd = cmd;
        }
        public void Action(object sender, EventArgs e)
        {
            SaveFileDialog dlgSave = new SaveFileDialog();
            string[] ext = { "JSON (*.json)|*.json", "XML (*.xml) | *.xml", "YAML (*.yaml)|*.yaml", "CSV (*.csv)|*.csv" };
            dlgSave.Filter = String.Join("|", ext);
            if (dlgSave.ShowDialog() == DialogResult.OK)
            {
                SOFactory.GetInstance(dlgSave.FileName).Save(cmd.df.GetListOfFigures());
            }
        }
    }
    public class ActionOpen
    {
        XCommand cmd;
        public ActionOpen(XCommand cmd)
        {
            this.cmd = cmd;
        }
        public void Action(object sender, EventArgs e)
        {
            OpenFileDialog dlgOpen = new OpenFileDialog();
            string ext = "SO (*.json; *.xml; *.yaml; *.bin; *.csv)| *.json; *.xml; *.yaml; *.bin; *.csv";
            dlgOpen.Filter = ext;
            if (dlgOpen.ShowDialog() == DialogResult.OK)
            {
                cmd.df.SetListOfFigures(SOFactory.GetInstance(dlgOpen.FileName).Load());
            }
        }
    }

    public class ActionStatus
    {
        XCommand cmd;
        public ActionStatus(XCommand cmd)
        {
            this.cmd = cmd;
        }
        public void Action(object sender, EventArgs e)
        {
            cmd.point = (e as MouseEventArgs).Location;
        }
    }
}
