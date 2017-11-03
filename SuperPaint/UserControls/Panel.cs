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
    public partial class Panel : UserControl
    {
        public XCommand _cmd = new XCommand();

        public XCommand cmd()
        {
            return _cmd;
        } //{ get; set; }

        public Panel()
        {
            XData data = new XData();

            _cmd = new XCommand();
            _cmd.data = data;
            InitializeComponent();
        }

        private void Panel_Load(object sender, EventArgs e)
        {

        }
    }
}
