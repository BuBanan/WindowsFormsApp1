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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private bool move = false;//переменная определяющая движение
        private void btnStart_Click(object sender, EventArgs e)
        {
            if (move)//если картинка двигается то
            {//при нажатии она остановится
                tmr.Stop();
                btnStart.Text = "Start";
                move = false;
            }
            else if (pct.Left + pct.Width > this.Width)
            {//если картинка на краю формы то пр нажатии она возвращается в начальное положение
                pct.Left = 0;
                move = false;
            }
            else
            {//картинка начинает двигаться
                tmr.Start();
                btnStart.Text = "Stop";
                move = true;
                tmr.Interval = 50;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tmr_Tick(object sender, EventArgs e)
        {
            pct.Left = pct.Left + 20;//движение картинки
            if (pct.Left + pct.Width > this.Width)//если картинка коснулась края движение останавливается
            {
                tmr.Stop();
                btnStart.Text = "Start";
                return;
            }
        }
    }
}
