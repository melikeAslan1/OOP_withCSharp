using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat17_ornek
{
    class Program
    {
        static int Faktoriyel(int sayi)
        {
            // if (sayi == 1) return 1;
           // Console.WriteLine(sayi);
            return Faktoriyel(sayi - 1) * sayi;
        }
        static void Main(string[] args)
        {
           // Console.WriteLine(Faktoriyel(5));

        }
    }
}
