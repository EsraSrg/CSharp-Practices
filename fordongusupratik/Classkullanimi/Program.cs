using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classkullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            araba a1 = new araba();
            a1.kapiSayisi = 4;
            a1.arabaRengi = "Kırmızı";
            a1.arabaModel = "Renault";

            a1.kapilarKilitle();
            a1.motorCalistir();

            Console.WriteLine("Arabanin kapi sayisi:" + a1.kapiSayisi);
            Console.WriteLine("Araba rengi:" + a1.arabaRengi);
            Console.WriteLine("arabanın modeli:" + a1.arabaModel);

            Console.ReadLine();

        }
         
    }
}
