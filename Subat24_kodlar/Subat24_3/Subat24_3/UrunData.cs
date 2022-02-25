using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subat24_3
{
    static class UrunData
    {
        static UrunData()
        {
            List<Urun> _urunler = new List<Urun>(){

                  new Urun() {UrunID=111,UrunAd="A4 Defter",Fiyat=25,KategoriID=1},
                  new Urun() {UrunID=112,UrunAd="Cetvel",Fiyat=25,KategoriID=1},
                  new Urun() {UrunID=113,UrunAd="Satranç",Fiyat=75,KategoriID=2},
                  new Urun() {UrunID=114,UrunAd="Tavla",Fiyat=60,KategoriID=2}                  };

            List<Kategori> _kategoriler = new List<Kategori>
            {
                new Kategori{KategoriID=1,KategoriAd="Kırtasiye"},
                new Kategori{KategoriID=2,KategoriAd="Hobi"}
            };

            Urunler = _urunler;
            Kategoriler = _kategoriler;
        }
        static public List<Urun> Urunler { get; set; }
        static public List<Kategori> Kategoriler { get; set; }
    }
}
