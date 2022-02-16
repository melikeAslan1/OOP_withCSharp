using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat15
{
    class Depo
    {
        
        //en capsülation access modifiers lar ile ilgili. 
       // indeksleyicide bir tane collections bir tane property olması gerekiyor.
       // bir class ın sanki bir dizi gibi kullanılmasıdır indeksleyici. 
        private string[] _repo = new string[10];

        public string this[int indis]
        {
            get { return _repo[indis]; }
            set { _repo[indis] = value; }
        }

    }
    class Program
    {
        static void Main(string[] args)
        {
            Depo depo = new Depo();
            depo[0] = "";

            string strMesaj = "Merhaba";

            for(int i=0; i<strMesaj.Length; i++)
            {
                Console.WriteLine(strMesaj[i]);


            }

            // metot a girilen sayının faturadaki gibi yazıyla çıkması. mesela 1275 girdi metot a 
            // Bin iki yüz yetmiş beş. olarak çıkacak. ödevv. 
            // rastgele olarak kar yağacak, kar,   o dolu. * kar. | yagmur.   objeli birşey, nesne yönelimli programlama ile yapılacak.














        }
    }
}
