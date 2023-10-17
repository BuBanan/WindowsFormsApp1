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
            DateTime currentTime = DateTime.Now;
            textBox1.Text = currentTime.ToString();
        }
        int tmp;
        int min;
        private void tmrSecundomer_Tick(object sender, EventArgs e)
        {
            int tmp = Int32.Parse(txtSeconds.Text);
            int min = Int32.Parse(txtMinues.Text);
            if (tmp >= 60)
            {
                min += 1;
                txtMinues.Text = min.ToString();
                tmp = 0;
                txtSeconds.Text = tmp.ToString();
            }
            else
            {
                tmp += 1;
                txtSeconds.Text = tmp.ToString();
            }
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            tmrSecundomer.Enabled = !tmrSecundomer.Enabled;
        }

        private void zero_Click(object sender, EventArgs e)
        {
            tmp = 0;
            txtSeconds.Text = tmp.ToString();
            min = 0;
            txtMinues.Text = min.ToString();
        }
    }
}
