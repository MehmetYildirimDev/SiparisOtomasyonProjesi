using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class OdemeKredi: Odeme
    {
        public string No { get; set; }

        public decimal Tipi { get; set; }

        public string SonKullanmaTarihiAy { get; set; }

        public string SonKullanmaTarihiYil { get; set; }

        public override int Odemes(int x)
        {
            return 0;
        }

        public string Onay(string KartNo, string Ay, string Yil)
        {
            No = "1234 1234 1234 1234";
            SonKullanmaTarihiAy = "10";
            SonKullanmaTarihiYil = "10";

            if (No == KartNo && SonKullanmaTarihiAy == Ay && SonKullanmaTarihiYil == Yil)
            {
                return "Odendi";
            }
            else
            {
                return "Yanlis Bilgiler";
            }
        }
    }
}
