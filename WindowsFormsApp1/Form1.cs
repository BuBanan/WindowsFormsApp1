using System;
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
    public partial class Lab5 : Form
    {
        public Lab5()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            DateTime currentTime = DateTime.Now; //добавление времени которое сейчас
            textBox1.Text = currentTime.ToString();
            int fromX = int.Parse(txtX1.Text); //Добавим переменные, которые проассоциируем с данными текстовыми полями
            int toX = int.Parse(txtX2.Text);
            int fromY = int.Parse(txtY1.Text);
            int toY = int.Parse(txtY2.Text);
        if (fromX > toX)//проверить вводимый диапазон
        {
            MessageBox.Show("Интервал должен быть от меньшего к большему");
            txtX1.Text = "";
            txtX2.Text = "";
        }
        if (fromY > toY)//проверить вводимый диапазон
        int tmp;//добавляем переменные для минут и секунд
        int min;
        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            MessageBox.Show("Интервал должен быть от меньшего к большему");
            txtY1.Text = "";
            txtY2.Text = "";
        }
            for (int x = fromX; x <= toX; x++)//5.	Сейчас можно создать вложенный цикл для расчета функции z(x,y) = x - y
            int tmp = Int32.Parse(txtSeconds.Text);//преобразуем строковое начение в численное
            int min = Int32.Parse(txtMinues.Text);
            if (tmp >= 60)//перевод секунд в минуты
            {
                    for (int y = fromY; y <= toY; y++)//6.	Результаты вычислений будут добавляться в — list box
                    { 
                        lstResult.Items.Add($"z(x,y) = {x} - {y} = {x - y}");
                    }
            }
                min += 1;
                txtMinues.Text = min.ToString();
                tmp = 0;
                txtSeconds.Text = tmp.ToString();
            }
            else//увеличение таймера секунд каждый тик
            {
                tmp += 1;
                txtSeconds.Text = tmp.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)//запуск и остановка таймера на кнопку
        {
            tmrSecundomer.Enabled = !tmrSecundomer.Enabled;
        }

        private void zero_Click(object sender, EventArgs e)//обнуление показателей таймера
        {
            tmp = 0;
            txtSeconds.Text = tmp.ToString();
            min = 0;
            txtMinues.Text = min.ToString();
        }
    }
}
