using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat22_2
{
    class Yumurta : Urun, IKirilabilir, IBozulabilir
    {
        public bool Kirik { get; set; }
        public DateTime SKT { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{SKT} {Kirik} ";


        }
    }
}
