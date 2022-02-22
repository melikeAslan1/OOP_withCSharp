using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ornek2
{
    class Asker
    {
     static   int sayac = 0;

        public Asker()
        {
            sayac++;
            Console.WriteLine(sayac);
        }

        ~Asker()
        {
            sayac--;
            Console.WriteLine(sayac);
        }

    }
        // t anında RAM de herhangi bir classta kac tane olduğunu nasıl anlarsınız. 
    class Program
    {
        static void Main(string[] args)
        {
            Asker a1 = new Asker();
            Asker a2 = new Asker();
            Asker a3 = new Asker();


        }
    }
}
