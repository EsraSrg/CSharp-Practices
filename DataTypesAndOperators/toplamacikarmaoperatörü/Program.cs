using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace toplamacikarmaoperatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 7;
            int sayi2 = 9;
            int sayi3 = 10; 
            int sayi4 = 11;

            int sonuc = (sayi1 + sayi2 + sayi3) - sayi4;

            Console.WriteLine(sonuc);
            Console.ReadLine(); 
        }
    }
}
