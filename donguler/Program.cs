﻿using System;

namespace donguler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım geliştirici yetiştirme kampı";
            string kurs2 = "programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            //array, dizi

            string[] kurslar = new string[] { "Yazılım geliştirici yetiştirme kampı","programlamaya başlangıç için temel kurs","Java","python","C#"};

            for (int i = 0; i <kurslar.Length; i++)

               
            {
                Console.WriteLine(kurslar[i]);
            }

            Console.WriteLine("for bitti");

            foreach (string kurs in kurslar)
            {
                Console.WriteLine(kurs);
            }

           

            Console.WriteLine("sayfa sonu");
        }
    }
}
