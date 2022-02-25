using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Matematik;    // DLL ile kutuphane oluşturdum kullandım bu kütüphaneyi.
using Subat25_2_Kimya;  // diğer solutiondaki kutuphaneyi getirdim.

// aynı solutionda diye projenin içinden seçtik. farklı solutionlar arası kütüphane kullanmak istersem browse
// nin içinden falan yapmam lazım- browser secenegi.
namespace Subat25_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cebir cebir = new Cebir();

            Console.WriteLine(cebir.KareAL(4));

            Console.WriteLine(cebir.KupAl(5));

            OrganikKimya organikKimya = new OrganikKimya();

            organikKimya.KovalentBaglar();

            organikKimya.IyonikBaglar();

        }
    }
}
