using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat21_6
{  // 2. Tip güvenliği - Generic kullanırken 2. avantaj -

    // generic list in avantajı hatayı bize design time zamanında vermesi. 
    // biz run time da hata almayı hiç istemeyiz. kodun exception a düşmesini istemeyiz. 
   // run time da hata almak demek benim kontrolümden artık çıkması demek kötü. 
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list1 = new ArrayList() { 1, 4, 6, 8, 9 };      //"on" design time da hata vermez. toplarken run time da hata verir.

            List<int> list2 = new List<int>() { 1, 4, 6, 8, 9 };  // "on" direk hata verir design time da.

            int toplam = 0;

            foreach (int sayi in list1)
            {
                toplam += sayi;
            }
            Console.WriteLine(toplam);

            toplam = 0;
            foreach (int sayi in list2)
            {
                toplam += sayi;
            }
            Console.WriteLine(toplam);


        }
    }
}
