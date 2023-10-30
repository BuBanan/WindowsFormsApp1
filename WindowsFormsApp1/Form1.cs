using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            //считываем значения с текст бокса
            double x, precision;

            if (double.TryParse(txtX.Text, out x) && double.TryParse(txtPrecision.Text, out precision))//проверка данных
            {
                double sum = 0;
                double slog = x;
                int addslog = 1;
                bool f = false;
                // выполняются вычисления до заданой точности или более
                while (Math.Abs(slog) >= precision)
                {
                    // добавляем слогаемое к сумме
                    sum += slog;
                    // увеличиваем кол-во слогаемых
                    addslog++;
                    // вычисляем новое слогаемое
                    slog = x / addslog;
                }
                // выводим результаты
                lblResult.Text = "sum = " + sum.ToString();
                lblQuantity.Text = "quantity = " + addslog.ToString();
                f = true;
            }
            else
            {
                MessageBox.Show("Введите корректные значения");
            }
        }
    }
}

