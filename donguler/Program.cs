using Microsoft.VisualBasic;
using System;

namespace donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";
            string kurs4 = "Python";
            string kurs5 = "C#";

            Console.WriteLine("Yazılım geliştirici yetiştirme kampı");
            Console.WriteLine("Programlamaya başlangıç için temel kurs");
            Console.WriteLine("Java");
            Console.WriteLine("Python");
            Console.WriteLine("C#");


            Console.WriteLine("for döngüsü başla");

            //array= dizi 
            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı",
                "Programlamaya başlangıç için temel kurs", "Java", "Python","C#" };
            //for C# programlama dilinde for döngüsü, belirli bir koşul sağlanana kadar tekrarlanmasını sağlayan önemli bir kontrol yapısıdır.
            for (int i = 0; i<kurslar.Length; i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("foreach döngüsü başla");

            //foreach döngünün ne kadar döneceği dizinin eleman sayısına bağlı olarak program tarafından otomatik hesaplanacaktır.
            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

            Console.WriteLine("SAYFA SONU");


        }



    }
}
