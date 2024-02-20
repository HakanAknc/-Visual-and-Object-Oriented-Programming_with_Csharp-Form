using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Trafik_Lambasi_Uygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void BtnBaslat_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void BtnDurdur_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        int sayac = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            this.Text = sayac.ToString();
            sayac++;
            if (sayac >= 0 &&  sayac <= 30)
            {
                panel1.BackColor = Color.Red;
                panel3.BackColor = Color.Transparent;
            }
            if (sayac > 30 && sayac <= 40)
            {
                panel2.BackColor = Color.Yellow;
            }
            if (sayac > 40 && sayac <= 70)
            {
                panel3.BackColor = Color.Green;
                panel1.BackColor = Color.Transparent;
                panel2.BackColor = Color.Transparent;
            }
            if (sayac == 70)
            {
                sayac = 0;
            }
        }
    }
}
