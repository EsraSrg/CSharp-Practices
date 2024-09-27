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

/*
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
*/
// ödev:bubble sorting ile 20 elemanlı diziyi sırala..


