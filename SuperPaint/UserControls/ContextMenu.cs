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
namespace SuperPaint.UserControls
{
    public partial class ContextMenu : UserControl
    {
        public ContextMenu(XCommand cmd)
        {
            InitializeComponent();
            colorToolStripMenuItem.Click += new EventHandler(cmd.Color.Action);
            widthToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(cmd.Width.Action);
            typeToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler(cmd.Type.Action);
        }
    }
}
