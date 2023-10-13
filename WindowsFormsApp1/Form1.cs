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
    public partial class Form1 : Form
    {
        Label firstClicked = null;
        Label secondClicked = null;
        Random random = new Random(); //добавление случайного объекта
        List<string> icons = new List<string>()//добавление списка иконок
        {
            "!", "!", "N", "N", ",", ",", "k", "k",
            "b", "b", "v", "v", "w", "w", "z", "z"
        };
        public Form1()
        {
            InitializeComponent();
            AssignIconsToSquares();
        }
        private void AssignIconsToSquares()// выполняет итерацию каждого элемента управления label в TableLayoutPanel
        {//Эти операторы запрашивают случайные значки из списка.
            foreach (Control control in tableLayoutPanel1.Controls) // преобразует переменную control в метку с именем iconLabel
            {
                Label iconLabel = control as Label;

                if (iconLabel != null)/*оператор if, проверяющий и обеспечивающий успешное выполнение преобразования.
                                       * Если преобразование выполняется, выполняются операторы в операторе if.*/

                {
                    int randomNumber = random.Next(icons.Count);
                    iconLabel.Text = icons[randomNumber];
                    iconLabel.ForeColor = iconLabel.BackColor;
                    icons.RemoveAt(randomNumber);
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)//при клике на label отображается скрытая картинка
        {
            if (timer1.Enabled == true)// включен ли таймер, задает ссылочную переменную secondClicked и запускает таймер
                return;
            Label clickedLabel = sender as Label;
            if (clickedLabel != null)
            {
                if (clickedLabel.ForeColor == Color.Black)
                    return;
                if (firstClicked == null)
                {
                    firstClicked = clickedLabel;
                    firstClicked.ForeColor = Color.Black;
                    return;
                }
                secondClicked = clickedLabel;//исчезновение иконок при не правильном выборе и их сохранение при правильном
                secondClicked.ForeColor = Color.Black;
                secondClicked = clickedLabel;
                secondClicked.ForeColor = Color.Black;
                CheckForWinner();
                if (firstClicked.Text == secondClicked.Text)
                {
                    firstClicked = null;
                    secondClicked = null;
                    return;
                }
                timer1.Start();
            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();//Останавливает таймер
            firstClicked.ForeColor = firstClicked.BackColor;/* снова сделает невидимыми значки двух меток,
                                                             * которые выбрал игрок*/
            secondClicked.ForeColor = secondClicked.BackColor;
            firstClicked = null;//Сбрасывает значения
            secondClicked = null;
        }
        private void CheckForWinner()
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                Label iconLabel = control as Label;
                if (iconLabel != null)
                {
                    if (iconLabel.ForeColor == iconLabel.BackColor)
                        return;
                }
            }
            MessageBox.Show("Крч ты молодец теперь удали это и иди играть в нормальную игру");
            Close();
        }
    }
}
