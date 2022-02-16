using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat15_inheritance
{
    class SekilAna
    {
        public float pi { get; set; }
        public float uzunluk { get; set; }

        public float yaricap { get; set; }
    }

    class Daire: SekilAna
    {
        public Daire(float Pi,float Uzunluk, float Yaricap)
        {
            this.pi = Pi;
            this.uzunluk = Uzunluk;
            this.yaricap = Yaricap;
        }


        //public float DaireAlan()
        //{
        //    float daireAlan=
        //}
    }
    class Sekil
    {

    }
}
