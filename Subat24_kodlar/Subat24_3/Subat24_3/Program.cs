using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat24_3
{
    class Program
    {
        static void Yaz<T> (List<T> liste)
        {
            foreach (T t in liste)
            {
                Console.WriteLine(t);
            }
        }


        static void Main(string[] args)
        {
            //LINQ Sorguları...
            //1- SQL gibi
            //var sonuc = from u in UrunData.Urunler
            //            select u;
            //Yaz(sonuc.ToList());



            ////LINQ sorguları deffered model ile çalışır...
            //int ID = 111;
            //var sonuc = (from u in UrunData.Urunler
            //             where u.UrunID == ID
            //             select u).ToList();
            //ID = 113;
            //Yaz(sonuc.ToList());
            ////Yaz(sonuc);
            ///



            //2.Expression Tree seklinde...

            // var sonuc = UrunData.Urunler.Where(u => u.UrunID == 128).ToList();
            // Yaz(sonuc);

            //   var sonuc = UrunData.Kategoriler.Select(u => u).ToList();

            //var sonuc = from u in UrunData.Urunler
            //            select new { ID = u.UrunID, Ad = u.UrunAd };
            //var sonuc = UrunData.Urunler.Select(u => new { u.UrunID, u.UrunAd });

            //Yaz(sonuc.ToList());


            //Join
            //var sonuc = from u in UrunData.Urunler
            //            join k in UrunData.Kategoriler
            //            on u.KategoriID equals k.KategoriID
            //            select new { u.UrunID, u.UrunAd, k.KategoriAd };


            var sonuc = UrunData.Urunler.Join(UrunData.Kategoriler,
                u => u.KategoriID, k => k.KategoriID, (u, k) => new { u.UrunID, u.UrunAd, k.KategoriID, k.KategoriAd});

            Yaz(sonuc.ToList());



        }
    }
}
