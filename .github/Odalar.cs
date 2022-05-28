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
    public partial class Odalar : Form
    {
        public Odalar()
        {
            InitializeComponent();
        }
        SqlConnection Baglantı = new SqlConnection("Data Source=DESKTOP-8O7HHSH\\SQLEXPRESS;Initial Catalog=OtelOtomasyonu;Integrated Security=True");
        private void Odalar_Load(object sender, EventArgs e)
        {
            Baglantı.Open();
            SqlCommand komut1 = new SqlCommand("select * from oda101",Baglantı);
            SqlDataReader oku1 = komut1.ExecuteReader();
            while(oku1.Read())
            {
                btnoda101.Text = oku1["Adi"].ToString() + " "+ oku1["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda101.Text != "101")
            {
                btnoda101.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut2 = new SqlCommand("select * from oda102", Baglantı);
            SqlDataReader oku2 = komut2.ExecuteReader();
            while (oku2.Read())
            {
                btnoda102.Text = oku2["Adi"].ToString() + " " + oku2["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda102.Text != "102")
            {
                btnoda102.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut3 = new SqlCommand("select * from oda103", Baglantı);
            SqlDataReader oku3 = komut3.ExecuteReader();
            while (oku3.Read())
            {
                btnoda103.Text = oku3["Adi"].ToString() + " " + oku3["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda103.Text != "103")
            {
                btnoda103.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut4 = new SqlCommand("select * from oda104", Baglantı);
            SqlDataReader oku4 = komut4.ExecuteReader();
            while (oku4.Read())
            {
                btnoda104.Text = oku4["Adi"].ToString() + " " + oku4["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda104.Text != "104")
            {
                btnoda104.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut5 = new SqlCommand("select * from oda105", Baglantı);
            SqlDataReader oku5 = komut5.ExecuteReader();
            while (oku5.Read())
            {
                btnoda105.Text = oku5["Adi"].ToString() + " " + oku5["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda105.Text != "105")
            {
                btnoda105.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut6 = new SqlCommand("select * from oda106", Baglantı);
            SqlDataReader oku6 = komut6.ExecuteReader();
            while (oku6.Read())
            {
                btnoda106.Text = oku6["Adi"].ToString() + " " + oku6["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda106.Text != "106")
            {
                btnoda106.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut7 = new SqlCommand("select * from oda107", Baglantı);
            SqlDataReader oku7 = komut7.ExecuteReader();
            while (oku7.Read())
            {
                btnoda107.Text = oku7["Adi"].ToString() + " " + oku7["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda107.Text != "107")
            {
                btnoda107.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut8 = new SqlCommand("select * from oda108", Baglantı);
            SqlDataReader oku8 = komut8.ExecuteReader();
            while (oku8.Read())
            {
                btnoda108.Text = oku8["Adi"].ToString() + " " + oku8["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda108.Text != "108")
            {
                btnoda108.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut21 = new SqlCommand("select * from oda201", Baglantı);
            SqlDataReader oku21 = komut21.ExecuteReader();
            while (oku21.Read())
            {
                btnoda201.Text = oku21["Adi"].ToString() + " " + oku21["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda201.Text != "201")
            {
                btnoda201.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut22 = new SqlCommand("select * from oda202", Baglantı);
            SqlDataReader oku22 = komut22.ExecuteReader();
            while (oku22.Read())
            {
                btnoda202.Text = oku22["Adi"].ToString() + " " + oku22["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda202.Text != "202")
            {
                btnoda202.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut23 = new SqlCommand("select * from oda203", Baglantı);
            SqlDataReader oku23 = komut23.ExecuteReader();
            while (oku23.Read())
            {
                btnoda203.Text = oku23["Adi"].ToString() + " " + oku23["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda203.Text != "203")
            {
                btnoda203.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut24 = new SqlCommand("select * from oda204", Baglantı);
            SqlDataReader oku24 = komut24.ExecuteReader();
            while (oku24.Read())
            {
                btnoda204.Text = oku24["Adi"].ToString() + " " + oku24["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda204.Text != "204")
            {
                btnoda204.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut25 = new SqlCommand("select * from oda205", Baglantı);
            SqlDataReader oku25 = komut25.ExecuteReader();
            while (oku25.Read())
            {
                btnoda205.Text = oku25["Adi"].ToString() + " " + oku25["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda205.Text != "205")
            {
                btnoda205.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut26 = new SqlCommand("select * from oda206", Baglantı);
            SqlDataReader oku26 = komut26.ExecuteReader();
            while (oku26.Read())
            {
                btnoda206.Text = oku26["Adi"].ToString() + " " + oku26["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda206.Text != "206")
            {
                btnoda206.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut27 = new SqlCommand("select * from oda207", Baglantı);
            SqlDataReader oku27 = komut27.ExecuteReader();
            while (oku27.Read())
            {
                btnoda207.Text = oku27["Adi"].ToString() + " " + oku27["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda207.Text != "207")
            {
                btnoda207.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut28 = new SqlCommand("select * from oda208", Baglantı);
            SqlDataReader oku28 = komut28.ExecuteReader();
            while (oku28.Read())
            {
                btnoda208.Text = oku28["Adi"].ToString() + " " + oku28["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda208.Text != "208")
            {
                btnoda208.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut31 = new SqlCommand("select * from oda301", Baglantı);
            SqlDataReader oku31 = komut31.ExecuteReader();
            while (oku31.Read())
            {
                btnoda301.Text = oku31["Adi"].ToString() + " " + oku31["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda301.Text != "301")
            {
                btnoda301.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut32 = new SqlCommand("select * from oda302", Baglantı);
            SqlDataReader oku32 = komut32.ExecuteReader();
            while (oku32.Read())
            {
                btnoda302.Text = oku32["Adi"].ToString() + " " + oku32["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda302.Text != "302")
            {
                btnoda302.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut33 = new SqlCommand("select * from oda303", Baglantı);
            SqlDataReader oku33 = komut33.ExecuteReader();
            while (oku33.Read())
            {
                btnoda303.Text = oku33["Adi"].ToString() + " " + oku33["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda303.Text != "303")
            {
                btnoda303.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut34 = new SqlCommand("select * from oda304", Baglantı);
            SqlDataReader oku34 = komut34.ExecuteReader();
            while (oku34.Read())
            {
                btnoda304.Text = oku34["Adi"].ToString() + " " + oku34["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda304.Text != "304")
            {
                btnoda304.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut35 = new SqlCommand("select * from oda305", Baglantı);
            SqlDataReader oku35 = komut35.ExecuteReader();
            while (oku35.Read())
            {
                btnoda305.Text = oku35["Adi"].ToString() + " " + oku35["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda305.Text != "305")
            {
                btnoda305.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut36 = new SqlCommand("select * from oda306", Baglantı);
            SqlDataReader oku36 = komut36.ExecuteReader();
            while (oku36.Read())
            {
                btnoda306.Text = oku36["Adi"].ToString() + " " + oku36["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda306.Text != "306")
            {
                btnoda306.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut37 = new SqlCommand("select * from oda307", Baglantı);
            SqlDataReader oku37 = komut37.ExecuteReader();
            while (oku37.Read())
            {
                btnoda307.Text = oku37["Adi"].ToString() + " " + oku37["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda307.Text != "307")
            {
                btnoda307.BackColor = Color.Red;
            }

            Baglantı.Open();
            SqlCommand komut38 = new SqlCommand("select * from oda308", Baglantı);
            SqlDataReader oku38 = komut38.ExecuteReader();
            while (oku38.Read())
            {
                btnoda308.Text = oku38["Adi"].ToString() + " " + oku38["Soyadi"].ToString();
            }
            Baglantı.Close();
            if (btnoda308.Text != "308")
            {
                btnoda308.BackColor = Color.Red;
            }

        }

    }
}
