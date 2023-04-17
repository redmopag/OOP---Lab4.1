using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Source.Shapes
{
    abstract class Shape
    {
        public abstract Shape createShape(int x, int y);
        public abstract bool inShape(int x, int y);
        public abstract void draw(Graphics gr, Pen penNotSel, Pen penSel);
    }
}
