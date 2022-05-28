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
    public partial class SifreGuncelle : Form
    {
        public SifreGuncelle()
        {
            InitializeComponent();
        }
        SqlConnection Baglan = new SqlConnection(@"Data Source=DESKTOP-8O7HHSH\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        private void btnadmingiris_Click(object sender, EventArgs e)
        {

        }

        private void btnadminguncelle_Click(object sender, EventArgs e)
        {
            Baglan.Open();
            SqlCommand komut = new SqlCommand("update Admin_Giris set Kullanici='" + txtgucellead.Text + "',Sifre='" + txtguncellesifre.Text + "'", Baglan);
            komut.ExecuteNonQuery();
            Baglan.Close();

            MessageBox.Show("Şifre Güncellendi.");
        }
    }
}
