using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;

namespace Otel_Otomasyonu
{
    public partial class Gelirgider : Form
    {
        public Gelirgider()
        {
            InitializeComponent();
        }
        SqlConnection Baglantı = new SqlConnection("Data Source=DESKTOP-8O7HHSH\\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");

        private void button1_Click(object sender, EventArgs e)
        {
            int sonuc;
            sonuc = Convert.ToInt32(lblkasatoplam.Text)- (Convert.ToInt32(lblpersonelmaas.Text) + Convert.ToInt32(lblgida.Text) + Convert.ToInt32(lblicecek.Text) + Convert.ToInt32(lblcerez.Text) + Convert.ToInt32(lblelektrik.Text) + Convert.ToInt32(lblsu.Text) + Convert.ToInt32(lblinternet.Text));
            lblsonuc.Text = sonuc.ToString();
        }

        private void Gelirgider_Load(object sender, EventArgs e)
        {
            // kasadaki toplam tutar

            Baglantı.Open();
            SqlCommand komut = new SqlCommand("Select sum(Ucret) as toplam from Musteri_Ekle", Baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                lblkasatoplam.Text = oku["toplam"].ToString();
            }
            Baglantı.Close();

            // Gıda giderleri

            Baglantı.Open();
            SqlCommand komut2 = new SqlCommand("Select sum(Gida) as toplam1 from Stoklar", Baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                lblgida.Text = oku2["toplam1"].ToString();
            }
            Baglantı.Close();

            // Icecek giderleri

            Baglantı.Open();
            SqlCommand komut3 = new SqlCommand("Select sum(Icecek) as toplam2 from Stoklar", Baglantı);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                lblicecek.Text = oku3["toplam2"].ToString();
            }
            Baglantı.Close();

            // Cerezler Giderleri

            Baglantı.Open();
            SqlCommand komut4 = new SqlCommand("Select sum(Cerezler) as toplam3 from Stoklar", Baglantı);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                lblcerez.Text = oku4["toplam3"].ToString();
            }
            Baglantı.Close();

            // elektrik

            Baglantı.Open();
            SqlCommand komut5 = new SqlCommand("Select sum(Elektrik) as toplam4 from Faturalar", Baglantı);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                lblelektrik.Text = oku5["toplam4"].ToString();
            }
            Baglantı.Close();

            // su

            Baglantı.Open();
            SqlCommand komut6 = new SqlCommand("Select sum(Su) as toplam5 from Faturalar", Baglantı);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                lblsu.Text = oku6["toplam5"].ToString();
            }
            Baglantı.Close();

            // internet

            Baglantı.Open();
            SqlCommand komut7 = new SqlCommand("Select sum(Internet) as toplam6 from Faturalar", Baglantı);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                lblinternet.Text = oku7["toplam6"].ToString();
            }
            Baglantı.Close();


        }

        private void button2_Click(object sender, EventArgs e)
        {
            int personel;
            personel = Convert.ToInt16(textBox1.Text);
            lblpersonelmaas.Text = (personel * 3000).ToString();
        }
    }
}
