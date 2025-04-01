using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metotlar
{
    internal class SepetMenager
    {
        public void Ekle(Urun urun)
        {
            if (urun.Id==0)
            {
                Console.WriteLine("Tebrikler Sepete Eklendi = " + urun.Adi);
            }
            else
            {
                Console.WriteLine("Tebrikler Sepete Eklendi = " + urun.Adi + urun.Id);
            }
            
        }
    }
}
