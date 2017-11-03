using SuperPaint.UserControls;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Painting
{
    public interface IFileSO
    {
        void Save(List<FigureControl> lf);
        List<FigureControl> Load();
    }
}
