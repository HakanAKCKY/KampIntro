using System;

namespace KampIntro
{
    internal class Program
    {//degişkenler
        static void Main(string[] args)
        {
            //type safety= tip güvenliği
            //do not repeat yourself= kendini tekrarlama
            string katogoriEtiketi = "katogori"; //string= Metinsel değerler için degişken
            int ogrenciSayısı = 32000; //int= tam sayılar için degişken
            double faizOranı = 1.45;//double= ondalıklı sayılar için degişken
            bool SistemeGırısYapmısmı = true;
            double DolarDun = 3.35;
            double DolarBugun = 3.45;
            //if, else if, else koşul örnekleri
            if (DolarDun < DolarBugun)
            {
                Console.WriteLine("ARTIŞ GÖSTER");
            }
            else if (DolarDun > DolarBugun)
            {
                Console.WriteLine("AZALIŞ GÖSTER");
            }
            else
            {
                Console.WriteLine("EŞİTTİER GÖSTER");
            }


            if (SistemeGırısYapmısmı == true)//koşulun sağlandığı kodlar if içerisinde yer alır (eger)
            {
                Console.WriteLine("Kullanıcı Ayarları Butonu");
            }
            else//koşulun sağlanmadığı kodlar ise else içerisinde yer alır (degilse)
            {
                Console.WriteLine("Giriş Yap Butonu");
            }
            Console.WriteLine(katogoriEtiketi);

        }
    }
}
