using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArendaAvtoBaryshev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a;
            a = Convert.ToInt32(textBox1.Text);
            if (radioButton1.Checked)
            {
                a = (a * 60);
                textBox2.Text = Convert.ToString(a);
            }
            else if (radioButton2.Checked)
            {
                a = (a * 25);
                textBox2.Text = Convert.ToString(a);
            }
            else
            {
                a = (a * 30);
                textBox2.Text = Convert.ToString(a);
            }
        }
    }
}
