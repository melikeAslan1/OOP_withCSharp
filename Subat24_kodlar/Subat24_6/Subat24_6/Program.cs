using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat24_6
{
    class BesOlamazHatasi: Exception
    {
        public override string Message => "5 olamaz istisnası...";
    }
    class Program
    {
        static void Main(string[] args)
        {
            throw new BesOlamazHatasi();

        }
    }
}
