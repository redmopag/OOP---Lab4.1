using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project.Source.Shapes
{
    class CCircle : Shape
    {
        private int m_x, m_y;
        private const int m_radius = 100;
        private bool isSelection;
        public CCircle(int x, int y)
        {
            m_x = x;
            m_y = y;
        }

        public override Shape createShape(int x, int y) { return new CCircle(x, y); }
        public override bool inShape(int x, int y)
        {
            bool isBigger = Math.Sqrt(Math.Pow(x - m_x, 2) +  Math.Pow(y - m_y, 2)) > m_radius;
            return isBigger;
        }
        public override void draw(Graphics gr, Pen penNotSel, Pen penSel)
        {
            if (isSelection)
                gr.DrawEllipse(penSel, m_x - m_radius, m_y - m_radius, 2 * m_radius, 2 * m_radius);
            else
                gr.DrawEllipse(penNotSel, m_x - m_radius, m_y - m_radius, 2 * m_radius, 2 * m_radius);
        }

    }
}
