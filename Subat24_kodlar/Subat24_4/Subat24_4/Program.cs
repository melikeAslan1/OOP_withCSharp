using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat24_4
{
    // Exception Handling(İstisnaların Yakalanması)

   // 1. Gramer hatası gibi, Syntatic Error
   // 2. Mantıksal Hatalar.. bunları yakalamak zordur.

    // istisna: bir uygulama çalışırken uygulamanın belirli nedenlerle rutinin dışında sonlandırılması.
    // hata olunca program exe dosyasını sonlandırdı biz bunu istemiyoruz.
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10, b = 0, c = 0;
            int[] sayilar = { 3, 6, 7, 1 };

            try
            {
               // int s = sayilar[10];
               c = a / b;
            }

            catch(DivideByZeroException ex)
            {
                Console.WriteLine("Dosyaya Yaz... Sıfıra Bolunme");
            }
            
            catch(IndexOutOfRangeException ex)
            {
                Console.WriteLine("SMS gönder...Index Out oF RANGE");
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

            catch()
            {
                Console.WriteLine("istisnai bir durum oluştu....");
            }

            Console.WriteLine("Bölmeden sonraki işlemler...");
            Console.WriteLine(c);

        }
    }
}
