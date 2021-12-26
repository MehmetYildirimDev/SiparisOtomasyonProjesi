using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public abstract class Odeme
    {
        public int Miktar { get; set; }

        public abstract int Odemes(int x);
    }
}
