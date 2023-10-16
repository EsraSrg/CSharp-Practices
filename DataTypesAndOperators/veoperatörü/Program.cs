using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veoperatörü
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 9;
            int sayi2 = 9;
            int sayi3 = 8;

            bool KontrolEt = sayi1 == sayi2 && sayi1 > sayi3;
            Console.WriteLine(KontrolEt);
            Console.ReadLine();
            
        }
    }
}
