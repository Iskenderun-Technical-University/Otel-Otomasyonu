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
    public partial class Mesajlar : Form
    {
        public Mesajlar()
        {
            InitializeComponent();
        }

        SqlConnection Baglan = new SqlConnection(@"Data Source=DESKTOP-8O7HHSH\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        private void verilerigoster()
        {
            listView1.Items.Clear();
            Baglan.Open();
            SqlCommand Kom = new SqlCommand("Select*from Mesajlar", Baglan);
            SqlDataReader oku = Kom.ExecuteReader();
            while (oku.Read())
            {
                ListViewItem ekle = new ListViewItem();
                ekle.Text = oku["Mesajid"].ToString();
                ekle.SubItems.Add(oku["Adsoyad"].ToString());
                ekle.SubItems.Add(oku["Mesaj"].ToString());

                listView1.Items.Add(ekle);

            }
            Baglan.Close();
        }

            private void btnmesajkaydet_Click(object sender, EventArgs e)
        {
            Baglan.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Mesajlar(Adsoyad,Mesaj) values('" + txtmesajadsoyad.Text + "','" + richTextBox1.Text + "')", Baglan);
            komut.ExecuteNonQuery();
            Baglan.Close();
            verilerigoster();
        }

        private void Mesajlar_Load(object sender, EventArgs e)
        {
            verilerigoster();
        }
        int id = 0;
        private void listView1_DoubleClick(object sender, EventArgs e)
        {
            id = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);
            txtmesajadsoyad.Text = listView1.SelectedItems[0].SubItems[1].Text;
            richTextBox1.Text = listView1.SelectedItems[0].SubItems[2].Text;
        }

        private void txtmesajadsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
