using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Project.Source.Shapes;

namespace Project.Source
{
    class Container
    {
        // Список фигур
        private List<Shape> shapes = new List<Shape>();
        // Нажата ли клавиша ctrl для выделения нескольких фигур последовательно
        private bool isCtrl = false;
        // Флаг для выбора нескольких элементов при одном нажатии
        private bool isMultiSelection = false;

        // Снимает все выделения фигур
        public void resetAllSelections()
        {
            foreach(Shape shape in shapes)
                shape.setSelection(false);
        }
        // Обходит контейнер фигур и проверяет, попал ли курсор в одну из фигур
        // Если попал, возвращает true, а также отмечает подходящие фигуры как выбранные
        // Учитывает возможность одинарного и множественного выделения через ctrl
        public bool inShapeContainer(int x, int y)
        {
            bool flagInCont = false;
            if (!isCtrl)
                resetAllSelections();
            foreach (Shape shape in shapes)
            {
                if (shape.inShape(x, y) && !shape.getSelection())
                {
                    shape.setSelection(true);
                    flagInCont = true;
                    if (!isCtrl || !isMultiSelection)
                        break;
                }
            }
            return flagInCont;
        }
        // Добавляет фигуру в контейнер
        public void add(Shape shape)
        {
            shapes.Add(shape);
        }
        // Возвращает последнюю фигуру из списка
        public Shape last()
        {
            return shapes.Last();
        }
        // Настройка флага Ctrl
        // Изменяет также chekbox, связанный с этим флагом
        public void setCtrl(bool ctrl, object sender = null)
        {
            isCtrl = ctrl;
            if(sender != null)
                (sender as CheckBox).Checked = ctrl;
        }
        // Возвращает флаг ctrl
        public bool getCtrl()
        {
            return isCtrl;
        }
        // Удаляет выбранные фигуры
        public void removeSelctions()
        {
            for (int i = 0; i < shapes.Count; ++i)
                if (shapes[i].getSelection())
                    shapes.RemoveAt(i--);
        }
        public void drawShapes(Graphics gr, Pen penNotSel, Pen penSel)
        {
            foreach (Shape shape in shapes)
                shape.draw(gr, penNotSel, penSel);
        }
        //public void createNewShape()
        //{
        //    resetAllSelections();
        //    shapes.Add()
        //}
        public void setMultiSelection()
        {
            isMultiSelection = !isMultiSelection;
        }
        public void addNewShape(Shape shape, int x, int y)
        {
            if (shape != null)
            {
                resetAllSelections();
                Shape newShape = shape.clone();
                newShape.setX(x);
                newShape.setY(y);
                newShape.setSelection(true);
                shapes.Add(newShape);
            }
        }
    }
}
