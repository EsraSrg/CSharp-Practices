using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDönüsümleri
{
    internal class Program
    {
        static void Main(string[] args)
        {

           
            // STRİNG VERİ TİPİNDEN İNT VERİ TİPİNE DÖNÜŞÜM
            //  int a = int.Parse(sayi1);
            // int b = int.Parse(sayi2);
            // Console.WriteLine(a + b); 
            //int a = Convert.ToInt32(sayi1);
            //int b = Convert.ToInt32(sayi2);

            // İNT VERİ TİPİNDEN STRİNGE DÖNÜŞÜM
            /*int sayi1 = "5";
            int sayi2 = "10";

            string a = sayi1.ToString();
            string b = sayi2.ToString();    
            Console.WriteLine(a+b);   
            Console.ReadLine();  */
            
            // DOUBLE VERİ TİPİNDEN İNTE DÖNÜŞÜM

           /* double sayi = 5.22;
            int a = Convert.ToInt32(sayi);
            // int b = int.Parse(sayi);
            Console.WriteLine(a);   
            Console.WriteLine(sayi.GetType());
            Console.ReadLine();  */

            // Kullanıcıdan alınan veriler string veri tipinde olur.

           /* Console.WriteLine("Lütfen yaşınızı girin:");

            string kullanici_yas = Console.ReadLine();

            int kullanici_yasInt = int.Parse(kullanici_yas);
            int kullanici_yasInt2 = Convert.ToInt32(kullanici_yas);
            Console.WriteLine(kullanici_yasInt);
            Console.WriteLine(kullanici_yasInt2);
            Console.ReadLine();  */

            // kullanıcıdan 2 tane sayı alan ve toplamını ekrana yazdıran program.

            Console.WriteLine("1. sayıyı giriniz:");
            string sayi1 = Console.ReadLine();
            Console.WriteLine("2. sayıyı giriniz:");
            string sayi2 = Console.ReadLine();
            
            int sayi1Int =int.Parse(sayi1);
            int sayi2Int =int.Parse(sayi2);

            Console.WriteLine("sayıların toplamı:" + (sayi1Int + sayi2Int));
            Console.ReadLine();

            // ToString();
            // Convert.ToInt();
            // double.Parse();
            //int.Parse();
            // (int)
;








        }   
    }
}
