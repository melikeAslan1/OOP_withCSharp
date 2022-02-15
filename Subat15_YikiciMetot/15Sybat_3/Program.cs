using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat15_YikiciMetot
{
    class Personel
    {
        // ctor + tab tab
        public Personel()
        {
            Console.WriteLine("Nesne Olustu...");
        }
        
        //altgr + ü
       ~Personel()
        {
            Console.WriteLine("Nesne Silindi...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Personel p = new Personel();
            Console.ReadLine();
        }
    }
}
