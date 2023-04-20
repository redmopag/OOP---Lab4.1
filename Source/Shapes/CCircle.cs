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
        private int m_x, m_y; // Центр круга
        private const int m_radius = 20; // Радиус круга
        public bool isSelection; // Выделен ли элемент
        public CCircle()
        {
            m_x = 0; m_y = 0;
        }
        public CCircle(int x, int y)
        {
            m_x = x;
            m_y = y;
        }

        // Создаёт круг с серединной в указанной точке
        public Shape createShape(int x, int y) { return new CCircle(x, y); }
        // Находится ли указанные координаты внутри фигуры
        public bool inShape(int x, int y)
        {
            bool isBigger = Math.Sqrt(Math.Pow(x - m_x, 2) +  Math.Pow(y - m_y, 2)) > m_radius;
            return !isBigger;
        }
        // Прорисовка круга: в случае выделения и созодания
        public void draw(Graphics gr, Pen penNotSel, Pen penSel)
        {
            if (isSelection)
                gr.DrawEllipse(penSel, m_x - m_radius, m_y - m_radius, 2 * m_radius, 2 * m_radius);
            else
                gr.DrawEllipse(penNotSel, m_x - m_radius, m_y - m_radius, 2 * m_radius, 2 * m_radius);
        }
        public void setSelection(bool flag)
        {
            isSelection = flag;
        }
        public bool getSelection()
        {
            return isSelection;
        }
    }
}
