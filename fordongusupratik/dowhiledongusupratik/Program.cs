using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dowhiledongusupratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int toplam = 0;

            do
            {
                toplam += a;
                a = a + 1;


            } while (a <= 100);
            Console.WriteLine("1'den 100'e kadar olan sayıların toplamı:" + toplam);
            Console.ReadLine();
        }
    }
}
