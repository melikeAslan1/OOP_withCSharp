using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat18_3
{

    class Urun:IComparable
    {
        public int UrunID { get; set; }

        public string UrunAdi { get; set; }

        public double Fiyat { get; set; }

        public int CompareTo(object obj)
        {
            Urun urun = (Urun)obj;
            return -1*UrunID.CompareTo(urun.UrunID);
        }

        public override string ToString()
        {
            return UrunID + " " + UrunAdi + " " + Fiyat;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList() { 45, 33, 56, 4, 22, 17 };

            list1.Sort();

            foreach (var item in list1)
            {
                Console.WriteLine(item);
            }

            ArrayList list2 = new ArrayList() { "zonguldak", "ankara", "adana", "niğde" };

            list2.Sort();

            foreach (var item in list2)
            {
                Console.WriteLine(item);
            }

            ArrayList list3 = new ArrayList()
            {
                new Urun{UrunID=24, UrunAdi="Kalem", Fiyat=20},
                new Urun{UrunID=12, UrunAdi="Defter", Fiyat=25},
                new Urun{UrunID=45, UrunAdi="Silgi", Fiyat=10}
            };

            list3.Sort();

            foreach (var item in list3)
            {
                Console.WriteLine(item);
            }

            


        }
    }
}
