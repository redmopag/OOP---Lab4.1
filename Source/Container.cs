using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Project.Source.Shapes;

namespace Project.Source
{
    class Container
    {
        // Список элементов контейнера
        private List<Shape> shapes = new List<Shape>();

        // Проходится по всему списку и вызвает у каждого из них метод
        // Прорисовки фигуры
        public void drawAll(Graphics gr, Pen penNotSel, Pen penSel)
        {
            foreach(Shape shape in shapes)
            {
                shape.draw(gr, penNotSel, penSel);
            }
        }
        public void add(Shape shape)
        {
            shapes.Add(shape);
        }
        public void remove(Shape shape)
        {
            shapes.Remove(shape);
        }
    }
}
