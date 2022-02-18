using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat18_4
{ //ENUM
    public enum Gunler : byte
    {
        Pazartesi,
        Sali=10,
        Carsamba,
        Persembe,
        Cuma,
        Cumartesi,
        Pazar
    }

    class Hafta
    {
        public Gunler Gun { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // string bir ifadeyi nümerik değere eşleştirmek istersek Enum kullanırız. 
            // enum sadece int üzerinden calışır.
            // tam sayılar 8 tane dir. 


            //enum sadece int alınır.varsayılan değeri
            // 

            // Console.ForegroundColor = ConsoleColor.Yellow;
            // Console.WriteLine("Merhaba");
            for (int i = 0; i < 16; i++)
            {
                Console.ForegroundColor = (ConsoleColor)i;
                Console.WriteLine("Merhaba");
            }
            //ConsoleKey
            Console.WriteLine((int)Gunler.Pazar);
            Hafta hafta = new Hafta();
            hafta.Gun = Gunler.Pazartesi; //belirlenen seçeneklerden birini seçmeye zorlar.
            hafta.Gun = (Gunler)1;



            Console.WriteLine((int) Gunler.Pazar);




        }
    }
}
