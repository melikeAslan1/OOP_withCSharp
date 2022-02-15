using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat15_3
{
    class Musteri
    {
        public int MusID { get; set; }
        public string MusAdi { get; set; }

        public string Adres { get; set; }


    

        public Musteri(int id, string ad, string adres)
        {
            MusID = id;
            MusAdi = ad;
            Adres = adres;
        }

        //    public Musteri(string ad, string adres)
        //{
        //    MusAdi = ad;
        //    Adres = adres;

        //}


        public Musteri(string ad, string adres):this(1,ad,adres)
        {
          

        }

        class Deneme
        {
            const double pi = 3.1415;
            readonly double katsayi = 1.5;

            public Deneme()
            {
                // pi=2.5;
                katsayi = 1.1;
            }

            public void İslem()
            {
                katsayi = 5.6;
            }
        }

    }

    

    class Program
    {
        static void Main(string[] args)
        {
            // 6- readonly  (sadece yapıcı metot içinde değiştirebilirim)
            // 7- const     (hiç değişmez)
        }
    }
}
