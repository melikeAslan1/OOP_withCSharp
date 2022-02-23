using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat23_5
{
    class Urun
    {
        public int UrunID { get; set; }

        public string UrunAdi { get; set; }

        public decimal Fiyat { get; set; }

        public override string ToString()
        {
            return UrunID + " " + UrunAdi + Fiyat;
        }


    }
}
