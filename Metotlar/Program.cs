using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya Elması";

            string[] meyveler = new string[] { };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyat = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.stokAdedi = 9;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyat = 80;
            urun2.Aciklama = "Adana Karpuzu";
            urun2.stokAdedi = 8;

            Urun[] urunler = new Urun[] { urun1, urun2 };

            //Type-safe = tip güvenliği
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyat);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine(urun.stokAdedi);
                Console.WriteLine("---------------------------------------");
            }
            Console.WriteLine("---------------------Metotlar---------------------");
            
            //encapsulation = kapsulleme

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut", "Yeşil Armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil Elma", 12,9);
            sepetManager.Ekle2("Karpuz", "Adana Karpuzu", 12, 8);

        }
    }
}

//Dont repeat yourself - DRY= Kendini Tekrar Etme
//Clean Code= Temiz Kod 
//Best Practice= En İyi Uygulama

