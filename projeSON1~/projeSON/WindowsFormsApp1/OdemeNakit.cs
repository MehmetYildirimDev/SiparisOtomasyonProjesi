using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public class OdemeNakit : Odeme
    {
        public override int Odemes(int x)
        {
            return x;
        }

        public int OdemeYap { get; set; }
    }
}

