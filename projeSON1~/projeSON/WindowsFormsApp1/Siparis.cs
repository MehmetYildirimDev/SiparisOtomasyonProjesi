using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Siparis
    {
        public DateTime SiparisTarihi { get; set; }
        public string SiparisDurumu { get; set; }

        SiparisDetayı siparisDetayı = new SiparisDetayı();

        
        

        public double VergiHesapla(double tutar,double vergiorani)
        {  
            return tutar * vergiorani / 100; ;
        }
        public double ToplamTutar(double vergitutari,double tutar)
        {
            return vergitutari+tutar;
        }

        public double ToplamAgirlik(double agırlık,double genelagırlık)
        {
            genelagırlık += agırlık;
            return genelagırlık;
        }
    }
}
