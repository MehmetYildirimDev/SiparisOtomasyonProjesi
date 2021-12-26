using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class FrmAdminPaneli : Form
    {
        public FrmAdminPaneli()
        {
            InitializeComponent();
        }

        private void FrmAdminPaneli_Load(object sender, EventArgs e)
        {
            this.tbl_MusteriTableAdapter.Fill(this.siparisProjesiDataSet.Tbl_Musteri);
            //Datagrid ile veriler gösteriliyor
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
