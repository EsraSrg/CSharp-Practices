using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace miniATM
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 1000;

            Console.WriteLine("Atm'ye hoşgeldiniz.");
            Console.WriteLine("Yapmak istediğiniz islemi seçin:");

            string secim = Console.ReadLine();

            if (secim == "1")
            {
                Console.WriteLine("Suanki bakiyeniz:" + bakiye);
                Console.ReadLine();
            }
            else if (secim == "2")
            {
                Console.WriteLine("Cekmek istediginiz tutarı giriniz:");
                int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());

                if (cekilecek_tutar <= bakiye)

                {
                    Console.WriteLine("Kalan tutar:" + (bakiye - cekilecek_tutar));
                    Console.ReadLine();
                }
                else
                { Console.WriteLine("Bakiyenizden büyük bir tutar cekemezsiniz.")
                        Console.ReadLine();
                }
            }
            else if (secim == "3")
            {

                Console.WriteLine("Yatırmak istediginiz tutarı girin:");
                int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Yeni bakiyeniz:" + (bakiye + yatirilacak_tutar));
                Console.ReadLine();
            }
            else if (secim == "q")
            {

                Console.WriteLine("ATM'den cıkış yapılıyor...");
                Console.WriteLine("ATM'den cıkış yapıldı,iyi günler..");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("Lütfen geçerli bir deger giriniz.");
                Console.ReadLine();

            }
            

        }
    }
}
