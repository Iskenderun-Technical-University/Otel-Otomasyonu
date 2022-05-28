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
    public partial class StokEkrani : Form
    {
        public StokEkrani()
        {
            InitializeComponent();
        }
        SqlConnection Baglantı = new SqlConnection("Data Source=DESKTOP-8O7HHSH\\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        private void veriler()
        {
            listView1.Items.Clear();
            Baglantı.Open();
            SqlCommand komut = new SqlCommand("select * from Stoklar", Baglantı);
            SqlDataReader oku = komut.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Gida"].ToString();
                ekle.SubItems.Add(oku["Icecek"].ToString());
                ekle.SubItems.Add(oku["Cerezler"].ToString());
                listView1.Items.Add(ekle);
            }
            Baglantı.Close();

        }
        private void veriler2()
        {
            listView2.Items.Clear();
            Baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select * from Faturalar", Baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku2["Elektrik"].ToString();
                ekle.SubItems.Add(oku2["Su"].ToString());
                ekle.SubItems.Add(oku2["Internet"].ToString());
                listView2.Items.Add(ekle);
            }
            Baglantı.Close();
        }
        private void btnkaydet_Click(object sender, EventArgs e)
        {
            Baglantı.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Stoklar(Gida,Icecek,Cerezler) values ('" + txtgıda.Text + "','" + txticecek.Text + "','" + txtcerez.Text + "')", Baglantı);
            komut.ExecuteNonQuery();
            Baglantı.Close();
            veriler();
        }

        private void StokEkrani_Load(object sender, EventArgs e)
        {
            veriler();
            veriler2();
        }

        private void btnkaydet2_Click(object sender, EventArgs e)
        {
            Baglantı.Open();
            SqlCommand komut2 = new SqlCommand("INSERT INTO Faturalar(Elektrik,Su,Internet) values ('" + txtelektrik.Text + "','" + txtsu.Text + "','" + txtinternet.Text + "')", Baglantı);
            komut2.ExecuteNonQuery();
            Baglantı.Close();
            veriler2();
        }
    }
}
