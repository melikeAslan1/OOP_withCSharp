using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat15_Sekil
{
    class Daire
    {
        public double  r { get; set; }

        public double DaireAlanHesapla()
        {
            return Math.PI * r * r;
        }
    }

    class Silindir: Daire
    {
        public double h { get; set; }

        public double SilindirHacimHesapla()
        {
            return base.DaireAlanHesapla()* h;
        }
    }

    class Koni: Silindir
    {
        public double KoniHacimHesapla()
        {
            return base.SilindirHacimHesapla() / 3;
        }
    }

    //miras konusuna constructureda parametreler arası transfer 
    // türeyen sınıflarda yapıcı kullanmak biraz zor gibi teknik bilgi gerektirir.


    class Circle
    {
        private double r;
        public Circle(double r)
        {
            this.r = r;
        }

        public double DaireAlanHesapla()
        {
            return Math.PI * r * r;
        }
    }

    class Cyclinder: Circle
    {
        protected double h;
        public Cyclinder(double r, double h ): base(r)
        {
            this.h = h;
        }

        public double SilindirHacimHesapla()
        {
            return base.DaireAlanHesapla() * h;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {

            Daire d = new Daire()
            {
                r = 3
            };

            Console.WriteLine(d.DaireAlanHesapla());

            Silindir s = new Silindir() { r = 3, h = 10 };
            Console.WriteLine(s.SilindirHacimHesapla());

            Koni k = new Koni() { r = 3, h = 10 };
            Console.WriteLine(k.KoniHacimHesapla());






            Circle circle = new Circle(3);

            Console.WriteLine(circle.DaireAlanHesapla());

            Cyclinder cyclinder = new Cyclinder(3, 10);

            Console.WriteLine(cyclinder.SilindirHacimHesapla());



            Console.ReadLine();
        }
    }
}
