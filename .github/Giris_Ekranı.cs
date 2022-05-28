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
    public partial class Giris_Ekranı : Form
    {
        public Giris_Ekranı()
        {
            InitializeComponent();
        }
        SqlConnection baglantı = new SqlConnection("Data Source=DESKTOP-8O7HHSH\\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        private void textBox2_MouseHover(object sender, EventArgs e)
        {
            ToolTip Açıklama = new ToolTip();
            Açıklama.SetToolTip(txtsifre, "CapsLock tuşuna dikkat ediniz.");
        }

        private void btnadmingiris_Click(object sender, EventArgs e)
        {
            try
            {
                baglantı.Open();
                string sql = "select * from Admin_Giris where Kullanici=@Kullaniciadi AND Sifre=@Sifresi";
                SqlParameter prm1 = new SqlParameter("Kullaniciadi", txtkullaniciadi.Text.Trim());
                SqlParameter prm2 = new SqlParameter("Sifresi", txtsifre.Text.Trim());
                SqlCommand komut = new SqlCommand(sql, baglantı);
                komut.Parameters.Add(prm1);
                komut.Parameters.Add(prm2);

                DataTable dt = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(komut);
                da.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    Anasayfa fr = new Anasayfa();
                    fr.Show();
                    this.Hide();
                    baglantı.Close();
                }
                
            }
            catch(Exception)
            {
                MessageBox.Show("Hatalı giriş yaptınız.");
            }
        }

        private void txtmesajadsoyad_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmesajkaydet_Click(object sender, EventArgs e)
        {
            baglantı.Open();
            SqlCommand komut = new SqlCommand("INSERT INTO Mesajlar(Adsoyad,Mesaj) values('" + txtmesajadsoyad.Text + "','" + richTextBox1.Text + "')", baglantı);
            komut.ExecuteNonQuery();
            baglantı.Close();
            MessageBox.Show("Mesajınız yöneticiye iletildi.");
        }
    }
}
