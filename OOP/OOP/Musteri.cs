using System;
using System.Collections.Generic;
using System.Text;

namespace OOP
{
    class Musteri
    {
        public int MusteriID;
        public string MusteriAdi;
        public string MusteriSoyadi;
        public DateTime DogumTarihi;
        public Cinsiyetler Cinsiyeti { get; set; }

        public UrunSepeti MusterininUrunSepeti { get; set; }

        public void MusteriBilgileriYazdir()
        {
            Console.WriteLine("Musteri ID: " + MusteriID + "-"+ MusteriAdi + " " + MusteriSoyadi);
        }

        public void MusterininSepetiniYazdir()
        {

            int sayac = 1;
            foreach(var item in MusterininUrunSepeti.UrunlerListesi)
            {
                Console.WriteLine(sayac + ". ürününüz: " +  item.UrunAdi);
                sayac++;
            }


        }

    }
}
