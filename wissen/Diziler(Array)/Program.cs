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



int [] uDizi= new int[6];

int [] rDizi=new int[6];

Random rnd=new Random();


for(int i=0; i<uDizi.Length;i++){

      System.Console.WriteLine("{0}. sayıyı girin.",i+1);
      uDizi[i] =int.Parse(Console.ReadLine());

      rDizi[i]=rnd.Next(1,49);

}
// iki diziyi kartezyen karşılaştırıp doğru sayı var mı yok mu kontrol edelim..

for(int i=0;i<rDizi.Length;i++){

    for(int j=0; j<uDizi.Length;j++){
        if( rDizi[i]==uDizi[j]){
            j++;
            System.Console.WriteLine("{0} adet dogru bildiniz..",j);
        }
    }
}


