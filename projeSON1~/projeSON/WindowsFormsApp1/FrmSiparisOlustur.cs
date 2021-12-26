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
    public partial class FrmSiparisOlustur : Form
    {
        SqlBaglanti sqlBaglanti = new SqlBaglanti();

        
        public FrmSiparisOlustur()
        {
            InitializeComponent();
        }

        public string soyad;
        public string isim;
        enum Siparisdurumu
        {
            hazirlaniyor,hazir
        }


        double agirlik = 0;
        double genelagirlik = 0;//from her başladıgında yenilensin 

        double tutar = 0;
        double geneltutar = 0;

        double vergi = 0;
        double genelvergi = 0;

        double kargotutari = 0;
        public double odenecektutar = 0;
        

        private void FrmSiparisOlustur_Load(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(sqlBaglanti.Adres);

            lblAd.Text = isim;
            lblSoyad.Text = soyad;
            
            baglanti.Open();
            SqlCommand SiparisGetirKOmut = new SqlCommand("select * from Tbl_Urun", baglanti);
            SqlDataReader reader = SiparisGetirKOmut.ExecuteReader();
            while (reader.Read())//Okuyucu okudugu surece ürünlerin adı gelsin diyoruz
            {
                LstUrun.Items.Add(reader[1]);
            }
            baglanti.Close();
           
            mskMiktar.Text = 1.ToString();
            mskMiktar.Focus();
        }
        private void BtnSiparisEkle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(sqlBaglanti.Adres);

            if (mskMiktar.Text != "")//Miktar bilgisini masked boxdan alırız
            {
                LstSepet.Items.Add(LstUrun.SelectedItem + "    " + mskMiktar.Text);


                Siparis siparis = new Siparis();
                SiparisDetayı siparisDetayı = new SiparisDetayı();
                Urun urun = new Urun();

                baglanti.Open();
                SqlCommand komut = new SqlCommand("Select * From Tbl_Urun where UrunAdi=@p1", baglanti);
                komut.Parameters.AddWithValue("@p1", LstUrun.SelectedItem);

                SqlDataReader dr = komut.ExecuteReader();

                if (dr.Read())
                {
                    tutar=siparisDetayı.Tutar = Convert.ToDouble(dr[3]);
                    siparisDetayı.Vergi= Convert.ToDouble(dr[4]);//istediğimiz verileri sqlden 
                    agirlik=siparisDetayı.AgirlikHesapla(Convert.ToDouble(mskMiktar.Text), Convert.ToDouble(dr[5]));//miktar ve agırlıgıg gonderip toplam agırlıgıg hesapaldık
                    
                }
                
                baglanti.Close();
                siparisDetayı.SiparisMiktari = Convert.ToInt32(mskMiktar.Text);//miktarı alıyoruz
                siparisDetayı.Tutar = Convert.ToDouble(urun.MiktaraGoreFiyat(siparisDetayı.SiparisMiktari, Convert.ToDecimal(siparisDetayı.Tutar)));//miktara göre hesaplatıyoruz ve tutar yeniden belirleniyor 


                siparis.SiparisTarihi = dateTimePicker1.Value;//tarih degerini alıyor
                siparis.SiparisDurumu = Siparisdurumu.hazirlaniyor.ToString();//enumdan hazırlanıyor olarak alıyor
                lblSiparisDurum.Text = siparis.SiparisDurumu;//labele yazdırıyor

                genelagirlik=siparis.ToplamAgirlik(agirlik,genelagirlik);//genel agırlıgı 
                lblSepetAgırlık.Text= genelagirlik.ToString();

                geneltutar = siparisDetayı.AraToplam(tutar, geneltutar);
                lblAraToplam.Text = geneltutar.ToString();

                vergi=siparis.VergiHesapla(siparisDetayı.Tutar, siparisDetayı.Vergi)
                ; //birim mikarın vergisi hesaplıyor bir de miktarı gönderirsek okey - gerek olursa 

                genelvergi = siparisDetayı.ToplamVergi(vergi, genelvergi);
                lblToplamVergi.Text = genelvergi.ToString();

                kargotutari = genelagirlik * 10;
                lblKargoTutari.Text = kargotutari.ToString();
                
                odenecektutar = geneltutar + genelvergi + kargotutari;
                lblOdenecekTutar.Text = odenecektutar.ToString();

                /*siparis.ToplamTutar(siparis.VergiHesapla(siparisDetayı.Tutar, siparisDetayı.Vergi), siparisDetayı.Tutar);*///vergi tutarı , vergisiz fiyat 
               

            }
            else
            {
                MessageBox.Show("Miktar Seçiniz");
            }
            
        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            FrmOdemeSecim frmOdemeSecim = new FrmOdemeSecim();
            frmOdemeSecim.x = lblOdenecekTutar.Text;
            frmOdemeSecim.Show();

        
        }
    }
}
