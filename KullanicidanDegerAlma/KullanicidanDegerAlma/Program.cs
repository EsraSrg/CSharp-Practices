using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanDegerAlma
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Lütfen isminizi giriniz:");
            string isim = Console.ReadLine();
            Console.Write("Lütfen soyisminizi giriniz:");
            string soyisim = Console.ReadLine();

            Console.WriteLine("Kullanıcının ismi:" + isim);
            Console.WriteLine("Kullanıcının soyismi:" + soyisim);

            Console.ReadLine(); 
          
        }
    }
}
