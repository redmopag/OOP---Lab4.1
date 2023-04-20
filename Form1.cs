using Project.Source.Shapes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class FormMain : Form
    {
        // Списко фигур-прототипов
        private List<Shape> prototypes = new List<Shape>() { new CCircle() };
        // Нажата ли клавиша ctrl
        private bool isCtrl = false;
        // Флаг для выбора нескольких элементов при одном нажатии
        private bool isMultiTuch = false;
        // Создание списка фигур
        private List<Shape> shapes = new List<Shape>();

        // Инициализация обхектов Pen для прорисовки объектов:
        // Толщина ручки
        private const float penWidth = 1f;
        // Цвет для не выделенных объектов
        private readonly Pen penNotSelection = new Pen(Color.Black, penWidth);
        // Цвет для выделенных объектов
        private readonly Pen penSelection = new Pen(Color.Green, penWidth);

        public FormMain()
        {
            InitializeComponent();
        }

        // Снимает все выделения фигур
        private void resetAllSelections()
        {
            foreach (Shape shape in shapes)
                shape.setSelection(false);
        }
        // Обходит контейнер фигур и проверяет, попал ли курсор в одну из фигур
        // Если попал, возвращает true, а также отмечает подходящие фигуры как выбранные
        // Учитывает возможность одинарного и множественного выделения через ctrl
        private bool inShapeContainer(int x, int y)
        {
            bool flagInCont = false;
            if (!isCtrl)
                resetAllSelections();
            foreach (Shape shape in shapes)
            {
                if (shape.inShape(x, y))
                {
                    shape.setSelection(true);
                    flagInCont = true;
                    if(!isCtrl)
                    {

                        break;
                    }
                }
            }
            return flagInCont;
        }
        private void pictureBoxDrawFigure_MouseDown(object sender, MouseEventArgs e)
        {
            // Проверяем, если не попали ни в одну фигуру, то создаём новую
            // Пока что используя (или патаясь использовать) паттерн прототип :)
            if (!inShapeContainer(e.X, e.Y))
            {
                resetAllSelections();
                shapes.Add(prototypes[0].createShape(e.X, e.Y));
                shapes.Last().setSelection(true);
            }
            pictureBoxDrawFigure.Refresh();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Delete:
                    for (int i = 0; i < shapes.Count; ++i)
                        if (shapes[i].getSelection())
                            shapes.RemoveAt(i--);
                    pictureBoxDrawFigure.Refresh();
                    break;
                case Keys.ControlKey:
                    isCtrl = true;
                    checkBoxCtrl.Checked = isCtrl;
                    break;
            }
        }

        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            // Если отпущена кнопка ctrl, флаг "выключается" = false
            isCtrl = (e.KeyCode == Keys.ControlKey) ? false : true;
            checkBoxCtrl.Checked = isCtrl;
        }

        private void pictureBoxDrawFigure_Paint(object sender, PaintEventArgs e)
        {
            foreach (Shape shape in shapes)
                shape.draw(e.Graphics, penNotSelection, penSelection);
        }

        private void checkBoxCtrl_CheckedChanged(object sender, EventArgs e)
        {
            // Если галочка поставлена - ctrl включен
            isCtrl = ((sender as CheckBox).Checked) ? true : false;
        }
    }
}
