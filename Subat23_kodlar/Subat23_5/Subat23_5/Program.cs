using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat23_5
{
    // Events - Depo
    // Soru: Kapasitesi 10 olan bir depoya, urun ekleme ve cıkarma işlemleri yapılacaktir. Deponun icinde urun 
    // kalmadığında veya depo dolduğunda calisacak olayların tanımlanması istenmektedir. Ayrıca depo içerisindeki
    // tum urunlerin listesini veren depo sinifini yaziniz.



    class Program
    {
        static void Main(string[] args)
        {
            Depo depo = new Depo(10);

            depo.DepoDolu += Depo_DepoDolu;
            depo.DepoBos += Depo_DepoBos;

            Urun urun = new Urun() { UrunID = 123, UrunAdi = "Kalem", Fiyat = 23 };

            for (int i = 0; i < 13; i++)
            {
                depo.Ekle(urun);
                
            }

            for (int i = 0; i < 15; i++)
            {
                depo.Cikar(urun);
            }
        }

        private static void Depo_DepoBos(object sender, EventArgs e)
        {
            Console.WriteLine("depo boş"); }

        private static void Depo_DepoDolu(object sender, EventArgs e)
        {
            Console.WriteLine("depo dolu"); }
    }

}









