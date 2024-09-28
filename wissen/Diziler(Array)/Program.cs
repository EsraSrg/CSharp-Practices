// Dizi syntax
// int[] dizi= new int[1000];  bu dizi 100 degisken alabilir içine.

// 1)dizi tanımlanırken, kesinlikle kaç elemanlı olacağını bildirmeniz gerekir.
// 2)dizi tanımlandığı tipte veriler içerebilir.
// 3) dizilerin başlangıc degeri onların kapasitesini belirler.Kapasite aşımı yapmaya çalıştığınızda çalışma zamanı hatası olabilir.

//int[] DiziAdi= new int[3];



//int tipinde dizi tanımladık. Dizinin içindeki elemanı yazdıralım. dizinin taşıyacağı eleman sayısı 3.
//1. indexe deger atayalım

/*
DiziAdi[1]=80;
System.Console.WriteLine(DiziAdi[1]);
//dizi elemanının index numarasını vererek çağırılır. 0 dan başlar index numaraları.

var myDizi= new int[3]; // alternatif dizi tanımı

*/


// Kullanıcıdan gireceği not adedini sorduk
//not girişini dizi içine aldik
//notları ekrana yazdırdık

/*
Console.WriteLine("Kaç adet not gireceksiniz?");
int adet=int.Parse(Console.ReadLine());

int [] notlar= new int[adet];

for(int i=0;i<notlar.Length;i++){

    Console.WriteLine("{0}. notu giriniz",i+1);
    int not=int.Parse(Console.ReadLine());
   notlar[i]=not;
}

Console.WriteLine("Girilen notlar:");
for (int i = 0; i < notlar.Length; i++) {
    System.Console.WriteLine(notlar[i]);
}

*/

// 10 adet eleman taşıyan dizi tanımla
//dizinin tüm elemanlarını 1-100 arası random sayı ile doldur.

/*

int [] dizi=new int[10];

Random rnd=new Random();

for(int i=0;i<dizi.Length;i++){

  dizi[i]=rnd.Next(1,100);

}

for(int i=0;i<dizi.Length;i++){

    System.Console.WriteLine("{0}. Random eleman:{1}",i+1,dizi[i]);
}

*/


// 100 elemanlı diziye 10 harflik random kelime atadık..

/*

string [] dizi=new string[100];

Random rnd=new Random();


for(int i=0;i<dizi.Length;i++){
    string metin="";

    for(int j=0;j<10;j++){

        char karakter=Convert.ToChar(rnd.Next('a','z'));
        metin+=karakter;
        
    }

    dizi[i]=metin;
    System.Console.WriteLine("{0}. dizi elemanı:{1}",i+1,dizi[i]);
}

*/



//kullanıcıdan 1-49 arasında 6 adet sayı alın ve diziye atın.
// aynısını random yapıp diziye at bir de
// bu iki dizideki sayılar birbirinde var mı kıyasla...



// int[] random = new int[6];
// int[] kullanici = new int[6];

// Random rnd = new Random();
// for(int i = 0; i < random.Length;i++){

//     // hem kullanıcıdan alalım, hemde random dolduralım

//     Console.WriteLine("{0}. sayı tahminini giriniz",i+1);
//     kullanici[i]=int.Parse(Console.ReadLine());

//     // random sayıyı üretip diziye basalım
//     random[i]=rnd.Next(1,49);
// }
// // iki diziyi kartezyen karşılaştırıp doğru sayı var yok kontrolü yapalım
// for(int i = 0;i<random.Length;i++){

//     for(int j=0;j<random.Length;j++){

//         if(random[i]==kullanici[j]){

//             Console.WriteLine("Doğru tahmin edilen sayı : {0}",random[i]);

//         }
//     }
// }


// 

// Örnek 
// 6 tane sayı belirleyip, 30 yıl boyunca aynı sayıya oynamak
// altı sayı belirleyip, devamlı farklı random sayılar çekip, bu sayılar ile karşılaştırın
// her bir for bir haftayı belirlesin Datetime kullanabilirsiniz
// bakım bakalım, kaç hafta aynı sayılara oynayıp, 5 sayı biliyorsunuz

// haftayı for döngüsü olarak alınız
// bir hafta 15 tl olarak, hesaplayın, 5 bulduğunuz haftayı ve ne kadar para ödediğinizi 
// ekrana yazdırınız
// Datetime kullanarak her hafta yı dateyime olarak atayın, 5 tutturma zamanı hangi yılda olacak 
// ve kaç para harcamış olacaksınız bunu ekrana yansıtın

// 

// datetime konusu 
// for döngüsünde bir hafta bir hafta artırarak devem etmek

