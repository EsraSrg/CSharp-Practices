 using System;
 using System.Collections;  //namespace cagirmak icin using ifadesi kullanılır..


//koleksiyonlar eleman girdikçe grnişleyen yapıdadır.

ArrayList arraylist=new ArrayList();  // içerisine object değer alır
   

// arrayliste eleman girdikçe kapasitesini arttırır.

//arrayList içindeki eleman sayısını gormek ıcın
int count=arraylist.Count;

//arrayList'in alabilecegi eleman sayısını belirtir. Capacity siz eleman girdikçe artar.
int capacity=arraylist.Capacity;

// arrayList icinden veri cekmek icin , dizilerdeki gibi.
// string deneme=arraylist[0].ToString();



// Öğrenciden 10 adet not alıp bu notların toplamı ve ortalamsını ekrana yazdıralım

/*ArrayList notlar = new ArrayList();
for (int i = 0; i < 10; i++){

    Console.WriteLine("{0}. notu giriniz",i+1);
    notlar.Add(Console.ReadLine());
}
Console.WriteLine("Not girişi tamamlandı, entera basarak not bilgilerini alabilirsiniz");
Console.ReadLine();

int toplamNot = 0;
for (int i = 0;i<notlar.Count;i++){

  toplamNot+=int.Parse(notlar[i].ToString());

}
Console.WriteLine("Notlatın toplamı : {0} Ortalamsı : {1}",toplamNot,toplamNot/notlar.Count);
*/

// Sayısal loto oyununu arraylist ile yapınız

/*ArrayList kullanicidanGelen = new ArrayList();
ArrayList random=new ArrayList();

ArrayList bilinenSayilar = new ArrayList();

Random rnd = new Random();
for(int i=0;i<6;i++){

    Console.WriteLine("{0} sayıyı giriniz",i+1);
    kullanicidanGelen.Add(int.Parse(Console.ReadLine()));   
    random.Add(rnd.Next(1,49));
}

Console.WriteLine("Tahminlerin bitti, çekilişi görmek için enter");
Console.ReadLine();

// iki tane koleksiyonu kartezyen biçimde karşılaştıralım
for(int i=0;i<kullanicidanGelen.Count;i++){

    for(int j=0;j<random.Count;j++){
        // burada iki koleksiyonu birbiri ile karşılaştıralım
       if(Convert.ToInt32(kullanicidanGelen[i])==Convert.ToInt32(random[j])){

            // sayı bilinmiş demektir.
            bilinenSayilar.Add(kullanicidanGelen[i]); 

       }

    }
}
// Bilinen sayıları ekrana yazdıralım
Console.WriteLine("Bilinen Sayılar");
for(int i=0;i<bilinenSayilar.Count;i++){

    Console.Write("{0}-",bilinenSayilar[i]);
}
*/

// 1 ay sonraya not : 


// Koleksiyonların fonksiyonlarına göz atalım

ArrayList liste  = new ArrayList();

// Koleksiyonun içerisindeki verileri siler
//liste.Clear()

// Koleksiyon içerisindeki verileri sıralar
liste.Sort();

// Koleksiyon içerisindeki verileri tersten sıralar
liste.Reverse();

// Koleksiyonu diziye dönüştürür
object[] objectArray = liste.ToArray();

// koleksiyon içerisinde arama yapar, verdiğiniz değer koleksiyon içerisinde varsa, true yoksa false döndürür.
liste.Contains("10");

//Insert fonksiyonu, koleksiyon içerisine bir veriyi eklemek için kullanılır
// iki tane parametre alır.  ilk parametre hangi index'e eklemek istediğiniz. 
// ikinci paramtre ise verinin kendisidir.
liste.GetRange(1,10);
// GetRange fonksiyonu, koleksiyon içerisinden birden fazla veri getirmek için kullanılır
// verinin geleceği index ve bu indexden sonra kaç index veri getirilsin parametreleri ile çalışır
liste.Insert(4, "Insert et");

// Koleksiyonlarda count ve capacity birbirine eşitlemek için kullanılır.

// Örnek : Count : 5 Capacity : 8 ise, TrimToSize yapılınca, count ve capacity birbirine eşit oluyor.
liste.TrimToSize();









// ögrenciden 10 not al ve ortalama ve toplamını yazdır.
/*
for(int i=0; i<10; i++){
    System.Console.WriteLine("{0}. notu girin.",i+1);
    arraylist.Add(Console.ReadLine());  

  
}
 int topla=0;
 double ortalama=0;
for(int i=0; i<10; i++){

     topla += (int)(arraylist[i]);
     ortalama=topla/10;
  
  
   } 
   for(int i=0; i<10; i++){

   System.Console.WriteLine("Nor ortalama:{0} toplam:{1}",ortalama,topla); }
   */


// Sayısal loto oyununu arraylist ile yapınız

/*
ArrayList kullanicidanGelen = new ArrayList();
ArrayList random=new ArrayList();

ArrayList bilinenSayilar = new ArrayList();

Random rnd = new Random();

for(int i=0;i<6;i++){

    Console.WriteLine("{0} sayıyı giriniz",i+1);
    kullanicidanGelen.Add(int.Parse(Console.ReadLine()));   
    random.Add(rnd.Next(1,6));
}

Console.WriteLine("Tahminlerin bitti, çekilişi görmek için enter");
Console.ReadLine();

// iki tane koleksiyonu kartezyen biçimde karşılaştıralım
for(int i=0;i<kullanicidanGelen.Count;i++){

    for(int j=0;j<random.Count;j++){
        // burada iki koleksiyonu birbiri ile karşılaştıralım
       if((int)kullanicidanGelen[i]==(int)random[j]){

            // sayı bilinmiş demektir.
            bilinenSayilar.Add(kullanicidanGelen[i]);
                continue;

       }

    }
}
// Bilinen sayıları ekrana yazdıralım
Console.WriteLine("Bilinen Sayılar");
for(int i=0;i<bilinenSayilar.Count;i++){

    Console.Write("{0}-",bilinenSayilar[i]);
}
*/

