using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlarornekk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Birinci sayıyı giriniz:");
            int sayi1 = int.Parse(Console.ReadLine());

            Console.WriteLine("İkinci sayıyı giriniz:");
            int sayi2 = int.Parse(Console.ReadLine());

            kontrolEt(sayi1,sayi2);
            Console.ReadLine(); 
        }

        static void kontrolEt(int a, int b)
        {
            if (a > b)
            {
                Console.Write("1. sayi 2. sayidan büyüktür..");
            }
            else if (a==b)
            {
                Console.Write("sayılar eşittir..");

            }
            else
            { Console.WriteLine("1. sayi 2. sayidan küçüktür..");
            }

        }
    }
}
