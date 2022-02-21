using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat21_4
{
    class Deneme<T> // burdaki T den dolayı instance oluştururken tip i vermek zorundayım. 
    {
        // tip de artık bir değişken gibi kullanılıyor.
        public void IslemA(T t)
        {

        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // burada bir zorunluluk var.
            Deneme<string> deneme = new Deneme<string>();

            List<int> liste = new List<int>();

        }
    }
}
