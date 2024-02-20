using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temel_Arac_Kullanimi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)   // butona klik edildiği zaman
        {
            //label6.Text = "İstanbul";    // label6'nın text kısmında : İstanbul yazdır.
            label8.Text = textBox1.Text;
            //textBox1.Text = "Hakan";
            label6.Text = comboBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add("JavaScript");   // veri eklemk için ==> Itmes.add kullanılır.
            listBox1.Items.Add("PostgreSQL");
            comboBox1.Items.Add("Trabzon");
            listBox1.Items.Add(textBox1.Text);   // dışardan veri almak için.
        }
    }
}
