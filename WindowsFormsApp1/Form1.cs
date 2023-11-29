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
        public Form1()
        {
            InitializeComponent();
        }

        private int NumberSymbols(string stroka, char symbol)
        {
            // создание переменной для подсчета количества символов в строке
            int k = 0;
            // цикл для прохода по каждому символу в строке
            for (int i = 0; i < stroka.Length; i++)
            {
                // если символы совпадают увеличиваем счетчик
                if (stroka[i] == symbol)
                {
                    k += 1;
                }
            }
            // возврат общего количества найденных символов в строке
            return k;
        }
        private int NumberMA(string stroka)
        {
            // создание переменной для подсчета сочитания символов "ма"
            int ma = 0;
            // цикл для прохода по каждому символу текста за исключением последнего
            for (int i = 0; i < str.Text.Length - 1; i++)
            {
                // если в строке символ равен М и А значение ma увеличивается на 1
                // проверка совпадает ли текущий и следующий символы с "м" и "а"
                if (str.Text[i] == 'м' && str.Text[i + 1] == 'а')
                {
                    // увеличение счетчика в случае обнаружения сочетания "ма"
                    ma++;
                }
            }
            // возврат общего количества встреч символов "ма" в тексте
            return ma;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // сохранение введенного пользователем текста в переменную inputText.
            string inputText = symb.Text;
            // преобразование строкового типа данных в символьный
            char ch = char.Parse(symb.Text);
            // вызывается метод NumberSymbols для подсчета количества символов в строке
            {
                // вывод количества символов 'а' в текстовое поле Nsymb.
                Nsymb.Text = NumberSymbols(str.Text, ch).ToString();
            }
            // вызывается метод NumberMA для подсчета количества "ма" в строке
            // вывод количества вхождений подстроки 'ма' в текстовое поле Nma
            Nma.Text = NumberMA(str.Text).ToString();
        }
    }
}
