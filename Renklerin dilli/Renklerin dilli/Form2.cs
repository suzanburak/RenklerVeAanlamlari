using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Renklerin_dilli
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.Text=="Mavi")
            {

                label4.Text = textBox1.Text + "  " + comboBox1.Text + " Rengi=" + "Mutluluğun  ve pozitifliğin rengidir";

            }
            if (comboBox1.Text=="Sarı")
            {

                label4.Text = textBox1.Text + "  " + comboBox1.Text + "  Rengi=" + "iyimserliğin rengidir";

            }

            if (comboBox1.Text == "Yeşil")
            { 
         
                label4.Text = textBox1.Text + "  " + comboBox1.Text + "  Rengi=" + "insana güven ve huzur verir; ayrıca, yeşil umudu temsil eder.";

            }
            if ( comboBox1.Text=="Kırmızı")
            {

                label4.Text = textBox1.Text + "  " + comboBox1.Text + "Rengi= " + "Enerjinin rengidir. Duyguları uyandırarak harekete geçme hissi uyandırır";
            }
        }
    }
}
