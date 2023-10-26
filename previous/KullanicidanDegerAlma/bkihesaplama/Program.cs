using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace bkihesaplama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Boyunuzu giriniz");
            double boy = Convert.ToDouble(Console.ReadLine());

            double bke = kilo / (boy * boy);

            if (bke < 18)
            {
                Console.WriteLine("zayıfsınız");
                Console.ReadLine();
            }
            else if (bke > 18 && bke < 25)
            {
                Console.WriteLine("normalsiniz");
                Console.ReadLine();
            }
            else if (bke > 25)
            {
                Console.WriteLine("obezsiniz");
                Console.ReadLine();
            }
        }

    }
}    
