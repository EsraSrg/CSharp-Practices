using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlarornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("sayı giriniz:");
            int girilensayi = int.Parse(Console.ReadLine());

            tekmiciftmi(girilensayi);
            Console.ReadLine(); 
        }
        static void tekmiciftmi(int sayi)
        {
            if (sayi%2==0)
            {
                Console.WriteLine("sayı çifttir..");
            }
            else
            {
                Console.WriteLine("sayı tektir..");
            }

            Console.ReadLine(); 
        }
    }
}
