using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat18_2
{
    
    class Depo:IEnumerable
    {
        string[] _urunler = { "Urun 1", "Urun 2", "Urun 3", "Urun 4" };

        public IEnumerator GetEnumerator()
        {
            return _urunler.GetEnumerator();
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            string str = "Deneme";
            Depo depo = new Depo();
            foreach(var s in depo)  //ilk başta buradaki depo hata verdi enumarator dan sonra hata düzeldi.
            {
                Console.WriteLine(s);
            }




        }
    }
}
