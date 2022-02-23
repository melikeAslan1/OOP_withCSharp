using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat23_2
{
    class Program
    {
        delegate void Temsilci();


        static bool TekSayiMi(int sayi)
        {
            return sayi % 2 == 1;
        }

        static void Yaz(List<int> sayilar)
        {
            foreach (int s in sayilar)
            {
                Console.WriteLine(s + " ");
            }
        }
        static void Main(string[] args)
        {
            List<int> sayilar = new List<int>() { 4, 6, 7, 9, 1, 50, 3 };

            //klasik yöntem
            for (int i = 0; i < sayilar.Count; i++)
            {
                if(sayilar[i] %2 ==1)
                    Console.Write(sayilar[i] + " ");
            }

            //1.yöntem
            Predicate<int> p = new Predicate<int>(TekSayiMi);

            Yaz(sayilar.FindAll(p));

            // predicate bir delege return type ı bool, parametresi T.

            //2.Yöntem
        //    Yaz(sayilar.FindAll(Islem)); //olmaz return type ından dolayı. 


            Yaz(sayilar.FindAll(TekSayiMi));  // delegenin taşıyabileceği bir metot gönderirseniz açık açık delegeyi tanımlamanıza gerek yok.
                                              // otomatik kabul ediyor çünkü metot delegeye uygun.





            //ANONİM METODLAR:
            //C# da metot içinde metot tanımlanamazdı artık tanımlanabilir. 

            Temsilci t = delegate ()
             {
                 Console.WriteLine("ANONIM Metod...");
             };                                                   //içinde bir metod var fakat metodun ismi yok annonim yani.

            t();


            //3.Yöntem
            Yaz(sayilar.FindAll(delegate (int s)
            {
                return s % 2 == 1;
            }));


            //4.Yöntem
            Yaz(sayilar.FindAll(s => s % 2 == 1));  // s nin anlamı gelen parametre demektir.

            







        }
    }
}
