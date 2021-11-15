using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BaryshevZadacha
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
         if (comboBox1.SelectedIndex ==0)
            { textBox1.Text = "1";
              textBox2.Text = "ЭСиКС";
              textBox3.Text = "Информационные системы"; 
            }
            else if (comboBox1.SelectedIndex == 1)
            { textBox1.Text = "2";
              textBox2.Text = "ЭСиКС";
              textBox3.Text = "Компьютерные сети"; 
            }
            else 
            {
                textBox1.Text = "3";
                textBox2.Text = "ПХК";
                textBox3.Text = "Земельно имущественные отношения"; 
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form Form2 = new Form2();
            Form2.Show();
        }
    }
}