/*
DateTime now=DateTime.Now;

for(int i=0;i<100;i++){

    
    Console.WriteLine(DateTime.Now.AddDays(7).ToString());

    System.Threading.Thread.Sleep(1000); //çıktıları 1000 milisaniye bekleyerek veriyor. Derleyiciyi istediğimiz kadar bekletebiliriz.
}
    
*/


// not: forr yazıp tab e basarsan ters döngüsü geliyor

/*

int [] dizi=new int[10];
int [] newDizi=new int[10];

for(int i=0;i<dizi.Length;i++){
    Console.WriteLine("{0}. elemanı girin",i+1);
    dizi[i]=int.Parse(Console.ReadLine());
}

for (int i = 0; i < dizi.Length; i++)
{
    newDizi[i] = dizi[dizi.Length - 1 - i];
}


for (int i = 0; i < newDizi.Length; i++)
{
    Console.Write("{0}-",newDizi[i]);
}

*/

//DİZİLERLE İLGİLİ HAZIR FONKSİYONLARA ARRAY SINIFI ÜZERİNDEN ERİŞEBİLİRSİNİZ.


int[] ints=new int[100];
ints[89]=10;
// değerin hangi indexte oldugunu söyler

// ? nullable degerler...

int hangiIndex=Array.IndexOf(ints,10);    
System.Console.WriteLine(hangiIndex);  

// aynı deger birden fazla indexte varsa, ilk bulundugu indexi yazar..yoksa -1



// indexof aksine, aranan degerin en son bulundugu indexi yazar
//Array.LastIndexOf();


int[] reverseArray = new int[5];
reverseArray[0]=7;
reverseArray[1]=80;
reverseArray[2]=6;  
reverseArray[3]=2;

//  yukarıdaki diziyi Array.Reverse ile ters çevirelim 
//  ters çevirmemizi istediği diziyi aldı ve ters çevirdi.
Array.Reverse(reverseArray);
for(int i=0;i<reverseArray.Length;i++){
   Console.WriteLine(reverseArray[i]);
}

// ödev:bubble sorting ile 20 elemanlı diziyi sırala..


// Array.Clear diziyi temizlemek için kullanılır(Dizi içerisindeki tüm elemanlar siliniz);
//Array.Clear(reverseArray);

// Array.Copy
// bir dizinin kopyasını oluşturmak için Array.Copy fonksiyonu kullanılabilir


int[] destinationArray = new int[5];
Array.Copy(reverseArray,destinationArray,reverseArray.Length);
for(int i=0; i<reverseArray.Length;i++){
    Console.WriteLine(destinationArray[i]);

}

//---------------------------------------------------------------------------------------------
// Array.Sort diziyi sıralar(rakamları küçükten büyüğe, harfleri ise, alfabetik sıraya göre sıralar)
/*Array.Sort(reverseArray);
for(int i=0;i<reverseArray.Length;i++){
    Console.WriteLine(reverseArray[i]);
}*/


// Array.Clear diziyi temizlemek için kullanılır(Dizi içerisindeki tüm elemanlar siliniz);
//Array.Clear(reverseArray);

// Array.Copy
// bir dizinin kopyasını oluşturmak için Array.Copy fonksiyonu kullanılabilir


/*int[] destinationArray = new int[5];
Array.Copy(reverseArray,destinationArray,reverseArray.Length);
for(int i=0; i<reverseArray.Length;i++){
    Console.WriteLine(destinationArray[i]);

}
*/

// Örnek
// Kullanıcıdan 10 adet sayı alınız.
// bu sayıların tek sayı olanları tek sayi dizisine, çift sayı olanları çift sayı dizine atalım

/*int[] ciftDizi = new int[10];
int[] tekDizi = new int[10];

for(int i = 0; i <ciftDizi.Length;i++){

    Console.WriteLine("Bir sayı giriniz");
    int sayi = int.Parse(Console.ReadLine());
    if(sayi%2==0){

        ciftDizi[i]=sayi;
    }
    else{
        tekDizi[i]=sayi;
    }
}
// Dizileri listeyelim 
for(int i = 0;i<ciftDizi.Length;i++){

    Console.WriteLine("Çift Dizi {0}",ciftDizi[i]);
    Console.WriteLine("Tek Dizi  {0}",tekDizi[i]);
}
*/


// Örnek : 
// Bir string dizisi içerisinde, 10 adet isim giriniz

// daha sonrada  bu 10 adet isim dizisinin, içerisinde gezip, ilk harf ve son harfi gösterip, 
// aradaki harfleri ** yapıp yeni diziye atan uygulama

