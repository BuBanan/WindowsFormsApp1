using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void btnOpen_Click(object sender, EventArgs e)
        {
            string fileName = txt.Text;// получаем путь к файлу из текстового поля
            lstFromfile.Items.Clear(); // очищаем ListBox перед открытием нового файла
            /* используем using для создания FileStream и BinaryReader
            FileMode.Open позволяет окрыть файл для чтения
            FileStream позволяет одновременно читать и записывать*/
            using (FileStream fs = new FileStream(fileName, FileMode.Open))
            /* создаем BinaryReader для чтения данных из FileStream
           считывает данные произвольного типа как бинарные*/
            using (BinaryReader br = new BinaryReader(fs))
            {
                /* цикл который будет выполняться до тех пор пока не достигнут конец файла.
                метод PeekChar() возвращает следующий символ остявляя указатель в той же позиции. */
                while (br.PeekChar() != -1)
                {
                    lstFromfile.Items.Add(br.ReadString());// добавляем в элемент управления ListBox каждую строку прочитанную с использованием BinaryReader.
                }
                // закрываем BinaryReader и FileStream
                br.Close();
                fs.Close();
            }
        }
        //кнопка добавить
        private void btnAdd_Click(object sender, EventArgs e)
        {
            // добавляем текст из текстового поля в ListBox и очищаем текстовое поле
            lst.Items.Add(txt2.Text);
            txt2.Clear();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            string fileName = txt.Text; // пуmь к файлу из текстового поля
            if (File.Exists(fileName))// если файл существуеm
            {
                File.Delete(fileName);//удаляем его
            }
            // используем using для автоматического закрытия FileStream и BinaryWriter после использования
            // создаем файл или перезаписываем существующий
            using (FileStream fs = File.Create(fileName, 1024))
            using (BinaryWriter bw = new BinaryWriter(fs))// класс для работы с данными файла в двоичной виде
            {
                for (var i = 0; i < lst.Items.Count; i++)// пока не конец списка
                {
                    bw.Write(lst.Items[i].ToString());// записываем каждый элемент из элемента управления ListBox в файл
                }
                // закрываем BinaryWriter и FileStream
                bw.Close();
                fs.Close();
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
