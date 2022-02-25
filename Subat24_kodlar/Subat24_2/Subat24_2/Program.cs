using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat24_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //6-Extension Methods(Genişletme metodları...) (genişletme metodları)
            //işin mühendislik başarısı burada.

            int sayi = 12;
            Console.WriteLine(sayi.KareAl());

            string str = "deneme";

            int no = 11;
            no.KareAl();

            Console.WriteLine(str.TersCevir());
            // bir sınıfın içine bir metot eklemek istiyosun ama o class ı sen yazmadın.

            //sealed class tan baska bir class türetilemez.


            // Extension bir metot yazmanın kuralları:
            //1. Static bir class olmalı.
            //2. Mutlaka static sınıf içerisindeki metotlar da static olmalı.
            //3. Metodun ilk parametresi this ile başlamalı, ilgili yapılara eklenmeli...

            string strMesaj = "Merhaba";
            Console.WriteLine(strMesaj.Eko(3));

            //7-Expression Tree
            //LinQ sorguları 2 şekilde yazılır.Asıl olan Expression Tree yontemi.
            //Sql cümlesi gibi yazmaya izin verir.Bazı sorgulara izin vermez.Temel kullanıma izin verir.

            int sayi5 = 2;
            Console.WriteLine(sayi5.KareAl().KupAl().IkiyeBol());

            //8-Lambda Expressions =>" 
            //delege vardır.
            int[] sayilar = { 3, 5, 6, 8, 1, 10 };
            foreach (var x in sayilar.Where(s => s % 2 == 1))
            Console.WriteLine(x);
        


    }
    }
}
