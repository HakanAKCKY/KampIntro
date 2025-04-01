using System;

namespace Metotlar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Urun urun1= new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elması";
            urun1.Id =0;

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Adana Karpuzu";
            urun2.Id = 123;

            Urun[] urunler = new Urun[] {urun1,urun2 };
            foreach (var urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                if (urun.Id!=0) Console.WriteLine(urun.Id);
                Console.WriteLine(".............");
            }

            Console.WriteLine("............metotlar.............");

           SepetMenager sepetMenager = new SepetMenager();
            sepetMenager.Ekle(urun1);
            sepetMenager.Ekle(urun2);
               
            


        }
    }
}
