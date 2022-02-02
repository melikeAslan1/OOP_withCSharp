﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Ders_11_OOP_Encapsulation
{
    class Kiralama
    {
      

        public int ID { get; set; }
        public Bisiklet Bisiklet { get; set; }
        public Kullanici Kullanici { get; set; }
        public float Sure { get; set; }
        public float Ucret { get; set; }
        public DateTime BaslamaZamani { get; set; }
        public DateTime BitisZamani { get; set; }
        public float SaniyeUcreti { get; set; }
        public Kiralama()
        {
            SaniyeUcreti = 0.25f;
        }

        public void Baslat()
        {
            BaslamaZamani = Convert.ToDateTime("2022.02.02 13:30:00.000");


           // BaslamaZamani = DateTime.Now;
        }

        public void Bitir()
        {
            BitisZamani = DateTime.Now;
            UcretHesapla();
        }

        public void UcretHesapla()
        {
            TimeSpan zamanFarki = BitisZamani - BaslamaZamani;
            int farkSaniye = zamanFarki.Hours * 3600 + zamanFarki.Minutes * 60 + zamanFarki.Seconds;

        //    int farkSaniye = zamanFarki.Seconds;
            
            Console.WriteLine("Fark: " + farkSaniye);

            Sure = (float) farkSaniye;

            Ucret = Sure * SaniyeUcreti;

            BilgiYaz();



        }

        public void BilgiYaz()
        {
            Console.WriteLine("Sayin" + Kullanici.AdSoyad + "\n"
             + "Başlama Zamanı: " + BaslamaZamani + "\n"
              + "Bitiş Zamanı: " + BitisZamani + "\n"
              + "Toplam Süre:"+ Sure + "\n"
              + "Toplam ödemeniz gereken tutar: " + Ucret + "Tl dir");


        }



    }
}
