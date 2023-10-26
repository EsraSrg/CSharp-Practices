using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraypratik
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // string[] isimler = { "Esra", "Büşra", "Merve", "Helin" };
            //double ondalikli_sayilar
            char[] karakter = { 'E', 'S', 'R', 'A' };

            for (int i=0; i<karakter.Length; i++)
            {
                Console.WriteLine(karakter[i]);
            }
            Console.ReadLine(); 
        }
    }
}
