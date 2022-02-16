using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat16_Personel
{
    class Personel
    {
        public Personel()
        {
            Console.WriteLine("Personel sınıfı olustu...");
        }
    }

    class Mudur: Personel
    {
        public Mudur()
        {
            Console.WriteLine("müdür sınıfı olustu.");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel();
            Mudur mudur = new Mudur();
        }
    }
}
