using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace diziornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = { 10, 10, 30, 66, 86, 80, 80, 64, 43, 43, 1, 1, 1, 1, 1};
            int adet = 0;
            int sayi;

            Console.WriteLine("Lütfen bir sayı giriniz..");
            sayi = Convert.ToInt32(Console.ReadLine());

            for (int i = 0; i < sayilar.Length; i++)
            {
                if (sayi == sayilar[i])
                {
                    adet++;
                }

                if (adet == 0)
                {
                    Console.WriteLine("Girdiğiniz değer bulunamadi..");
                }
                 
                else
                {
                    Console.WriteLine("Girdiğiniz değer dizide bulundu..");
                    Console.WriteLine("adet:" + adet);
                }

                Console.ReadLine();

            }
        }
    }
      
}
