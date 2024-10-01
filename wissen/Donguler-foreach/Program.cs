// foreach dongusu for ve while dongusunden farklı olrak bir döngü değişkenine ihtiyaç duymaz.
//artırım ifadesine de ihtiyaç duymaz.
// bir koşula bağlı da dönmez.

//tanım

// arrayList icinde donelim.

using System.Collections;

/*
ArrayList arrayList=new ArrayList();

arrayList.Add("Istanbul");
arrayList.Add("Izmir");
arrayList.Add("Rize");
arrayList.Add("muğla");
arrayList.Add("maras");
arrayList.Add("hatay");

foreach(object item in arrayList){

    System.Console.WriteLine(item);
}

//object: koleksiyon icindeki eleman tipi ne ise o tip olmalı.
// item: dongu her tur dondugunde, dongu icerisindeki o anki elemandır.
//in :  bir keyworddur.
// arraylist: bu kısma döneceginiz koleksiyonu yazmalısınız.

// başı ve sonu belli olan koleksiyonlarda koleksiyon sonuna kadar döner..şarta ihtiyaç duymaz.

// foreach her zaman belli bir istisna hariç : her zaman ileri yonlu iterasyon yapar.

// break continue gibi atlama deyimleri bu dongude de vardir.


// key value koleksiyonu için döndüreceksen DictionaryEntry ile yapabilrsin

/*
SortedList sortedList=new SortedList();

sortedList.Add("1","adana");
sortedList.Add("2","rize");
sortedList.Add("3","izmir");

foreach(DictionaryEntry item in sortedList){
    System.Console.WriteLine("key:{0} value:{1}",item.Key,item.Value);

}

//örnek: kullanıcıdan aldıgın not sayisina göre not toplamı ve ortalamayi yazdir.

ArrayList notlar=new ArrayList();

int toplam=0;

System.Console.WriteLine("kaç not gireceksiniz?");
int notSayisi=int.Parse(Console.ReadLine());

for(int i=0;i<notSayisi;i++){
    System.Console.WriteLine("{0}. notu giriniz.",i+1);
    int not=Convert.ToInt32(Console.ReadLine());
    notlar.Add(not);
}


foreach(int not in notlar){
    toplam+=not;

}
System.Console.WriteLine("toplam:{0} ortalama:{1}",toplam,toplam/notSayisi);

*/

// dizi icinde donelim

string [] teknoloji={"c#","docker","kubernetes","rust","css","RabbitMq","go","java"};


foreach(string tech in teknoloji){
    System.Console.WriteLine(tech);
}


int [] plakalar={35,09,25,35,29};

foreach(int plaka in plakalar){
    System.Console.WriteLine("plaka:{0}",plaka);
}

Random [] randoms={new Random(), new Random(), new Random()};

foreach(Random rnd in randoms){
    System.Console.WriteLine(rnd.Next());
}



int [] randomlar ={new Random().Next(),new Random().Next(),new Random().Next()};

foreach(int random in randomlar){

    System.Console.WriteLine(random);
}

//carpim tablosu


int [] nums={1,2,3,4,5,6,7,8,9,10};

foreach(int i in nums){

    foreach(int j in nums){

        System.Console.WriteLine("{0}x{1}={2}",i,j,i*j);


    }
    System.Console.WriteLine("---------------");
}