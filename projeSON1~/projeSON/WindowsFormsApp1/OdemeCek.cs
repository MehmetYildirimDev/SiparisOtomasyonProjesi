using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class OdemeCek:Odeme
    {
        public string Isim { get; set; }

        public int Id { get; set; }

        public override int Odemes(int x)
        {
            throw new NotImplementedException();
        }

        public string Onay(string KullaniciIsmi, int CekId)
        {
            Isim = "mehmet";
            Id = 3425;

            if (Isim == KullaniciIsmi && Id == CekId)
            {
                return "Odendi";
            }
            else
            {
                return "Hatali Bilgi";
            }
        }
    }
}
