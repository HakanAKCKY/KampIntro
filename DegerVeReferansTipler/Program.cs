using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Deger tipler(int, decimal, float, double, bool)
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            //Referans tipler(array, class, interface)
            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);

            // bellekte 2 alan vardır stack, heap olarak
            // deger tipler stack te kalır, referan tipler ise verileri heap'e kaydeder






        }
    }
}
