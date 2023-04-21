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
        Shape clone();
        bool inShape(int x, int y);
        void draw(Graphics gr, Pen penNotSel, Pen penSel);
        void setSelection(bool flag);
        bool getSelection();
        void setX(int x);
        void setY(int y);
    }
}
