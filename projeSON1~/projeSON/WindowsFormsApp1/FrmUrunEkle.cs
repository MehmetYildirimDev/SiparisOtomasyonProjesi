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

namespace WindowsFormsApp1
{
    public partial class FrmUrunEkle : Form
    {
        public FrmUrunEkle()
        {
            InitializeComponent();
        }

        SqlBaglanti sqlBaglanti = new SqlBaglanti();

       
        //Kütüphane klenmediyse hata verir-komutları kullanabilmek için global alana bi sql baglanti nesnesi olusturuyoruz 

        private void BtnUrunEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(sqlBaglanti.Adres);

            if (txtAd.Text != "" || txtFiyat.Text != "" || mskMiktar.Text != "" || txtVergiTutar.Text != "" || rchAcıklama.Text != "" || txtAgirlik.Text != "")
            {
                Urun urun = new Urun();
                urun.UrunAdi = txtAd.Text;
                urun.UrunFiyati = Convert.ToDecimal(txtFiyat.Text);//bunlar maskedbox yapılabılır
                urun.UrunMiktari = Convert.ToInt32(mskMiktar.Text);
                urun.UrunKDV = Convert.ToDecimal(txtVergiTutar.Text);
                urun.UrunAciklama = rchAcıklama.Text;
                urun.UrunAgirligi = Convert.ToDecimal(txtAgirlik.Text);

                baglanti.Open();

                SqlCommand UrunEkleKomutu = new SqlCommand("insert into Tbl_Urun (UrunAdi,UrunMiktari,UrunBirimFiyati,VergiTutari,UrunAgirligi,UrunAciklamasi) values (@p1,@p2,@p3,@p4,@p5,@p6)", baglanti);

                UrunEkleKomutu.Parameters.AddWithValue("@p1", urun.UrunAdi);
                UrunEkleKomutu.Parameters.AddWithValue("@p2", urun.UrunMiktari);
                UrunEkleKomutu.Parameters.AddWithValue("@p3", urun.UrunFiyati);
                UrunEkleKomutu.Parameters.AddWithValue("@p4", urun.UrunKDV);
                UrunEkleKomutu.Parameters.AddWithValue("@p5", urun.UrunAgirligi);
                UrunEkleKomutu.Parameters.AddWithValue("@p6", urun.UrunAciklama);

                UrunEkleKomutu.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Urun Eklendi");

            }
            else
            {
                MessageBox.Show("Boş Bırakmayınız");
            }
        }

     
    }
}
