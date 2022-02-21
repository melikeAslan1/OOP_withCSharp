using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat21_5
{
    //performans olarak avantajlı generic kullanmak.
    // bunun örneği:
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList liste1 = new ArrayList();

            List<int> liste2 = new List<int>();

            DateTime basla, bitir;
            TimeSpan fark;

           

            basla = DateTime.Now;
            for (int i = 0; i < 9999999; i++)
            {
                liste1.Add(i);
                int sayi = (int)liste1[i]; //atama yaparken iki taraf aynı tipte olmalı mesela bu strongly type den dolayı.
            }

            bitir = DateTime.Now;
            fark = bitir - basla;
            Console.WriteLine($"İslem zamani(Arraylist) {fark.TotalMilliseconds}");

            basla = DateTime.Now;
            for (int i = 0; i < 9999999; i++)
            {
                liste2.Add(i);
                int sayi = (int)liste2[i]; //atama yaparken iki taraf aynı tipte olmalı mesela bu strongly type den dolayı.
            }

            bitir = DateTime.Now;
            fark = bitir - basla;
            Console.WriteLine($"İslem zamani(list) {fark.TotalMilliseconds}");

            
        }
    }
}
