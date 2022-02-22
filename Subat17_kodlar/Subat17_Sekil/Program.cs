using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat17_Sekil
{
    class Daire
    {
        public double r { get; set; }
        public virtual double Hesapla()
        {
            return Math.PI * r * r;

        }
    }
    class Silindir : Daire
    {
        public double h { get; set; }
        public override double Hesapla()
        {
            return base.Hesapla() * h;
        }
    }
    class Koni : Silindir
    {
        public override double Hesapla()
        {
            return base.Hesapla() / 3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Daire daire = new Daire() { r = 3 };
            Silindir silindir = new Silindir() { r = 3, h = 10 };
            Koni koni = new Koni() { r = 3, h = 10 };

            Console.WriteLine(daire.Hesapla());
            Console.WriteLine(silindir.Hesapla());
            Console.WriteLine(koni.Hesapla());
        }
    }
}
