using System;

namespace ClassIntro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi= "Hakan";
            int yasi = 27;

            Kurs kurs1 = new Kurs();
            kurs1.KursEgitmen = "Hakan";
            kurs1.KursAdi = "C#";
            kurs1.KursIzlenmeOranı = 1;

            Kurs kurs2 = new Kurs();
            kurs2.KursEgitmen = "Hakan1";
            kurs2.KursAdi = "C";
            kurs2.KursIzlenmeOranı = 2;

            Kurs kurs3 = new Kurs();
            kurs3.KursEgitmen = "Hakan2";
            kurs3.KursAdi = "C++";
            kurs3.KursIzlenmeOranı = 3;

            Kurs kurs4 = new Kurs();
            kurs4.KursEgitmen = "Hakan3";
            kurs4.KursAdi = "Python";
            kurs4.KursIzlenmeOranı = 4;



            Console.WriteLine(kurs1.KursAdi+ " = "+kurs1.KursEgitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.KursAdi+" = "+kurs.KursEgitmen+" = "+kurs.KursIzlenmeOranı);
            }
        }
    }
    //class birden fazla veriyi tanımlayan bir tip tanımlamak için kullanılır, string veya intanger gibi
    class Kurs
    {
        public string KursAdi { get; set; }
        public string KursEgitmen { get; set; }
        public int KursIzlenmeOranı { get; set; }

    }
}

