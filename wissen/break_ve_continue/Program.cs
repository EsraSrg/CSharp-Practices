
// for(int i=1;i<100;i++){

//     if(i%3==0){
//         Console.WriteLine("{0} sayısı 3 e tam bölünür",i);
//         break;
//     }
// }

// for(int i=1;i<100;i++){

//     if(i==10){
//         continue;

//     }
//     Console.WriteLine(i);
// }

Random rnd=new Random();
int tutuLanSayi=rnd.Next(1,10);

for(int i=1; i<=tutuLanSayi;i++){

    Console.WriteLine("sayı giriniz:");
 int sayi=int.Parse(Console.ReadLine());

    if(sayi<tutuLanSayi){
        System.Console.WriteLine("yukarı");
        
    }
    if(sayi>tutuLanSayi){
        System.Console.WriteLine("aşagı");
        
    }
    if(sayi==tutuLanSayi){
        System.Console.WriteLine("kazandiniz..");
        break;
    }
}