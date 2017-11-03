using SuperPaint;
using SuperPaint.UserControls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Painting
{
    public static class FigureSerializer
    {
        public static List<FigureMemento> GetMementoList(List<FigureControl> figures)
        {
            List<FigureMemento> fm = new List<FigureMemento>();
            foreach (FigureControl f in figures)
            {
                fm.Add(f.GetMemento());
            }
            return fm;
        }
        public static List<FigureControl> GetFiguresList(List<FigureMemento> fm)
        {
            List<FigureControl> figures = new List<FigureControl>();
            foreach (FigureMemento f in fm)
            {
                FigureControl figure = new FigureControl();
                figure.SetMemento(f);
                figures.Add(figure);
            }
            return figures;
        }
    }
}
