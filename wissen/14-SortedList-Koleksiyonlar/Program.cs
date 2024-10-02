// SortedList : önceki koleksiyonlardan farklı olarak key ve value çifti taşırlar.

//syntax

using System.Collections;

// SortedList sortedList=new SortedList();

// sortedList.Add(1,"Ali");
// sortedList.Add(3,"Hande");
// sortedList.Add(9,"Esra");
// sortedList.Add(7,"selçuk");

//SortedList Koleksiyonu key ve value degerlerini object tipinden aldıgı için degerleri int ya da string girebiliriz.
// key degerlerine göre sıralama islemi yapar.
//Ekrana yazdırma:

/*
for(int i=0;i<sortedList.Count;i++){

    string value=sortedList.GetByIndex(i).ToString(); 
    Console.WriteLine(value);
}
*/

// key ve value tasıdıgi icin Contains(arama) fonk iki tanedir.
// ConstainsKey ve ContainsValue key arama ve value arama icin kullanılır.

/*
bool isContainsKey=sortedList.ContainsKey(1);

System.Console.WriteLine(isContainsKey);

bool isContainsValue=sortedList.ContainsValue("Esra");
System.Console.WriteLine(isContainsValue);
*/

SortedList sortedList=new SortedList();

sortedList.Add(01, "Adana");
sortedList.Add(02, "Adıyaman");
sortedList.Add(03, "Afyonkarahisar");
sortedList.Add(04, "Ağrı");
sortedList.Add(05, "Amasya");
sortedList.Add(06, "Ankara");
sortedList.Add(07, "Antalya");
sortedList.Add(08, "Artvin");
sortedList.Add(09, "Aydın");
sortedList.Add(10, "Balıkesir");
sortedList.Add(11, "Bilecik");
sortedList.Add(12, "Bingöl");
sortedList.Add(13, "Bitlis");
sortedList.Add(14, "Bolu");
sortedList.Add(15, "Burdur");
sortedList.Add(16, "Bursa");
sortedList.Add(17, "Çanakkale");
sortedList.Add(18, "Çankırı");
sortedList.Add(19, "Çorum");
sortedList.Add(20, "Denizli");
sortedList.Add(21, "Diyarbakır");
sortedList.Add(22, "Edirne");
sortedList.Add(23, "Elazığ");
sortedList.Add(24, "Erzincan");
sortedList.Add(25, "Erzurum");
sortedList.Add(26, "Eskişehir");
sortedList.Add(27, "Gaziantep");
sortedList.Add(28, "Giresun");
sortedList.Add(29, "Gümüşhane");
sortedList.Add(30, "Hakkari");
sortedList.Add(31, "Hatay");
sortedList.Add(32, "Isparta");
sortedList.Add(33, "Mersin");
sortedList.Add(34, "İstanbul");
sortedList.Add(35, "İzmir");
sortedList.Add(36, "Kars");
sortedList.Add(37, "Kastamonu");
sortedList.Add(38, "Kayseri");
sortedList.Add(39, "Kırklareli");
sortedList.Add(40, "Kırşehir");
sortedList.Add(41, "Kocaeli");
sortedList.Add(42, "Konya");
sortedList.Add(43, "Kütahya");
sortedList.Add(44, "Malatya");
sortedList.Add(45, "Manisa");
sortedList.Add(46, "Kahramanmaraş");
sortedList.Add(47, "Mardin");
sortedList.Add(48, "Muğla");
sortedList.Add(49, "Muş");
sortedList.Add(50, "Nevşehir");


for(int i=0;i<sortedList.Count;i++){

    string value=sortedList.GetByIndex(i).ToString(); 
    
    Console.WriteLine((i+1)+" "+value);
}


// 4 koleksiyona baktık. Generic ile sonra devam edecegiz.