using System;

namespace clasintro
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string adi = "Hakan AKÇAKAYA";
            int yasi = 26;

            kurs kurs1 = new kurs();
            kurs1.kursAdi = "C#";
            kurs1.Egitmen = "Hakan AKÇAKAYA";
            kurs1.IzlenmeOrani = 01;

            kurs kurs2 = new kurs();
            kurs2.kursAdi = "Java";
            kurs2.Egitmen = "Hakan AKÇAKAYA";
            kurs2.IzlenmeOrani = 02;

            kurs kurs3 = new kurs();
            kurs3.kursAdi = "Phyton";
            kurs3.Egitmen = "Hakan AKÇAKAYA";
            kurs3.IzlenmeOrani = 03;

            kurs kurs4 = new kurs();
            kurs4.kursAdi = "C++";
            kurs4.Egitmen = "Hakan AKÇAKAYA";
            kurs4.IzlenmeOrani = 04;


            //Console.WriteLine(kurs1.kursAdi + " & " + kurs1.Egitmen);

            kurs[] kurslar = new kurs[] { kurs1, kurs2, kurs3, kurs4 };

            foreach (var kurs in kurslar)
            {
                Console.WriteLine(kurs.kursAdi + " : " + kurs.Egitmen + " : " + kurs.IzlenmeOrani);


            }
        }
    }
}
class kurs
{
    public string kursAdi { get; set; }
    public string Egitmen { get; set; }
    public int IzlenmeOrani { get; set; }





}