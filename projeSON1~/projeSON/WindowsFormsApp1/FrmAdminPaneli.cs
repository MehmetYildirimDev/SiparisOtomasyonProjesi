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
    public partial class FrmAdminPaneli : Form
    {
        public FrmAdminPaneli()
        {
            InitializeComponent();
        }
        SqlBaglanti sqlBaglanti = new SqlBaglanti();
        private void FrmAdminPaneli_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("Select * From Tbl_Musteri", sqlBaglanti.Adres);
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void ürünEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrunEkle frmUrunEkle = new FrmUrunEkle();
            frmUrunEkle.Show();
            
        }

        private void ürünGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUrunGuncelle frmUrunGuncelle = new FrmUrunGuncelle();
            frmUrunGuncelle.Show();
        }

    }
}
