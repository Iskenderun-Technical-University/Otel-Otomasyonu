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
    public partial class Musteriler : Form
    {
        public Musteriler()
        {
            InitializeComponent();
        }

        SqlConnection Baglan = new SqlConnection(@"Data Source=DESKTOP-8O7HHSH\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            Baglan.Open();
            SqlCommand Kom = new SqlCommand("Select*from Musteri_Ekle", Baglan);
            SqlDataReader oku = Kom.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriıd"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GırısTarihi"].ToString());
                ekle.SubItems.Add(oku["CıkısTarihi"].ToString());
                listView1.Items.Add(ekle);

            }
            Baglan.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtadi.Text = listView1.SelectedItems[0].SubItems[1].Text;
            txtsoyadi.Text = listView1.SelectedItems[0].SubItems[2].Text;
            msk_txttelefon.Text = listView1.SelectedItems[0].SubItems[3].Text;
            txtmail.Text = listView1.SelectedItems[0].SubItems[4].Text;
            txttc.Text = listView1.SelectedItems[0].SubItems[5].Text;
            txtodano.Text = listView1.SelectedItems[0].SubItems[6].Text;
            txtucret.Text = listView1.SelectedItems[0].SubItems[7].Text;
            dategiris.Text = listView1.SelectedItems[0].SubItems[8].Text;
            datecıkıs.Text = listView1.SelectedItems[0].SubItems[9].Text;



        }

        private void btnsil_Click(object sender, EventArgs e)
        {
            if (txtodano.Text == "101")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda101", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "102")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda102", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "103")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda103", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "104")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda104", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "105")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda105", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "106")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda106", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "107")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda107", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "108")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda108", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "201")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda201", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "202")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda202", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "203")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda203", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "204")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda204", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "205")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda205", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "206")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda206", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "207")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda207", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "208")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda208", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "301")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda301", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "302")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda302", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "303")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda303", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "304")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda304", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "305")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda305", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "306")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda306", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "307")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda307", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
            if (txtodano.Text == "308")
            {
                Baglan.Open();
                SqlCommand komut = new SqlCommand("delete from oda308", Baglan);
                komut.ExecuteNonQuery();
                Baglan.Close();
                verilerigoster();
            }
        }

        private void btntemizle_Click(object sender, EventArgs e)
        {
            txtadi.Clear();
            txtsoyadi.Clear();
            msk_txttelefon.Clear();
            txtmail.Clear();
            txttc.Clear();
            txtodano.Clear();
            txtucret.Clear();
            dategiris.Text="";
            datecıkıs.Text="";
           
        }

        private void btnguncelle_Click(object sender, EventArgs e)
        {
            Baglan.Open();
            SqlCommand komut = new SqlCommand("update Musteri_Ekle set Adi='" + txtadi.Text + "',Soyadi='" + txtsoyadi.Text + "',Telefon='" + msk_txttelefon.Text + "',Mail='"+txtmail.Text+ "',TC='"+txttc.Text+ "',OdaNo='"+txtodano.Text+ "',Ucret='"+txtucret.Text+ "',GırısTarihi='"+dategiris.Value.ToString("yyyy-MM-dd")+ "',CıkısTarihi='" + datecıkıs.Value.ToString("yyyy-MM-dd") + "' where Musteriıd=" + id + "", Baglan);
            komut.ExecuteNonQuery();
            Baglan.Close();
            verilerigoster();
        }

        private void btnara_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Baglan.Open();
            SqlCommand Kom = new SqlCommand("Select * from Musteri_Ekle where Adi like '%"+textBox1.Text+"%'", Baglan);
            SqlDataReader oku = Kom.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Musteriıd"].ToString();
                ekle.SubItems.Add(oku["Adi"].ToString());
                ekle.SubItems.Add(oku["Soyadi"].ToString());
                ekle.SubItems.Add(oku["Telefon"].ToString());
                ekle.SubItems.Add(oku["Mail"].ToString());
                ekle.SubItems.Add(oku["TC"].ToString());
                ekle.SubItems.Add(oku["OdaNo"].ToString());
                ekle.SubItems.Add(oku["Ucret"].ToString());
                ekle.SubItems.Add(oku["GırısTarihi"].ToString());
                ekle.SubItems.Add(oku["CıkısTarihi"].ToString());
                listView1.Items.Add(ekle);

            }
            Baglan.Close();
        }
    }
}
