// fazla tercih edilmez , for tercih edilir yerine..

// int donguDegiskeni=0;

// while(donguDegiskeni<100){
//     System.Console.WriteLine(donguDegiskeni);
//     donguDegiskeni++;
// }

/*
int i=1;

while(i<=10){
    int j=1;
    //bu döngü 1 kere döndüğünde

    while(j<=10){
        //bu döngü 10 kere döner
        System.Console.WriteLine("{0}*{1}={2}",i,j,i*j);
       j++;
    }
    System.Console.WriteLine("----------------------------------------------------");
    i++;
}


// dik üçgen

int a=0;

while(a<=6){
    

    int b=0;
    while(b<a){
        Console.Write("*");
        b++;
    }
       a++;

System.Console.WriteLine(" ");
}



int a=1;
int toplam=0;

while(a<=10){
    System.Console.WriteLine("{0}. notu girin",a);
    int not=int.Parse(Console.ReadLine());
    
    toplam+=not;
    a++;
}
System.Console.WriteLine("not ortalamanız:"+toplam/10);

*/

/*
int a=1;
int tekToplam=0;
int ciftToplam=0;

while(a<=10000){

    if(a%2==0){

        ciftToplam+=a;
    }
    else{
        tekToplam+=a;
    }
    a++;
}
System.Console.WriteLine("tek sayı toplamı:{0} çift sayi toplamı:{1}",tekToplam,ciftToplam);
*/

using System.Net;
using System.Runtime.CompilerServices;

Random rnd=new Random();
int tutulanSayi=rnd.Next(1,50);

int i=1;

bool sonuc=false;

 while(i<=15){

    System.Console.WriteLine("{0}.sayı tahmininizi girin:",i);
    int randomSayi=int.Parse(Console.ReadLine());
 
 if(i>=10){
    System.Console.WriteLine("Hakkınız doldu tekrar denemek için bir tuşa basın..");
    Console.ReadLine();
    i=1;
    continue;
 }
    if(tutulanSayi==randomSayi){
        System.Console.WriteLine("Tebrikler, kazandınız!!");
        sonuc=true;
        break;
    }
    else if(tutulanSayi<randomSayi){
        System.Console.WriteLine("aşağı");
    }
    else if(tutulanSayi>randomSayi){
        System.Console.WriteLine( "yukarı");
    }

    i++;
    
 }
 if(!sonuc)
 {System.Console.WriteLine("kaybettiniz..");

 }
 
 