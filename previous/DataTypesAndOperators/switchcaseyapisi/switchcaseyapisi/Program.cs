using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switchcaseyapisi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int bakiye = 700;
            Console.WriteLine("ATM'ye hoşgeldiniz..");
            Console.WriteLine("Yapmak istediğiniz işlemi seçiniz.");

            Console.WriteLine("1-bakiye görüntüle");
            Console.WriteLine("2-para çek");
            Console.WriteLine("3-para yatır");
            Console.WriteLine("4-çıkış yap");

            string secim = Console.ReadLine();

            switch (secim)
            {
                case "1":
                    Console.WriteLine("bakiyeniz:" + bakiye);
                    Console.ReadLine();
                    break;

                case "2":
                    Console.WriteLine("Çekmek istediğiniz tutarı giriniz:");
                    int cekilecek_tutar = Convert.ToInt32(Console.ReadLine());
                    if (cekilecek_tutar > bakiye)
                    {
                        Console.WriteLine("Bakiyenizden fazla para çekemezsiniz");
                        Console.ReadLine();
                    }
                    else
                    {
                        Console.WriteLine("Kalan bakiyeniz:" + (bakiye - cekilecek_tutar));
                        Console.ReadLine();
                    }
                    break;
                case "3":
                    Console.WriteLine("Yatırılacak tutarı giriniz");
                    int yatirilacak_tutar = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Yeni bakiyeniz:" + (bakiye + yatirilacak_tutar));
                    Console.ReadLine();
                    break;
                case "4":
                    Console.WriteLine("Hesabınızdan çıkış yapılıyor,iyi günler..");
                    Console.ReadLine();
                    break;
                default:

                    Console.WriteLine("Lütfen geçerli bir deger giriniz");
                    Console.ReadLine();
                    break;


            }
        }
    }
}
