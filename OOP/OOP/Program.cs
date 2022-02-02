using System;


namespace OOP
{
    class Program
    {
       

        static void Main(string[] args)
        {

            try
            {
                Urun u1 = new Urun()
                {
                    UrunAdi = "Ekmek",
                    UrunId=1000,
                    UrunKategorisi= UrunKategorileri.Gida

                };

                Urun u2 = new Urun()
                {
                    UrunAdi = "Şarj Aleti",
                    UrunId = 1001,
                    UrunKategorisi = UrunKategorileri.Elektronik

                };

                Urun u3 = new Urun()
                {
                    UrunAdi = "Şampuan",
                    UrunId = 1002,
                    UrunKategorisi = UrunKategorileri.Temizlik
                };


                Urun u4 = new Urun()
                {
                    UrunAdi = "Süt",
                    UrunId = 1003,
                    UrunKategorisi = UrunKategorileri.Gida
                };

                Musteri m = new Musteri()
                {
                    // Auto Property;
                    MusteriID = 1,
                    Cinsiyeti = Cinsiyetler.Erkek,
                    DogumTarihi = new DateTime(1969, 1, 1),
                    MusteriAdi = "Veysel",
                    MusteriSoyadi = "Perü"
                };

                UrunSepeti musterininSepeti = new UrunSepeti()
                {
                    MusteriId = m.MusteriID,
                    SepetID = 1
                };

                musterininSepeti.UrunlerListesi.Add(u1);
                musterininSepeti.UrunlerListesi.Add(u2);

                musterininSepeti.UrunlerListesi.Add(u3);

                musterininSepeti.UrunlerListesi.Add(u4);

                // önce sepeti ve sepete eklenecek ürünleri yukarıda aldık, sonra bu sepeti müşteriye atadık.

                m.MusterininUrunSepeti = musterininSepeti;

                m.MusteriBilgileriYazdir();




            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.ToString());
            }




        }
    }
}
