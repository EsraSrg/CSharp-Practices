using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace geriyedegerdondurenmetot
{
    internal class Program
    {
        static void Main(string[] args)
        { // parametre alan - geriye deger döndüren metot tanımlama.
            // return anahtar kelimesi
            // metot sonu.
            string gelenadsoyad = isimsoyisimdondur("Esra", "Sergiser");
            Console.WriteLine(gelenadsoyad);
            Console.ReadLine();

        }

        static string isimsoyisimdondur(string isim,string soyisim)
        {
            return isim + " " + soyisim;

            // return
            // 1. degerleri  döndürmesi
            // 2. return anahtar kelimesi metodu bitiren anahtar kelimedir.
        }  
    }
}
