using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotornek
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz..");
            int sayi = int.Parse(Console.ReadLine());

            int karesi = kareal( sayi); 

            if (karesi>25)
            {
                Console.WriteLine("Karesi 25'ten büyüktür..");
            }
            else
            {
                Console.WriteLine("Karesi 25'ten küçüktür..");

            }

            Console.ReadLine(); 
              


        }

        static int kareal(int a)
        { 
            return a*a; 
        
        }   
    }
}
