using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat21_2
{
    // abstracct metodları kullanınca arada hiyerarşi olmak zorunda. Türetmeye bağımlılık var
    // fakat interfacte böyle bir bağımlılık yok.
   
    abstract class Sekil
    {
        public abstract void MetodA();

    }

    class Daire : Sekil
    {
        public override void MetodA()
        {
            throw new NotImplementedException();
        }
    }

    class Kare : Sekil
    {
        public override void MetodA()
        {
            throw new NotImplementedException();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
          
        }
    }
}
