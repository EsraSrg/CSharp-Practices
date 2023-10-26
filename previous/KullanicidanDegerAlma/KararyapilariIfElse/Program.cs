using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KararyapilariIfElse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // kullanıcıdan 3 tane not alan ve bu notların ortalamasını bulan ve
            // eğer 80-100 A+
            // 60-80 A
            // 40-60 B+
            // 40 tan küçükse F yazdıran programı yazın.

            Console.WriteLine("Lütfen notunuzu giriniz:");

            int birinci_not = Convert.ToInt32(Console.ReadLine());
            int ikinci_not = Convert.ToInt32(Console.ReadLine());
            int ucuncu_not = Convert.ToInt32(Console.ReadLine());

            int sonuc = (birinci_not + ikinci_not + ucuncu_not) / 3;

            if (sonuc > 80 && sonuc < 100)
            {
                Console.WriteLine("Not değeriniz: A+");
            }
            else if (sonuc > 60 && sonuc < 80)
            {
                Console.WriteLine("Not degeriniz:A");
            }
            else if (sonuc > 40 && sonuc < 60)
            {
                Console.WriteLine("Not degeriniz: B+");

            }
            else 
                    {
                Console.WriteLine("Not degeriniz:F");
            }
           
        
        }
    }
}
