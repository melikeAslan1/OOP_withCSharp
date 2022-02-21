using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat21_3
{
    class Program
    {
        //Generic

        static void Yaz(int[] dizi)
        {
            foreach (int s in dizi)
            {
                Console.WriteLine(s+ " ");
                Console.WriteLine();
            }
        }

        static void Yaz(string[] dizi)
        {
            foreach (string s in dizi)
            {
                Console.WriteLine(s + " ");
                Console.WriteLine();
            }
        }

        static void Yaz(double[] dizi)
        {
            foreach (double s in dizi)
            {
                Console.WriteLine(s + " ");
                Console.WriteLine();
            }
        }

        static void Yazdir<T>(T[] dizi)
        {
            foreach (T s in dizi)
            {
                Console.WriteLine(s +" ");
                Console.WriteLine("");
            }
        }
        static void Main(string[] args)
        {
            int[] sayilar = { 34, 78, 98, 234, 8 };
            string[] sehirler = { "İstanbul", "Ankara", "Bursa", "Cankırı" };

            double[] fiyatlar= { 44.99, 33.55, 66.10 };

            //Yaz(sayilar);
            //Yaz(sehirler);
            //Yaz(fiyatlar);

            Yazdir<int>(sayilar);
            Yazdir(sehirler);
            //bazen yazarsın bazen yazmazsın.hangi tipli diziyi göndereceğimi design timeda da soyleyebilirim run timeda da


        }
    }
}
