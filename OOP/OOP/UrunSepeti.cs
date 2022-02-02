using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class UrunSepeti
    {
        public int SepetID { get; set; }

        public int MusteriId { get; set; }
        public int SepetId { get; internal set; }

        public List <Urun> UrunlerListesi= new List<Urun>();

    }
}
