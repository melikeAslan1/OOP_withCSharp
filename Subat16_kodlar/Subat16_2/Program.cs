using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek
{
    abstract class Sekil
    {
        public string Renk { get; set; }
    }

    class Daire: Sekil { }

    class Silindir: Daire { }

    sealed class Koni: Silindir
    {

    }

   // class KesikKoni: Koni { }   // sealed olduğu için türetme yapmama izin vermiyor. 

    static class Veritabani
    {
        public static void Kaydet()
        {

        }
    }

    class Baglan
    {
        public static void ConnectionString(string str) { }

        // metot static olunca 
    }

    class Program
    {
        static void Main(string[] args)
        {
            // abstract olduğu için asagıdaki kod olmaz.
            //   Sekil sekil = new Sekil();

            Koni koni = new Koni();

            Veritabani.Kaydet();

            Baglan baglan = new Baglan();

            Baglan.ConnectionString("");

            int[] sayilar = { 45, 65, 78 };

            // sayilar sort yok. tek tek hepsine vermek yerine array e verip tek bir seferde işi halledebilirim. 
            
           // Array.Sort



        }
    }
}
