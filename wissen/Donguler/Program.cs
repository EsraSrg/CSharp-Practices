// Döngü çeşitleri
//for döngüsü
// foreach döngüsü
// do while

//dönen döngüyü durdurmak için
//1-kaçiş keywordleri kullanilabilir(break,continue,return)
//2-mevcur koşulu bozarak döngüden çıkılabilir.

#region Sonsuz Döngü
/*
int a=10;
for(;;){
    a++;
    System.Console.WriteLine(a);
}
*/

#endregion


//1000 den 0 a

// for(int i=1000;i>0;i--)
// {
//     System.Console.WriteLine(i);
// }
/*
int a;
for(a=90;a<100;){
    a++;
    System.Console.WriteLine(   a);
}

*/
/*
int a;
int b=0;

for(a=20;a<200;){

    System.Console.WriteLine(  a);
    b++;
    System.Console.WriteLine(   b);
}

*/

//if i döngüden çıkmak için kullandık
/*
for(int i=10;i<100;i++){
  System.Console.WriteLine(i);
    if(i==50){
        i=101;
        
    }
}
*/


#region carpim tablosu
/*
for (int i=1;i<=10;i++){

    for(int j=1;j<=10;j++){

        System.Console.WriteLine("{0}x{1}={2}",i,j,i*j);
        }
        System.Console.WriteLine("----------------------------");

*/
#endregion

#region random sayi al ,en buyuk ve en kucugu yazdir.
//  Random rnd=new Random();

//  int tekToplam=0;
//  int ciftToplam=0;

// for(int i=0;i<1000;i++){

//  int a=rnd.Next(0,100);
//     if(a%2==0){
//         ciftToplam++;
    
//     }
//     else{
//         tekToplam++;
//     }
    
// }
// System.Console.WriteLine( "{0} adet cift,{1} adet tek",ciftToplam,tekToplam);



#endregion

/*
for(int i=0;i<=10;i++){
    // int a=rnd.Next(65,90);
   
    // char harf=Convert.ToChar(a);
   char harf=(char)rnd.Next('A','Z');
    System.Console.Write(harf);
}

*/


#region Sayı sıralama algo

/*

int enkucuk=999;
int enbuyuk=0;

for(int i=1; i<=10; i++){


System.Console.WriteLine("{0}.sayı giriniz..",i);
int sayi=int.Parse(Console.ReadLine());

if(sayi<=enkucuk){
    enkucuk=sayi;
    
}

if (sayi>=enbuyuk){
    enbuyuk=sayi;
    
}
}
System.Console.WriteLine( "en büyük sayi: "+enbuyuk);
System.Console.WriteLine("en küçük sayı:"+enkucuk);

*/
#endregion

#region dik üçgen 
/*
  for (int i = 0; i <= 10; i++)
        {
            
            for (int j = 1; j <= i; j++)
            {
                Console.Write("*");
            }
            
            Console.WriteLine();
        }
*/
            //ters dik üçgen
        // for(int i = 0; i < 10; i++)
        // {
        //     for(int j=10;j>i;j--){
        //         System.Console.Write("*");
        //     }
        //     System.Console.WriteLine();
        // }
#endregion
 #region  random sayıyı bulma oyunu
/*
Random rnd=new Random();
 int randomSayi=rnd.Next(1,100);
bool isOk=false;
for(int i=1;i<=10;i++){

    System.Console.WriteLine("sayı giriniz..");

    int sayi=int.Parse(Console.ReadLine());

      if (sayi < randomSayi) {
        System.Console.WriteLine("Yukarı");
    } 
    if (sayi > randomSayi) {
        System.Console.WriteLine("Aşağı");
    } 
     if (sayi==randomSayi){
        isOk=true;
        System.Console.WriteLine("Kazandınız");
        i=10;
    }

    
}
if(isOk=false){

System.Console.WriteLine("kaybettiniz..");

 }      

*/
#endregion




#region kullanıcıdan 10 adet not al ve ortalamalarını yazdır
/*
int toplam=0;

 for(int i=0;i<10;i++){
    System.Console.WriteLine("{0}.notu giriniz:",i+1);
    int not=int.Parse(Console.ReadLine());
    toplam+=not;
 }

System.Console.WriteLine("Notların ortalaması: " + toplam/10);

*/
#endregion


#region kelimenin tersini yazdırma!! (substring ve döngü)


System.Console.WriteLine("metin giriniz");

string metin=Console.ReadLine();

string ters="";

for(int i=metin.Length;i>0;i--){

ters+=metin.Substring(i-1,1);

}
System.Console.WriteLine(ters);

#endregion