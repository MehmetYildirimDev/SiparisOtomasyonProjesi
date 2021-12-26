using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;//sql komutları için nu kutuphaneyi eklemem lazım 

namespace WindowsFormsApp1
{
    public partial class FrmMusteriKayit : Form
    {
        public FrmMusteriKayit()
        {
            InitializeComponent();
        }
        SqlBaglanti sqlbaglanti = new SqlBaglanti();

        
        
        private void BtnKayitOl_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(sqlbaglanti.Adres);

            if (txtAd.Text != "" && txtSoyad.Text != "" && txtKullaniciadi.Text != "" && txtSifre.Text != "" && rchAdres.Text != "")
            {
                Musteri musteri = new Musteri();//her girişte yeni nesne yaratıyor ki üstüne yazmasın 
                musteri.Ad = txtAd.Text;
                musteri.Soyad = txtSoyad.Text;
                musteri.KullaniciAd = txtKullaniciadi.Text;
                musteri.Sifre = txtSifre.Text;
                musteri.Adres = rchAdres.Text;


                baglanti.Open();//Baglantıyı açıyoruz 

                SqlCommand kayitOlKomutu = new SqlCommand("insert into Tbl_Musteri (Adi,Soyadi,KullaniciAdi,Sifre,Adresi) values (@p1,@p2,@p3,@p4,@p5)", baglanti);
                //Komut sınıfından nesne türetiliyor ve kurucu metot içine sorguyu yazıyoruz 


                kayitOlKomutu.Parameters.AddWithValue("@p1", musteri.Ad);
                //kayitOlKomutu komut nesnesinin parametlerini değer olarak ekle diyoruz 
                kayitOlKomutu.Parameters.AddWithValue("@p2", musteri.Soyad);
                kayitOlKomutu.Parameters.AddWithValue("@p3", musteri.KullaniciAd);
                kayitOlKomutu.Parameters.AddWithValue("@p4", musteri.Sifre);
                kayitOlKomutu.Parameters.AddWithValue("@p5", musteri.Adres);


                kayitOlKomutu.ExecuteNonQuery();//Sorguyu calıstır (sql deki tıklama gibi düşün )
                                                //insert ,update ve delete de kullanılır - (yani okuma işlemlerinde kullanızlaz)
                baglanti.Close();//Baglantiyi kapatiyoruz
                MessageBox.Show("Kayit Başarili");

            }
            else
            {
                MessageBox.Show("Boş bırakma");
            }

        }
    }
}
