// See https://aka.ms/new-console-template for more information
// 2 farklı koşul yöntemi var:
// 1) ıf-else if-else
// 2) switch case yöntemi

#region If yöntemi
// Koşul değişkeni her zaman mantıksal operatörlerden gelen bir değer olmalı(true,false)
/*

bool isOk=true;

Console.WriteLine("A");
if (isOk)
{
  Console.WriteLine("B");
}
Console.WriteLine("C")

// if içine değişken yerine mantıksal deger üretecek bir kod bloğu yazılabilir.

Console.WriteLine("değer girin..");
int intDegisken=int.Parse(Console.ReadLine());
if(intDegisken>5)
{
  Console.WriteLine("Girilen deger 5'den büyük.");
}

*/
#endregion


#region Örnekler
/*
Console.WriteLine("harf girin, küçük ya da büyük");
char karakter=char.Parse(Console.ReadLine());
int intDegisken=Convert.ToInt32(karakter);

if(intDegisken>64 && intDegisken<91)
{
  Console.WriteLine("büyük harf")
}
else{
 Console.WriteLine("küçük harf");
}
     

System.Console.WriteLine("Bir karakter girin:");

char charDegisken = char.Parse(Console.ReadLine());

if (charDegisken >= 'A' && charDegisken <= 'Z') 
{
    Console.WriteLine("Büyük Harf");
}

else{
    Console.WriteLine("Küçük Harf");
}




System.Console.WriteLine( "Kullanıcı adınızı girin..");
string userName=Console.ReadLine();
System.Console.WriteLine("Şifrenizi girin");
string password=Console.ReadLine();

if(userName=="wissen" && password=="1010")
{
    System.Console.WriteLine("Giriş Başarılı..");
}
else{
    System.Console.WriteLine(   "Giriş Başarısız");
}



using System.Runtime.InteropServices;

System.Console.WriteLine("Fiyatı giriniz..");
double fiyat=double.Parse(Console.ReadLine());

if(fiyat>100)
{ fiyat=fiyat+fiyat*0.2;
    Console.WriteLine(fiyat);
}
else{
    fiyat=fiyat-fiyat*0.3;
    System.Console.WriteLine(fiyat);
}
*/
#endregion

#region if -else if-else ve iç içe if kullanımı

// 0 kontrolü içeren hesap makinesi..
/*
Console.WriteLine("lütfen ilk sayıyı girin:");
int num1=int.Parse(Console.ReadLine());

System.Console.WriteLine( "işlemi girin..(+,-,*,/)");
char islem=char.Parse(Console.ReadLine());

System.Console.WriteLine( "lütfen ikinci sayıyı girin");
int num2=int.Parse(Console.ReadLine());

if(islem=='+')
{
  System.Console.WriteLine("{0}{1}{2}={3}",num1,islem,num2,num1+num2);
}
else if(islem=='-')
{
  System.Console.WriteLine("{0}{1}{2}={3}",num1,islem,num2,num1-num2);
}
else if(islem=='*')
{
  System.Console.WriteLine("{0}{1}{2}={3}",num1,islem,num2,num1*num2);
}
else if(islem=='/')
{
   if(num2!=0)
   {
    System.Console.WriteLine("{0}{1}{2}={3}",num1,islem,num2,num1/num2);
   }
   else{
    System.Console.WriteLine("bölen 0 olamaz..");
   }
}
else
{
  System.Console.WriteLine("geçersiz..");
}

*/


#endregion

//not kullanının girdiği karakterleri küçük harfe dönüştürmek için toLower() veya boşluk kontrolü için Trim() kullanabilirsin.


#region Ternary operatörü

//hızlıca tek satırda kontrol edeceğimiz bir durum için if yerine ternary operatörünü kullanabiliriz.

//syntax
/*
bool isOk=true;

string degisken=isOk?"true":"false";

System.Console.WriteLine( degisken);

*/



//ekrana girilen metin 10 karakterden fazlaysa çok uzun,10 karakterden az ise çok kısa yazsın.
//string ifadenin karakter sayısını .Length ile alabiliriz.
/*
System.Console.WriteLine( "kullanıcı adınızı belirleyin..");
string metin=Console.ReadLine();

string karakter=metin.Length>10?"çok uzun":"çok kısa";

System.Console.WriteLine( karakter);


*/

//alınan karakter a ile başlıyorsa,a ile başlıyor,başamıyorsa a ile başlamıyor yazdıralım

/*
System.Console.WriteLine("metin giriniz..");
string metin=Console.ReadLine();

string result=metin.ToLower().StartsWith('a')?"a ile başlıyor":"a ile başlamıyor";

System.Console.WriteLine( result);

*/
#endregion

#region switch case yapısı

//hesap makinesinde bölen 0 kontrolünü yapalım..
/*
System.Console.WriteLine( "1. sayı:");
int num1=int.Parse(Console.ReadLine());

System.Console.WriteLine("işlemi yazın:+,-,*,/");
char islem=char.Parse(Console.ReadLine());

System.Console.WriteLine( "2. sayı:");
int num2=int.Parse(Console.ReadLine());

switch(islem)
{
   case '+':
   System.Console.WriteLine(num1+num2);
   break;
   case '-':
   System.Console.WriteLine(num1-num2);
   break;
   case '*':
   System.Console.WriteLine(num1*num2);
   break;
   case'/':

    switch(num2)
    {
      case 0:
      System.Console.WriteLine("bölen 0 olamaz");
      break;
      default:
      System.Console.WriteLine(num1/num2);
      break;
    }
    break;
    default:
    System.Console.WriteLine( "geçersiz ifade..");
    break;
    




}
*/

//haftaiçi gün girildiyse haftaiçi,haftasonu girildiyse haftasonu yazdıralım.

System.Console.WriteLine("gün:");
string gun=Console.ReadLine();

switch(gun)
{
  case "pazartesi":
  case "salı":
  case "carsamba":
  case "persembe":
  case "cuma":
  System.Console.WriteLine("haftaiçi bir gün..");
  break;
  case "cumartesi":
  case "pazar":
  System.Console.WriteLine("haftasonu bir gün..");
  break;
  default:
  System.Console.WriteLine("lütfen bir gün giriniz..");
  break;
 


}
#endregion

