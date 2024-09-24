// Dizi syntax
// int[] dizi= new int[1000];  bu dizi 100 degisken alabilir içine.

// 1)dizi tanımlanırken, kesinlikle kaç elemanlı olacağını bildirmeniz gerekir.
// 2)dizi tanımlandığı tipte veriler içerebilir.
// 3) dizilerin başlangıc degeri onların kapasitesini belirler.Kapasite aşımı yapmaya çalıştığınızda çalışma zamanı hatası olabilir.

int[] DiziAdi= new int[3];



//int tipinde dizi tanımladık. Dizinin içindeki elemanı yazdıralım. dizinin taşıyacağı eleman sayısı 3.
//1. indexe deger atayalım

DiziAdi[1]=80;
System.Console.WriteLine(DiziAdi[1]);
//dizi elemanının index numarasını vererek çağırılır. 0 dan başlar index numaraları.

var myDizi= new int[3]; // alternatif dizi tanımı