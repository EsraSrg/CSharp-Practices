using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BreakPointveToolTip
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // breakpoint: kod satırlarını tek tek derleyerek nasıl çalıştığını anlama
            //konusunda iş görür.
            int a = 4;
            int b = 5;  
            int c = 6;  

            int sonuc = a+ b + c;   
            Console.WriteLine(sonuc);   
            Console.ReadLine(); 

            // tooltip yandaki açıklama kutucuğu.
        }
    }
}
