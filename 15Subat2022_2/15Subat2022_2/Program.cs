using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _15Subat2022_2
{
    class Program
    {
        static void MetodA(int sayi)
        {
            Console.WriteLine("MetodA içi (atamadan once)" + sayi);
            sayi = 999;
            Console.WriteLine("MetodA içi (atamadan sonra)" + sayi);
        }

        public static void Yazdir(int[] sayilar)
        {
            foreach (int sayi in sayilar)
                Console.WriteLine(sayi + " ");
            Console.WriteLine();
        }
        static void MetodB(int[] sayilar)
        {
            Console.WriteLine("Metod B içi (atamadan önce) ");

            Yazdir(sayilar);

            for (int i = 0; i < sayilar.Length; i++)

                sayilar[i] = -555;
            Console.WriteLine("Metod B içi (atamadan sonra) ");

        }
        static void Main(string[] args)
        {
            //4- ctor (yapıcı, inşa edici metodlar)
            //5- destructure (yıkıcı metod)

            int number = 1;
            MetodA(number);
            Console.WriteLine("Metod çağrıldıktan sonra " + number);

            int[] numbers = { 2, 2, 2, 2, 2, 2 };

            MetodB(numbers);

            Console.WriteLine("MetodB çağrıldıktan sonra");

            Yazdir(numbers);



        }
    }
}
