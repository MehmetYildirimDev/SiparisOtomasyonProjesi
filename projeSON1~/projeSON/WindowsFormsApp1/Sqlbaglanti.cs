using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class SqlBaglanti
    {
        public string Adres = File.ReadAllText(@"C:\SqlAdres.txt");
    }
}
