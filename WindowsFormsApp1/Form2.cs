using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Paint(object sender, PaintEventArgs e)
        {
            //изменение цвета фона
            this.BackColor = Color.LightGray;
            //создание объекта graphics
            Graphics g = e.Graphics;
            //Создание пера для рисования линий
            Pen blackPen = new Pen(Color.Black, 3);
            //Создание переменных для объектов заливки
            SolidBrush solidBlack = new SolidBrush(Color.Black);
            SolidBrush solidWhite = new SolidBrush(Color.White);
            SolidBrush solidRed = new SolidBrush(Color.Red);
            SolidBrush solidBlue = new SolidBrush(Color.Blue);
            // Рисуем корпус машины
            g.FillRectangle(solidRed, 200, 200, 440, 50);

            // Рисуем верхнюю часть машины пером
            Point[] roofPoints =
            {
                 new Point(200, 200),
                 new Point(300, 150),
                 new Point(440, 150),
                 new Point(600, 200)
            };
            g.DrawLines(blackPen, roofPoints);

            // Рисуем окно
            Point point1 = new Point (202, 200);
            Point point2 = new Point (301, 151);
            Point point3 = new Point (439, 151);
            Point point4 = new Point (597, 200);
            Point[] curvePoints = { point1, point2, point3, point4 };
            e.Graphics.FillPolygon(solidBlue, curvePoints);
            // Рисуем колеса
            g.FillEllipse(solidBlack, 550, 250, 70, 70);
            g.FillEllipse(solidBlack, 230, 250, 70, 70);
            // рисуем диски
            g.FillEllipse(solidWhite, 555, 255, 60, 60);
            g.FillEllipse(solidWhite, 235, 255, 60, 60);

            //Рисуем верхнюю и нижнюю часть дороги
            g.DrawLine(blackPen, 0, 250, 800, 250);
            g.DrawLine(blackPen, 0, 350, 800, 350);
        }
    }
}
