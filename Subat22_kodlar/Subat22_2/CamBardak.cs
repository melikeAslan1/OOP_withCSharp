﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat22_2
{
    class CamBardak :Urun, IKirilabilir
    {
        public bool Kirik { get; set; }

        public override string ToString()
        {
            return base.ToString() + $"{Kirik}";
        }
    }
}
