using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat22_2
{
    class Market<T> where T:Urun
    {
        List<T> urunler = new List<T>();

      public void UrunEkle(T t)
        {
            urunler.Add(t);
        }

        public List<T> TumUrunler()
        {
            return urunler;
            // neden console. writeLine ile yazdırmadım ?
            // ne yazarsanız yazın(ister metot ister baska bişey) ortam bağımsız olmasına çalışın. neden console ile yazdırmadım çünkü o zmn sadece 
            // console da yazdırmış olurdum.
            // ortam bağımlı yazarsam gidip kodu değiştirmem gerekir mesela formda kullancam kodu değiştirmem gerekir.
        }

        public List<IKirilabilir> KirikUrunler()
        {
            List<IKirilabilir> urunler = new List<IKirilabilir>();

            foreach (var item in urunler)
            {
                if (item.Kirik)
                    urunler.Add(item);
            }
            return urunler;
        }

        public List<IBozulabilir> BozukUrunler()
        {

            List<IBozulabilir> _urunler = new List<IBozulabilir>();
            foreach (Urun item in urunler)
            {
                var urun = item as IBozulabilir;
                if (urun != null && urun.SKT < DateTime.Now)
                    _urunler.Add(urun);
            }
            return _urunler;
        }

    }
}
