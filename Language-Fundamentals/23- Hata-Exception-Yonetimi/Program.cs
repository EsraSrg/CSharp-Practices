/*
.net içerisinde 2 türlü hata var.
1- Derleme zamanı hatası
2- çalışma zamanı hatası

Çalışma zamanı hatası, yazılım içinde bir mantık hatası yapıldıgında ya da
gelen verilen düzgün kontrol edilmemesinden kaynaklanır.


// Bu derste, çalışma zamanı hatalarının nasıl kontrol altına alınacağını inceleyeceğiz.

// hata yönetimi 
// snytax 
/*

try
{
    Hata olması muhtemel kod blokları try içerisinde yazılır
    // try içerisindeki kod bloklarında, her hangi bir çalışma zamanı hatası olursa,
    // Catch bloğunun içerisindeki kodlar çalıştırılır

}
catch(Exception ex){
    // try bloğu içerisinde yazılı olan kod bloklarında bir çalışma zamanı hatası meydana gelirse, 
    // derleyici otomatik olarak Catch bloğu içerisinde gelir
    
}

*/

// Örnek : Sıfıra bölünme esnasında hata meydana gelecek biz bu hatayı try ve catch blokları ile yakalayalım



try
{
    // sıfır'a bölünmeme kuralı olduğu için, sayi2 değerine sıfır değer verilirse, bu kod bloğunda hata meydana gelecek
    Console.WriteLine("1 sayıyı giriniz");
    int sayi1 = int.Parse(Console.ReadLine());
    Console.WriteLine("2. sayıyı giriniz");
    int sayi2 = int.Parse(Console.ReadLine());

    int sonuc = sayi1 / sayi2;
    Console.WriteLine(sonuc);

    // biz tüm kodları try blokları içerisinde yazsak ne olur
    // Cevap : Try blokları derleyici tarafından daha yavaş şekilde işletildiği için
    // tüm yazılımı try blokları içerisinde koymak performans açısından mantıklı değil
    

}
catch
{

    Console.WriteLine("Bir şekilde hata meydana geldi");

}


try
{

    Console.WriteLine("1. sayıyı giriniz");
    int sayi1 = int.Parse(Console.ReadLine());

    Console.WriteLine("2. sayıyı giriniz");
    int sayi2 = int.Parse(Console.ReadLine());

    int sonuc = sayi1/sayi2;
}
catch (Exception e)
{

// exceptionların sebeplerini ekrana yazdıralım 

// e. message ile hata mesajının kendine ulaşabiliriz.

Console.WriteLine("Message : "+e.Message);
// e üzerinden bir çok detaya daha ulaşılabilif
// örnek hatanın olduğu kod satırını bile hata mesajı üzeirnden ulaşabilirsiniz
Console.WriteLine("Stack Trace: "+e.StackTrace);

}

﻿try
{

    Console.WriteLine("1. sayıyı giriniz");
    int sayi1 = int.Parse(Console.ReadLine());

    Console.WriteLine("2. sayıyı giriniz");
    int sayi2 = int.Parse(Console.ReadLine());

    int sonuc = sayi1 / sayi2;
}// Catch bloğu sadece devidebyzero hatalarını yakalar, diğer hiç bir hatayı yakalamaz
catch(DivideByZeroException ex)
{
    // yukarıdaki kod bloğundan iki tür hata meydana gelebilir
    // DevideByZero Exception
    // Format Exception 

    // Catch Bloklarını sadece belirli exceptionları yakalamak için özelleştirebiliriz
    // bunun için, Catch keyword'ünün yanına o exception türünü yazmamız yeterli olacaktır
    Console.WriteLine("ikinci sayı sıfır olmamalı");
}
// format exception hatalarını yakalamak için ne yapabiliriz
// catch blokları çoğaltılabilir
catch(FormatException ex){

    Console.WriteLine("sayı yerine boşluk yada harf yazmayınız");
}

