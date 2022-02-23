using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat23_3
{  //EVENTS

//1. Temsilciye ihtiyaç var, bu temsilciyi siz de yazabilirsiniz var olan temsilciyi de kullanabilirsiniz.
//2. O temsilci tipinden event tanımlanır.
//3. Olayı tetikleyecek mekanizma kurulur. 
//4. Class oluşturulur.
//5. Olaya bir metot bağlanır. 
//6. Çalıştır.

    delegate void Temsilci();  //oluşturdum.

    class Buton
    {
        public event Temsilci Tikla;

        public void Calistir()   // çalıştırı çağırınca olay tetiklenmış olacak.
        {
            if (Tikla != null)
                Tikla();
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Buton btn = new Buton();

            btn.Tikla += Btn_Tikla;
            btn.Calistir();

        }

        private static void Btn_Tikla()
        {
            Console.WriteLine("Butona Tiklandi...");
        }
    }
}
