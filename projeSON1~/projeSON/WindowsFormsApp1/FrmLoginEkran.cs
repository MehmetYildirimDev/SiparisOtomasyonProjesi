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
    public partial class FrmLoginEkran : Form
    {
        public FrmLoginEkran()
        {
            InitializeComponent();
        }
        SqlBaglanti sqlbaglanti = new SqlBaglanti();


        public string Kontrol;

        private void FrmLoginEkran_Load(object sender, EventArgs e)
        {
            grAdminGiris.Visible = false;//Admin Giriş GroupBox görünürlüğü kapatıldı 
        }

        private void rdbtnAdminGiris_CheckedChanged_1(object sender, EventArgs e)
        {
            grMusteriGiris.Visible = false;
            grAdminGiris.Visible = true;
        }

        private void rbtnMusteri_CheckedChanged(object sender, EventArgs e)
        {
            grAdminGiris.Visible = false;
            grMusteriGiris.Visible = true;
        }

        private void BtnMGiriş_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(sqlbaglanti.Adres);//DataBase Bağlanıyor


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select Adi,Soyadi From Tbl_Musteri where KullaniciAdi=@p1 and Sifre=@p2", baglanti);

            komut.Parameters.AddWithValue("@p1", txtMKullaniciadi.Text);//Sütünlar Doğru olup olmadığı kontrel ediliyor//sorgu
            komut.Parameters.AddWithValue("@p2", txtMSifre.Text);

            SqlDataReader dr = komut.ExecuteReader();

            if (dr.Read())
            {
                FrmSiparisOlustur frmSiparisOlustur = new FrmSiparisOlustur();
                //Sipariş oluştur ekranındaki isim soyisim textleri buradan gönderiliyor
                frmSiparisOlustur.isim = dr[0].ToString();
                frmSiparisOlustur.soyad = dr[1].ToString();

                frmSiparisOlustur.Show();//Doğru ise showla 
                
            }
            else
            {
                MessageBox.Show("Hata");
            }
            baglanti.Close();


        }

        private void BtnAGiris_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(sqlbaglanti.Adres);


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Select * From Tbl_Admin where AdminKullaniciAdi=@p1 and AdminSifre=@p2", baglanti);
            komut.Parameters.AddWithValue("@p1", txtAKullaniciadi.Text);
            komut.Parameters.AddWithValue("@p2", txtASifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAdminPaneli frmAdminPaneli = new FrmAdminPaneli();

                frmAdminPaneli.Show();
            }
            else
            {
                MessageBox.Show("Hata");
            }
            baglanti.Close();
        }

        private void LnkLblUyeOl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmMusteriKayit frmMusteriKayit = new FrmMusteriKayit();
            frmMusteriKayit.Show();
        }

        
    }
}
