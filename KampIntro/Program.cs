using System;
using System.ComponentModel.Design;

namespace KampIntro
{
    class Program
    {
        static void Main(string[] args)
        {

            //type safety - tip güvenliği
            //deger tutucu, alias
            //do not your self, kendini tekrarlama 
            string kategorilerEtiketi = "Kategori";
            int ögrenciSayısı = 32000;
            Double faizOranı = 1.45;
            bool sistemeGirisYapilmisMi = true;
            Double dolarDun = 7.45;
            Double dolarBugun = 7.45;


            if (dolarBugun > dolarDun)
            {
                Console.WriteLine("ARTIŞ GÖSTER");
            }

            else if (dolarDun>dolarBugun)
            {
                Console.WriteLine("AZALIŞ GÖSTER"); 
            }
            else
            {
                Console.WriteLine("EŞİTTİR GÖSTER");
            }
            
            //{
               // Console.WriteLine("AZALIŞ GÖSTER");
           // }

           // if (sistemeGirisYapilmisMi == true)
            //{
                //Console.WriteLine("Kullanıcı ayarları butonu");
           // }
           // else
           // {
               // Console.WriteLine("Giriş yap butonu");
            //}
            //Console.WriteLine(kategorilerEtiketi);

        }
    }
}