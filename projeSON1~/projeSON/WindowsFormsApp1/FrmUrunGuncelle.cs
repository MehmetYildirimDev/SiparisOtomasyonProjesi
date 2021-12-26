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
    public partial class FrmUrunGuncelle : Form
    {
        public FrmUrunGuncelle()
        {
            InitializeComponent();
        }
        SqlBaglanti sqlBaglanti = new SqlBaglanti();

        public void BilgileriGoster()
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Urun", sqlBaglanti.Adres);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void FrmUrunGuncelle_Load(object sender, EventArgs e)
        {
            BilgileriGoster();
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;//secilen değişkenine seçilen hücrenin rowindexi atandı 
            txtID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();//seçilen satırın 0. hucresinin değerini stringe cevir ve txtad.text ata (ilk satirdaki sutunda ne varsa ona eşitleriz)
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            mskMiktar.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtFiyat.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtVergiTutar.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtAgirlik.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            rchAcıklama.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString(); 

        }

       

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(sqlBaglanti.Adres);

            baglanti.Open();
            SqlCommand SilKomutu = new SqlCommand("Delete from Tbl_Urun where UrunID=@p1",baglanti);//ıdsi p1 olanı sıl 
            SilKomutu.Parameters.AddWithValue("@p1",txtID.Text);//p1 nerden alacagını anlatıyoruz
            SilKomutu.ExecuteNonQuery();

            baglanti.Close();
            BilgileriGoster();
            MessageBox.Show("Ürün Silindi");
        }

        private void BtnGuncelle_Click(object sender, EventArgs e)
        {
            SqlConnection baglanti = new SqlConnection(sqlBaglanti.Adres);
            baglanti.Open();

            SqlCommand GuncelleKOmutu = new SqlCommand("Update Tbl_Urun Set UrunAdi=@p1,UrunMiktari=@p2,UrunBirimFiyati=@p3,VergiTutari=@p4,UrunAgirligi=@p5,UrunAciklamasi=@p6 where UrunID=@p7",baglanti);//where sartı onemli yoksa hepsi aynı olur 
            GuncelleKOmutu.Parameters.AddWithValue("@p1", txtAd.Text);
            GuncelleKOmutu.Parameters.AddWithValue("@p2", mskMiktar.Text);
            GuncelleKOmutu.Parameters.AddWithValue("@p3", txtFiyat.Text);
            GuncelleKOmutu.Parameters.AddWithValue("@p4", txtVergiTutar.Text);
            GuncelleKOmutu.Parameters.AddWithValue("@p5", txtAgirlik.Text);
            GuncelleKOmutu.Parameters.AddWithValue("@p6", rchAcıklama.Text);
            GuncelleKOmutu.Parameters.AddWithValue("@p7", txtID.Text);
            GuncelleKOmutu.ExecuteNonQuery();

            baglanti.Close();
            BilgileriGoster();
            MessageBox.Show("Ürün Güncellendi");
        }
    }
}
