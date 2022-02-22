using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat22_2
{
    //Soru: Bir market urun olarak Bardak,Sut, Yogurt, KagitHavlu, Yumurta gibi urunler satmaktadır. Bu ürünlerden
    // bazıları kırılabilen, bazısı bozulabilen veya belirli bir sürede satılması gereken ürünlerdir.
    // 1. Marketteki tüm ürünleri listeleyen...
    // 2. Urun ekleyebildiğimiz...
    //3. Cesitli durumlara gore rapor alabildiğimiz (süresi geçmiş ürünler, kırık ürünler vb gibi...)

    //Yukarıdaki durumları göz önüne alarak gerekli sistemi OOP kullanarak modelleyiniz ve yazınız.


    //  interface(içinde bişey bişey olmalı), abstract class(1 tane gıda yada ürün), polimorfizm, 

    class Program
    {
        static void Main(string[] args)
        {
            Market<Urun> market = new Market<Urun>();

            market.UrunEkle(new Bulgur { UrunID = 23, UrunAdi = "Pilavlık Bulgur", Fiyat = 10, TETT = DateTime.Parse("25/02/2022") });
            market.UrunEkle(new CamBardak { UrunID = 44, UrunAdi = "6 lı Su Bardağı", Fiyat = 35, Kirik = true });
            market.UrunEkle(new CamBardak { UrunID = 45, UrunAdi = "8 lı Su Bardağı", Fiyat = 45, Kirik = false });
            market.UrunEkle(new KagıtHavlu { UrunID = 87, UrunAdi = "24lü kağıt havlu", Fiyat = 85 });
            market.UrunEkle(new Sut { UrunID = 84, UrunAdi = "1lt Sut", Fiyat = 10, Tipi = "Keçi", SKT = DateTime.Parse("18/02/2022") });
            market.UrunEkle(new Yumurta { UrunID = 30, UrunAdi = "15li Yumurta", Fiyat = 25, Kirik = true, SKT = DateTime.Parse("19/02/2022") });
            market.UrunEkle(new Yumurta { UrunID = 33, UrunAdi = "30li Yumurta", Fiyat = 45, Kirik = false, SKT = DateTime.Parse("28/02/2022") });

            //Urun Listele
            foreach (var item in market.TumUrunler())
            {
                Console.WriteLine(item);
            }

            //Kirik Urunler
            Console.WriteLine("Kırık Urunler");
            foreach (var item in market.KirikUrunler())
            {
                Console.WriteLine(item);
            }



            //Bozulan Urunler
            Console.WriteLine("Bozuk Urunler");
            foreach (var item in market.BozukUrunler())
            {
                Console.WriteLine(item);

            }


        }
    }
}
