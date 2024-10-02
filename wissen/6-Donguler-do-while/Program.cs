// string kullaniciAdi="root";
// string sifre="2209";

// string userName;
// string password;

// do{
//     Console.WriteLine("kullanıcı adınızı girin..");
//     userName=Console.ReadLine();

//     System.Console.WriteLine("sifreyi girin..");
//      password=Console.ReadLine();


// if(kullaniciAdi!=userName && sifre!=password){
//     System.Console.WriteLine("hatalı giriş..");
// }
// }
// while(kullaniciAdi!=userName && sifre!=password);

// System.Console.WriteLine("hoşgeldiniz..");




  Console.Write("Kaç elemanlı Fibonacci dizisi:");
        int sayi = Convert.ToInt32(Console.ReadLine());

        var a = 0;
        var b=1;
        int deger;

        Console.WriteLine("Fibonacci Dizisi: ");
        for (int i = 0; i < sayi; i++)

        {     
             deger=a+b;
            Console.Write(deger+"-");
           
           a=b;
           b=deger;

        }






