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
    public partial class FrmOdemeSecim : Form
    {
        public FrmOdemeSecim()
        {
            InitializeComponent();
        }

        public string x;
        private void FrmOdemeSecim_Load(object sender, EventArgs e)
        {
            txtTutar.Text = x;
            
        }


        FrmSiparisOlustur FrmSiparisOlustur = new FrmSiparisOlustur();
        

        private void btnKredi_Click_1(object sender, EventArgs e)
        {
            FrmKrediKartOdeme fr = new FrmKrediKartOdeme();
            fr.Show();
            

        }

        private void btnCek_Click_1(object sender, EventArgs e)
        {
            frmCekOdeme cekOdemeForm = new frmCekOdeme();
            cekOdemeForm.Show();
            

        }

        private void btnNakit_Click(object sender, EventArgs e)
        {
            OdemeNakit n = new OdemeNakit();

            MessageBox.Show(n.Odemes(Convert.ToInt32(txtTutar.Text)) + " TL Nakit Olarak Ödendi");
            Application.Restart();
        }

    }
}
