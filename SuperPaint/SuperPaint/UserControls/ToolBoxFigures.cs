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
    public partial class ToolBoxFigures : UserControl
    {
        public ToolBoxFigures()
        {
            InitializeComponent();
        }
        public ToolBoxFigures(XCommand cmd)
        {
            InitializeComponent();
            radioButton1.CheckedChanged += new EventHandler(cmd.Type.Action);
        }
    }
}
