using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class Urun
    {
        public string UrunAdi { get; set; }
        public string UrunAciklama { get; set; }
        public decimal UrunAgirligi { get; set; }
        public int UrunMiktari { get; set; }

        public decimal UrunFiyati { get; set; }
        public decimal UrunKDV { get; set; }
        public int Adet { get; set; }//Adet yani 

        public decimal MiktaraGoreFiyat(decimal miktar,decimal Fiyat)//Adete göre özel fiyat olabilir sanırım onu kastediyor //10dan fazla alırsa fiyat değişsin 
        {
            decimal ToplamFiyat = miktar * Fiyat;

            if (miktar>10)
            {
                return ToplamFiyat*4/5;
            }
            else
            {
                return ToplamFiyat;
            }
        }
        public double AgirlikAl(double adet ,double Agirlik)//Tek bir Ağırlık
        {
            return (adet * Agirlik);
        }

    }
}
