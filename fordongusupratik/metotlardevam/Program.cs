using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlardevam
{
    internal class Program
    {
        static void Main(string[] args)
        {   // parametre alan - geriye değer döndürmeyen metot yazma
            //toplamayap(3, 4);
            carpmayap(5, 6, 7);
            Console.ReadLine();

        }
        static void toplamayap(int sayi1, int sayi2)
        {
            Console.WriteLine("sayilarin toplami:" + (sayi1 + sayi2));

        }
        static void carpmayap(int sayi1, int sayi2, int sayi3)
        {
            Console.WriteLine("sayilarin carpimi:" + (sayi1 * sayi2 * sayi3));
        }
    }
}
