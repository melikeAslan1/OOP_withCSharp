using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat23_1
{
    class Program
    {
        delegate int Temsilci();

        static public int MetodA()
        {
            return 4;
        }
        static public int MetodB()
        {
            return 1;
        }

        static public int MetodC()
        {
            return 5;
        }

        static void Main(string[] args)
        {
            Temsilci t = new Temsilci(MetodA);
            t += new Temsilci(MetodB);
            t += MetodC;
            t += MetodB;
            Console.WriteLine(t());
        }
    }
}

