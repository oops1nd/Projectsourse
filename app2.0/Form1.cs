using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace app2._0
{
    public partial class Form1 : Form
    {
        private List list;
        private StreamReader r;
        private StreamWriter f;
        public Form1()
        {
            InitializeComponent();
            list  = new List();
        }


        private void button1_Click(object sender, EventArgs e)
        {
            string country  = textBox1.Text;
            string city = textBox2.Text;
            string object_t = textBox3.Text;
            DateTime d = dateTimePicker1.Value;
            bool a = false;
            if (comboBox1.SelectedItem == "Активный") a = true;
            if (comboBox1.SelectedItem == "Пасивный") a = false;
            string otziv = textBox4.Text;
            int mark = Convert.ToInt32(textBox5.Text);
            Travel t = new Travel(country, city, object_t, d, a, otziv, mark);
            using (f = new StreamWriter("C:/Users/User/Documents/log/log.txt", true))
            {
                f.WriteLine(t.Country);
                f.WriteLine(t.City);
                f.WriteLine(t.Object_t);
                f.WriteLine(t.D);
                f.WriteLine(t.Active);
                f.WriteLine(t.Otziv);
                f.WriteLine(t.Mark);
            }
            list.Add(t);
            richTextBox1.Text = list.print();
            textBox1.Text = "";
            textBox2.Text = "";
            textBox3.Text = "";
            textBox4.Text = "";
            textBox5.Text = "";
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2(list.Size(), list.PC(), list.PCity(), list.PObject(), list.MO(),list.MR(), list.KPS(), list.KPF(), list.KA(), list.KP()); 
            form2.ShowDialog();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (r = new StreamReader("C:/Users/User/Documents/log/log.txt"))
            {
                while (r.EndOfStream!=true)
                {
                    string Country = r.ReadLine();
                    string City = r.ReadLine();
                    string Object_t = r.ReadLine();
                    string D = r.ReadLine();
                    string Active = r.ReadLine();
                    string Otziv = r.ReadLine();
                    string Mark = r.ReadLine();
                    Travel t = new Travel(Country, City, Object_t, Convert.ToDateTime(D), Convert.ToBoolean(Active), Otziv, Convert.ToInt32(Mark));
                    list.Add(t);
                }
            }
            richTextBox1.Text = list.print();
        }
    }
}