// Örnek : Elif -> E**f
// Hüsamettin -> H********n
/*string[] isimler = new string[10];
string[] gizliIsimler = new string[10];
isimler[0]="Ayşe";
isimler[1]="Ali";
isimler[2]="Selçuk";
isimler[3]="Pınar";
isimler[4]="Orhun";
isimler[5]="Ebru";
isimler[6]="Barış";
isimler[7]="Özlem";
isimler[8]="Alihan";
isimler[9]="Bahadır";

for(int i=0;i<isimler.Length;i++){
    // isimler dizisi içerisinde dön!!
    
    // ismin ilk karakteri için
    string start = isimler[i].Substring(0,1);
    // ismin son karakteri için
    string end = isimler[i].Substring(isimler[i].Length-1,1);
    //string newIsim ="";

    // V1
    /*for(int j=0;j<isimler[i].Length-2;j++){

         newIsim +="*";
         
    }

    //V2
    //gizliIsimler[i]=start.PadRight(isimler[i].Length-1,'*')+end;

}
// işler bitti, ekrana yazdıralım
for(int i=0;i<gizliIsimler.Length;i++){
    Console.WriteLine(gizliIsimler[i]);
}
*/

// Örnek 
// Uygulama 5 adet not istesin, ve bu notlari dizide tutalim, 
//notlari aldiktan sonra kullaniciya asagidaki soruyu sorup, geregini yapalim. 
//Degistirmek istediginiz not varsa 1 e basin, (hangi notun degisecegini sorup degeri 
//sormak gerekecek) notlari siralanmis listelemek icin 2 e basin, cikmak icin 3 e basin.
/*int[] nots = new int[5];


 for(int i=0; i<5;i++){
    Console.WriteLine("{0}. notu giriniz",i+1);
    nots[i]=int.Parse(Console.ReadLine());

 }

// uygulama exit yapana kadar sonsuza kadar dönecek
 while(true){
 //Not alımı bitti
 Console.WriteLine("Not alımı bitti");
 Console.WriteLine("Aşağıdaki işlemleri yapabilirsiniz");
 Console.WriteLine("Not Değiştirmek için 1");
 Console.WriteLine("Not Sıralamak için 2");
 Console.WriteLine("Çıkmak için 3'e basınız");
 string secim = Console.ReadLine();
 if(secim=="1"){

    //[1][3][4][5][100][2]
    //100 değerini 500 değeri ile değiştir
    Console.WriteLine("Not değiştirme bölümüme hoşgeldiniz");
    Console.WriteLine("Değiştirmek istediğiniz notu giriniz");
    int not = int.Parse(Console.ReadLine());
    Console.WriteLine("Yeni notu giriniz");
    int newNot = int.Parse(Console.ReadLine());
    int arrayIndexNo = Array.IndexOf(nots,not);
    nots[arrayIndexNo]=newNot;
    for(int i=0; i<nots.Length;i++){
        Console.WriteLine(nots[i]);
    }
 }
 else if(secim=="2"){

    Array.Sort(nots);
    for(int i=0; i<nots.Length;i++){

        Console.WriteLine(nots[i]);
    }
 }
 else if(secim=="3"){

    // uygulama sonlandı
    break;
 }
 }
 */

 // Örnek Anlatım

string[] isimler = new string[3];
isimler[0]="Ayşe";
isimler[1]="Ali";
isimler[2]="Mehmet";

// Örnek : Örnekteki dizinin ilk harflerini ekrana yazdırınız
for(int i=0;i<3;i++){

    Console.WriteLine(isimler[i][0]);

}
// yukarıdaki örnekte, isimler dizisi içerisindeki string değer ekrana yazdırılıyor.
// string bir idade de ayrıca bir dizi olduğu için tekrar index numarası ile char değer çağrılabilir.
// String bir ifade, char dizisidir.
string deger = "wissen";
Console.WriteLine(deger[0]);
// bu sebeple, string ifade de istenilen karaktere ulaşmak için [] kullanılabilir.

// Unutmamanız için tekrar
// DİKKAT !!!! String bir char dizisidir.

// string'in char dizisi olması ile ilgili bir örnek yapalım
// 10 adet ismin olduğu bir dizi alınız kullanıcıdan,
// dizi giriş tamamlandıktan sonra, 
// dizi içerisinde isimlerin, tersten yazılışlarını ekrana yazdırınız

string[] names = new string[10];
for(int i =0;i<10;i++){

    Console.WriteLine("{0}. ismi giriniz",i+1);
    names[i]=Console.ReadLine();
}
for(int i =0;i<names.Length;i++){
// dizi içerisinde dönmek için
    string ters ="";
   for (int j = names[i].Length - 1; j>= 0 ; j--)
   {
        ters+=names[i][j];
        // i = 0  = Ali - > j=2 = i
        // i = 0  = Ali - > j=1 = l
   }
   Console.WriteLine(ters);
}

//Ali    i = 0 
//Veli   i = 1
//Mehmet i = 2

// A  j = 0
// l  j = 1
// i =j = 2