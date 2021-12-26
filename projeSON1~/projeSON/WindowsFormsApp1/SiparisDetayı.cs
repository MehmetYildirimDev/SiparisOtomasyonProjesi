using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class SiparisDetayı
    {
        public double Vergi { get; set; }
        public int SiparisMiktari { get; set; }
        public double Tutar { get; set; }
         
        public double AraToplam(double tutar,double geneltutar)
        {
            geneltutar += tutar;
            return geneltutar;
        }
        public double ToplamVergi(double vergi,double toplamvergi)
        {
            toplamvergi += vergi;
            return toplamvergi;
        }

        public double AgirlikHesapla(double adet , double birima)//Toplam Ağırlık yani Sepet
        {
            
            return adet*birima;
        }

    }
}
