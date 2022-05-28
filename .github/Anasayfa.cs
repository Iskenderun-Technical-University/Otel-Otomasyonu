using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Otel_Otomasyonu
{
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteri_ekle frm = new Musteri_ekle();
            frm.Show();
            
        }

       /* private void button1_Click(object sender, EventArgs e)
        {
            Giris_Ekranı fr = new Giris_Ekranı();
            fr.Show();
            this.Hide();
        }
       */
        private void button4_Click(object sender, EventArgs e)
        {
            Musteriler fr = new Musteriler();
            fr.Show();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Odalar frm = new Odalar();
            frm.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Gelirgider fr = new Gelirgider();
            fr.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Otelimiz 1999 yılında hizmete açılmıştır. Antalyada hizmete giren ilk 5 yıldızlı oteldir.");
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToLongDateString();
            label2.Text = DateTime.Now.ToLongTimeString();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            StokEkrani fr = new StokEkrani();
            fr.Show();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            RadyoDinle fr = new RadyoDinle();
            fr.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Gazeteler fr = new Gazeteler();
            fr.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SifreGuncelle fr = new SifreGuncelle();
            fr.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Mesajlar fr = new Mesajlar();
            fr.Show();
        }
    }
}
