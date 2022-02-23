using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Subat23_4
{
    public delegate void Temsilci();
    class Isitici
    {
        public int ISI { get; set; }
        public event Temsilci Kabarciklanma;
        public event Temsilci SeCikarma;
        public event Temsilci Fokurdama;

        public void Calistir()
        {
            for (int i = 0; i < 120; i++)
            {
                Thread.Sleep(50);
                ISI++;
                Console.WriteLine(ISI);

                if (ISI >= 30 && ISI < 50 && Kabarciklanma != null)
                {
                    Kabarciklanma();   //Temsilcinin içi boş olamaz dolayısıyla bu kod yazılır. 
                }
                else
                     if (ISI >= 50 && ISI < 80 && SeCikarma != null)
                {
                    SeCikarma();
                }
                else if (ISI >= 80 && ISI < 110 && Fokurdama != null)
                {
                    Fokurdama();
                }
            }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Isitici isitici = new Isitici();

            isitici.Kabarciklanma += İsitici_Kabarciklanma;
            isitici.SeCikarma += İsitici_SeCikarma;
            isitici.Fokurdama += İsitici_Fokurdama;

            isitici.Calistir();
        }

        private static void İsitici_Fokurdama()
        {
            Console.WriteLine("fokurr fokurr fokurr");
        }

        private static void İsitici_SeCikarma()
        {
            Console.WriteLine("Ccsssssssssssssssssssss");
        }

        private static void İsitici_Kabarciklanma()
        {
            Console.WriteLine("ooooooOOOOOOooooooooooOOOOOOO");
        }
    }
}
