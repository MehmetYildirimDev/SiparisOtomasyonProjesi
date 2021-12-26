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
    public partial class frmCekOdeme : Form
    {
        public frmCekOdeme()
        {
            InitializeComponent();
        }
     

        private void button1_Click_1(object sender, EventArgs e)
        {
            OdemeCek check = new OdemeCek();

            MessageBox.Show(check.Onay(txtCekAdSoyad.Text, Convert.ToInt32(txtCekId.Text)));
            if (check.Onay(txtCekAdSoyad.Text, Convert.ToInt32(txtCekId.Text)) == "Odendi")
            {
                Application.Restart();
            }
        }
    }
}
