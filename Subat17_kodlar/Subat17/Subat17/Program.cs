using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat17
{
    class Araba
    {
        public virtual void Sur()
        {
            Console.WriteLine("Araba Sur...");
        }
    }

    class Ferrari: Araba
    {
        public override void Sur()
        {
            Console.WriteLine("Ferrari Sur...");
        }

    }

    class Mercedes:Araba
    {
        public override void Sur()
        {
            Console.WriteLine("Mercedes Sur...");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            //polimorfizm:

            //Araba araba = new Araba();
            //Ferrari ferrari = new Ferrari();
            //Mercedes mercedes = new Mercedes();

            Araba araba = new Araba();
            Araba ferrari = new Ferrari();
            Araba mercedes = new Mercedes();
            araba.Sur();
            ferrari.Sur();
            mercedes.Sur();

            Object obj = new Ferrari();
            ((Ferrari)obj).Sur();



        }
    }
}
