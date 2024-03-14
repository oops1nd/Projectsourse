using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app2._0
{
    public partial class Form2 : Form
    {
        public Form2(int t1, int t2, int t3, int t4, double t5, double t6, int t7, int t8, int t9 , int t10)
        {
            InitializeComponent();
            textBox1.Text = t1.ToString();
            textBox2.Text = t2.ToString();
            textBox3.Text = t3.ToString();
            textBox4.Text = t4.ToString();
            textBox5.Text = t5.ToString();
            textBox6.Text = t6.ToString();
            textBox7.Text = t7.ToString();
            textBox8.Text = t8.ToString();
            textBox9.Text = t9.ToString();
            textBox10.Text = t10.ToString();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }
    }
}
