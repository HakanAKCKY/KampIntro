using System;

namespace DegerVeReferansTipler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            Console.WriteLine(sayilar1[0]);


            //Değer Tipleri: “int”, “long”, “float”, “double”, “decimal”, “char”, “bool”, “byte”, “short”, “struct”, “enum”
            //Referans Tipleri: “string”, “object”, “class”, “interface”, “array”, “delegate”, “pointer”
            // STACK : Yukarıda belirtilen değer tipindeki veriler ile değişken tanımlandığında bu değişkenin değeri RAM’in Stack bellek bölgesinde tutulur. Mikroişlemciler ile veri çekilip yazılır.
            //HEAP : Heap’te stack bölgesi gibi RAM’deki hafıza alanlarından biridir. Referans tiplerinden biri ile değişken tanımlandığında, değişkenin değeri Heap bölgesinde tutulur. Bununla beraber Heap bölgesindeki bu değişkenin adresi ise Stack bölgesinde tutulur.
            //NOT : Referans tipinde bir değişkene bellekte yer ayırmak için “new” kullanılır. “new” deyimi, nesneleri oluşturmak yada daha önceden oluşturulmuş olan nesneleri çağırmak için kullanılır.
        }
    }
}
