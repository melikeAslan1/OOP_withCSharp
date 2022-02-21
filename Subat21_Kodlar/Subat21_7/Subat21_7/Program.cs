using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat21_7
{
    //Generic Kısıtlar: 
    // esneklik iyidir fakat cok esneklik iyi değildir.

    
    abstract class Sekil
    {
        int a;  // ben yazdım normalde class içi boştu. 
    }

    class Kare :Sekil { 
    }

    class Kup : Kare,IHacim { }

    class Ferrari { }

    class Cizim<T> where T: Sekil { }

    interface IHacim
    {

    }

    class HacimHesapla<T> where T:IHacim { }
    struct Nokta
    {
        public int x;
        public int y;
    }


    class Deneme<T> where T : struct
    {
       
    }

    class Emened <T> where T: class { 
    }

    class Emlak<T> where T: class,new()
    {

    }
    class Ev
    {
        public Ev(string adres)  // varsayılan yapıcı: otomatik olusan boş yapıcı.
        {

        }
    }

    class Karavan
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            //int goto definition
            //int goto definition
            // char
            //string

            // c# ta 15 tane ön tanımlı değişken var. 13  2  diye ayırdık.
            // //13 tanesi struct tan turemiştir. 2 tanesi class tan türemiştir.
            // //clastan türeyenler: string ve object.
            // değer tipli olanların karakteristiği şudur: kapasitesi önceden bilinir. fakat referans tiplinin bilinmez. 16 byte dan büyükse değişken struct yapısında kullanma bunu class a cevir diyor microsoft.
            // class tan türeyen referans tiplidir. struct tan türeyenler değer tiplidir. 

            Nokta nokta;
            nokta.x = 12;
            nokta.y = 12;

            Deneme<int> d1 = new Deneme<int>();
            Deneme<bool> d2 = new Deneme<bool>();
            // Deneme<string> d3 = new Deneme<string>(); //Engellendi.class

            //Emened<int> e1 = new Emened<int>();  //Engellendi.struct
            Emened<string> e2 = new Emened<string>();
            Emened<object> e3 = new Emened<object>();


            Cizim<Kare> c1 = new Cizim<Kare>();

            Cizim<Kup> c2 = new Cizim<Kup>();

            // Cizim<Ferrari> c3 = new Cizim<Ferrari>();  // base class sekil değil. 

            //  Cizim<a> a = new Cizim<a>(); // benyazdım.

            //  HacimHesapla<Kare> hh1 = new HacimHesapla<Kare>();  // IHacim uygulanmadığından çalışmaz.

            HacimHesapla<Kup> hh2 = new HacimHesapla<Kup>();


            //new()
            // bu kısıtlar içerisinde new mutlaka en sonda olmalı...
            //  Emlak<Ev> ev = new Emlak<Ev>();  // Default yaoıcı yok... bu yuzden hata verir.

            Emlak<Karavan> karavan = new Emlak<Karavan>();








             


        }
    }
}
