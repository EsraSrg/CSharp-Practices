using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlaragiris
{
    internal class Program
    {
        static void Main(string[] args)
        { // parametresiz - geriye döndürmeyen metot tanımlama..
            selamver();
            adiniyazdir();

        }
        static void selamver()
        {
            Console.WriteLine("Selamlar :))");
            
        }

        static void adiniyazdir()
        {
            Console.WriteLine("Esra Sergiser..");
            Console.ReadLine(); 
        }

    }
}
