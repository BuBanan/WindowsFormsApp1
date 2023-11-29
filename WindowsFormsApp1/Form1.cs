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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonCalc_Click(object sender, EventArgs e)
        {
            // считываем с формы требуемые значени
            double min = double.Parse(Xmin.Text);
            double max = double.Parse(Xmax.Text);
            double St = double.Parse(Step.Text);
            // количество точек графика
            int count = (int)Math.Ceiling((max - min) / St)
                + 1;
            // массив значений X - общий для обоих графиков
            double[] X = new double[count];
            double[] y1 = new double[count];
            double[] y2 = new double[count];
            // расчитываем точки для графиков функции
            for (int i = 0; i < count; i++)
            {
                // вычисляем значение
                X[i] = min + St * i;
                // вычисляем значение функций в точке X
                y1[i] = Math.Sin(X[i]);
                y2[i] = Math.Cos(X[i]);
            }
            // настраиваем оси графика
            chart1.ChartAreas[0].AxisX.Minimum = min;
            chart1.ChartAreas[0].AxisX.Maximum = max;
            // определяем шаг сетки 
            chart1.ChartAreas[0].AxisX.MajorGrid.Interval = St;
            // добавляем вычисление значения в графики
            chart1.Series[0].Points.DataBindXY(X, y1);
            chart1.Series[1].Points.DataBindXY(X, y2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
        }
    }
}
