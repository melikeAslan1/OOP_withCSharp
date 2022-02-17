using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat17_ConsoleApp1
{
    class Personel
    {
        public int PerID { get; set; }

        public string PerAdi { get; set; }

        public override string ToString()
        {
            return PerID + " " + PerAdi;
        }
    }

    class Musteri
    {
        public int MusID { get; set; }

        public string MusAdi { get; set; }

        public override string ToString()
        {
            return MusID+ " " +  MusAdi;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            Personel p = new Personel() { PerID = 11, PerAdi = "Cevdet" };
            Musteri m = new Musteri() { MusID = 22, MusAdi = "Selami" };

            int sayi = 12;

            Console.WriteLine(p);
            Console.WriteLine(m);
            Console.WriteLine(sayi);

            Object obj = new object();

            Console.WriteLine(obj);


        }
    }
}
