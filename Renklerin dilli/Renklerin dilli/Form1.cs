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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text=="zozan burak"&& textBox2.Text == "6521")
            {
                Form2 renkform= new Form2();
                renkform.Show();
                this.Hide();
            }
            else
                {

                    MessageBox.Show("Lütfen şu allahın cezası şifreyi doğru girermisin alt tarafı 6521 yazıcan haa");
                    textBox1.Clear();
                    textBox2.Clear();
                }
            
        }
    }
}
