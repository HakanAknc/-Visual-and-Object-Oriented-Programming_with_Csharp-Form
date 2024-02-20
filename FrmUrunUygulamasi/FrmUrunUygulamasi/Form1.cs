using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FrmUrunUygulamasi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection baglanti = new SqlConnection("Data Source=DESKTOP-8C8KD0P\\SQLEXPRESS;Initial Catalog=DbUrun;Integrated Security=True");

        private void Form1_Load(object sender, EventArgs e)
        {
            SqlCommand komut1 = new SqlCommand("Select UrunId, UrunAd, Stok, AlisFiyat, SatisFiyat, Ad, Kategori From TBLURUNLER Inner Join TBLKATEGORI On TBLURUNLER.Kategori=TBLKATEGORI.ID", baglanti);
            SqlDataAdapter da = new SqlDataAdapter(komut1);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1 = new DataGridView();
            //dataGridView1.Columns["Kategori"].Visible = false;  //Kullanıcılara gözükmesin
        }
        private void FrmUrun_Load(object sender, EventArgs e)
        {
            SqlCommand komut2 = new SqlCommand("Select * From TBLKATEGORI", baglanti);
            SqlDataAdapter da2 = new SqlDataAdapter(komut2);
            DataTable dt2 = new DataTable();
            da2.Fill(dt2);
            comboBox1.DisplayMember = "Ad";   //kullanıcıya gözükücek olan kısım
            comboBox1.ValueMember = "ID";
            comboBox1.DataSource = dt2;
        }

        private void BtnListele_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            SqlCommand komut3 = new SqlCommand("insert into TblUrunler (UrunAd, Stok, AlisFiyat, SatisFiyat, Kategori) values (@p1, @p2, @p3, @p4, @p5)", baglanti);
            komut3.Parameters.AddWithValue("@p1", TxtAd.Text);
            komut3.Parameters.AddWithValue("@p2", NudStok.Value);
            komut3.Parameters.AddWithValue("@p3", TxtAlisFiyat.Text);
            komut3.Parameters.AddWithValue("@p4", TxtSatisFiyat.Text);
            komut3.Parameters.AddWithValue("@p5", comboBox1.SelectedValue);
            //komut3.ExecuteNonQuery();
            baglanti.Close();
            MessageBox.Show("Ürün kaydı başarılı bir şekilde gerçekleşti.");
        }
    }
}
