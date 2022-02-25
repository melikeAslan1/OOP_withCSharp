using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat24_1
{
    class Personel{

        // Auto prop.
        public int PerID { get; set; }
        public string PerAd { get; set; }


    }
    class Program
    {
        static void Main(string[] args)
        {
            //LINQ
            // 1-var

            // HCI(Human computer Interaction), web tasarımı ile ilgili bunun makalelerini okuyun. bu konunun.)

            var sayi = 12l;
            var ad = "Cevdet";
            var kontrol = true;
            var pers = new Personel();   
            var fiyat = 9.99M;
            var karakter = 'A';

            // var bir tip değildir, gerçekte yok. var sadece design time da buraya bişey gelecek tipi henüz belli değil demektir.

         //   sayi = "naber";

            //C# 4.0
            // dynamic nerede kullanılır --> MVC de 
            dynamic deger = 12;

            deger = "value";

            object degisken1 = 12;
            int sayi1 = (int)degisken1; // tip dönüşümü yapmam gerekiyor, bu kısmı anlayamadım tam.

            dynamic degisken2 = 12;
            int sayi2 = degisken2;

            // 2- Auto Property

            //3- Object init.(nesne baslatıcı)

            Personel p = new Personel { PerID = 123, PerAd = "Cevdet" };

            //Collection Init.
            List<Personel> personeller = new List<Personel>
            {
                new Personel{PerID=111, PerAd="Selami"},
                new Personel {PerID=123, PerAd="Cevdet"}
            };


            // 5- Anonim Nesne:

            var nesne = new { ID = 123, Ad = "Cevdet", Maas = 4567 };











        }
    }
}
