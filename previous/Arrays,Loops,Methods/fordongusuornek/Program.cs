using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fordongusuornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen bir sayı giriniz..");
            int sayi = Convert.ToInt32(Console.ReadLine());
            int toplam = 0;
            for (int i= 1; i <= sayi; i++)
            {
                toplam += 1;

            }
            double ortalama = toplam / sayi;
            if (ortalama > 50)
            {
                Console.WriteLine("Ortalamanız 50'den büyüktür..");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Ortalamanız 50'den küçüktür..");
                Console.ReadLine();
            }
        }
    }

}
