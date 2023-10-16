using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace forEachDongusu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = { "Veli", "Aysun", "Büşra", "Ayşe" };

            /*foreach ( string a in isimler)
            {
                Console.WriteLine(a);
            }*/

            double[] os = { 1.2, 2.7, 1.9 };
            foreach(double e in os) 
            { 
                Console.WriteLine(e);   
            
            }

            Console.ReadLine();
        }
    }
}
