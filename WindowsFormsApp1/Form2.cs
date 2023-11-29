using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            //сичтаем с формы требуемые значени
            double min = double.Parse(Xmin.Text);
            double max = double.Parse(Xmax.Text);
            double St = double.Parse(Step.Text);
            //количество точек графика
            int count = (int)Math.Ceiling((max - min) / St)
                + 1;
            //массив значений X - общий для обоих графиков
            double[] X = new double[count];
            double[] y1 = new double[count];
            double[] y2 = new double[count];
            //расчитываем точки для графиков функции
            for (int i = 0; i < count; i++)
            {
                //вычисляем значение
                X[i] = min + St * i;
                //вычисляем значение функций в точке X
                y1[i] = (Math.Pow(X[i], 5/2) - 0.8*Math.Log(Math.Pow(X[i], 2) + 12,7));
                y2[i] = (Math.Pow(X[i], 7) + 5 * X[i] - 7);
            }
            //настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = min;
            chart1.ChartAreas[0].AxisX.Maximum = max;
            //определяем шаг сетки 
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = St;

            //добавляем вычисление значения в графики
            chart1.Series[0].Points.DataBindXY(X, y1);
            chart1.Series[1].Points.DataBindXY(X, y2);
        }
    }
}
