using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Subat_Constructure
{

    class Personel
    {
        public int PerID { get; set; }

        public string PerAdi { get; set; }

        public decimal Maas { get; set; }

        public Personel ()
        {

        }

        public Personel (int id, string ad, decimal maas)
        {
            PerID = id;
            PerAdi = ad;
            Maas = maas;
        }


    }

    class Musteri
    {
        public int MusID { get; set; }

        public string MusAdi { get; set; }

        public decimal Cari { get; set; }

    }

    class Arac
    {
        public string Plaka { get; set; }

        public Arac (string plaka)
        {
            Plaka = plaka;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Personel p2 = new Personel();
            p2.PerID = 2;
            p2.PerAdi = "Cevdet";
            p2.Maas = 5600;

            Personel p3 = new Personel (12, "selami", 6700);

            Musteri m = new Musteri { MusID = 15, MusAdi = "deniz", Cari = 7551 };  //bu object initializer dır.
            Musteri m2 = new Musteri();

            Arac arac = new Arac("");

        }
    }
}
