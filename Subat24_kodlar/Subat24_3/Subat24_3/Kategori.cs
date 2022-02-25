using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat24_3
{
    class Kategori
    {
        public int KategoriID { get; set; }
        public string KategoriAd { get; set; }

        public override string ToString()
        {
            return KategoriID + " " + KategoriAd;
        }

    }
}
