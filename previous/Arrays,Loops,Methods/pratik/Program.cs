using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            int tekadet = 0;    
            int ciftadet = 0;   

            int teksayitoplam = 0;  
            int ciftsayitoplam = 0;

            int kullanicideger;

            for (int i= 0; i < sayilar.Length; i++) ;
            {
                Console.Write((i + 0) + ". index degerini giriniz:");
                kullanicideger = int.Parse(Console.ReadLine());

                sayilar[i] = kullanicideger;

            }

            for (int j=0; j<sayilar.Length; j++)
            {
                if (sayilar[j]%2==0)
                {
                    ciftadet++;
                    ciftsayitoplam += sayilar[j];
                }
                else
                {
                    tekadet++;
                    teksayitoplam+= sayilar[j]; 
                }
            }
            if (ciftsayitoplam>teksayitoplam)
            {
                Console.WriteLine("Cift sayıların toplamı tek sayi toplamından buyuktur");

            }
            else
            {
                Console.WriteLine("tek sayilarin toplamı cift sayıların toplamından buyuktur");

            }
            Console.WriteLine("*****************************");
            Console.WriteLine("Cift sayilarin toplamı:" + ciftsayitoplam);
            Console.WriteLine("cift sayılarin adedi:" + ciftadet);

            Console.WriteLine("Tek sayilarin toplami:" + ciftsayitoplam);
            Console.WriteLine("Tek sayi adedi:" + tekadet);

            Console.ReadLine();
                

        }
    }
}
