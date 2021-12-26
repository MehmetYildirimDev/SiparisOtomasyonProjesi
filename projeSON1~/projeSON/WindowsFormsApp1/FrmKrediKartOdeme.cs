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
    public partial class FrmKrediKartOdeme : Form
    {
        public FrmKrediKartOdeme()
        {
            InitializeComponent();
        }

       

        private void button1_Click_1(object sender, EventArgs e)
        {
            OdemeKredi kredi = new OdemeKredi();

            MessageBox.Show(kredi.Onay(mtxbKartNo.Text, comboBox1.Text, comboBox2.Text));
            if (kredi.Onay(mtxbKartNo.Text, comboBox1.Text, comboBox2.Text)== "Odendi")
            {
                Application.Restart();
            }
            
            
        }

        private void FrmKrediKartOdeme_Load(object sender, EventArgs e)
        {
            for (int ay = 1; ay < 13; ay++)
            {
                comboBox1.Items.Add(ay);
            }
            for (int yil = 1; yil < 30; yil++)
            {
                comboBox2.Items.Add(yil);
            }
        }
    }
}
