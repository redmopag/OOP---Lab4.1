using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Source.Shapes
{
    interface Shape
    {
        Shape createShape(int x, int y);
        bool inShape(int x, int y);
        void draw(Graphics gr, Pen penNotSel, Pen penSel);
    }
}
