﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
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

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            double x1 = double.Parse(txt_x.Text);
            double y1 = double.Parse(txt_y.Text);
            // считываем с формы требуемые значени
            double min = double.Parse(Xmin.Text);
            double max = double.Parse(Xmax.Text);
            double St = double.Parse(Step.Text);
            // количество точек графика
            int count = (int)Math.Ceiling((max - min) / St)
                + 1;
            // массив значений X - общий для обоих графиков
            double[] X = new double[count];
            double[] y = new double[count];
            // расчитываем точки для графиков функции
            for (int i = 0; i < count; i++)
            {
                // вычисляем значение
                X[i] = min + St * i;
                // вычисляем значение функций в точке X
                y[i] = Math.Pow(2,-x1) * Math.Sqrt(x1+);
            }
            // настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = min;
            chart1.ChartAreas[0].AxisX.Maximum = max;
            // определяем шаг сетки 
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = St;
            // добавляем вычисление значения в графики
            chart1.Series[0].Points.DataBindXY(X, y);
        }

        private void Xmin_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && num != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46))
            {
                e.Handled = true;
            }
        }

        private void Xmax_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && num != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46))
            {
                e.Handled = true;
            }
        }

        private void Step_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && num != 8 && num != 44)
            {
                e.Handled = true;
            }
        }

        private void txt_x_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && num != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46))
            {
                e.Handled = true;
            }
        }

        private void txt_y_KeyPress(object sender, KeyPressEventArgs e)
        {
            char num = e.KeyChar;
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && num != 8 && (e.KeyChar <= 39 || e.KeyChar >= 46))
            {
                e.Handled = true;
            }
        }
    }
}
