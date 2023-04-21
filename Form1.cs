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

using Project.Source;

namespace Project
{
    public partial class FormMain : Form
    {
        // Списко фигур-прототипов
        private List<Shape> prototypes = new List<Shape>() { new CCircle() };
        Shape shape;
        // Контейнер, хранящий фигуры и мтоды работы с ними
        private Project.Source.Container shapes = new Project.Source.Container();

        // Инициализация объектов Pen для прорисовки объектов:
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

        private void pictureBoxDrawFigure_MouseDown(object sender, MouseEventArgs e)
        {
            // Проверяем, если не попали ни в одну фигуру, то создаём новую
            // Пока что используя (или патаясь использовать) паттерн прототип :)
            if (!shapes.inShapeContainer(e.X, e.Y))
            {
                shapes.addNewShape(shape, e.X, e.Y);
            }
            pictureBoxDrawFigure.Refresh();
        }

        private void FormMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.Delete:
                    shapes.removeSelctions();
                    pictureBoxDrawFigure.Refresh();
                    break;
                case Keys.ControlKey:
                    shapes.setCtrl(true, checkBoxCtrl);
                    break;
            }
        }
        private void FormMain_KeyUp(object sender, KeyEventArgs e)
        {
            // Если отпущена кнопка ctrl, флаг "выключается" = false
            if (e.KeyCode == Keys.ControlKey)
                shapes.setCtrl(false, checkBoxCtrl);
        }

        private void pictureBoxDrawFigure_Paint(object sender, PaintEventArgs e)
        {
            shapes.drawShapes(e.Graphics, penNotSelection, penSelection);
        }

        private void checkBoxCtrl_Click(object sender, EventArgs e)
        {
            // Если галочка поставлена - ctrl включен
            shapes.setCtrl(((sender as CheckBox).Checked));
        }

        private void checkBoxMultiSelection_Click(object sender, EventArgs e)
        {
            shapes.setMultiSelection();
        }

        private void buttonCircle_Click(object sender, EventArgs e)
        {
            shape = prototypes[0];
        }
    }
}
