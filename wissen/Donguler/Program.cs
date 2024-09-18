// Döngü çeşitleri
//for döngüsü
// foreach döngüsü
// do while

//dönen döngüyü durdurmak için
//1-kaçiş keywordleri kullanilabilir(break,continue,return)
//2-mevcur koşulu bozarak döngüden çıkılabilir.

//Sonsuz Döngü,
/*
int a=10;
for(;;){
    a++;
    System.Console.WriteLine(a);
}
*/
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
/*
using System.Globalization;

for (int i=1;i<=10;i++){

    for(int j=1;j<=10;j++){

        System.Console.WriteLine("{0}x{1}={2}",i,j,i*j);
        }
        System.Console.WriteLine("----------------------------");

*/

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


Random rnd=new Random();

for(int i=0;i<=10;i++){
    // int a=rnd.Next(65,90);
   
    // char harf=Convert.ToChar(a);
   char harf=(char)rnd.Next('A','Z');
    System.Console.Write(harf);
}
