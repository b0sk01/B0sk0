using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DostavkaBaryshev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
            {
                a = ((a * 10) + 500);
                textBox2.Text = Convert.ToString(a);
            }
            else if (radioButton2.Checked) ;
            {
                a = (a * 10);
                textBox2.Text = Convert.ToString(a);
            }
        }
    }
}
