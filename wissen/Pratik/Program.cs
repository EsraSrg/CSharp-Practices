

// for (int i=0;i<=10;i++){


//     Console.WriteLine();
//     for(int j=0;j<=i-2;j++){

//         if(i==0 && j==0){

//             Console.Write("X");
//             i++;
//             Console.WriteLine();
//         }
//         if((i==10 &&j==0) || (i==10 && j==8)){
            
//             Console.Write("X");
//             j++;
//             //Console.WriteLine();
           
//         }
//         Console.Write("*");
        
//     }
// }

// Ekrana eş kenar üçgen çiziniz

/*
    *
   ***
  *****
 ********
**********  

*/

// using System.Globalization;

// Console.WriteLine("Bir değer giriniz");
// int deger =int.Parse(Console.ReadLine());

// for (int i = 0;i<deger;i++){

//     // satırları oluşturur

//     // 
//     for(int j=0;j<deger-i;j++){

//         // Boşlukları basalım
//         Console.Write(" ");
//     }

//     for(int k=0;k<=2*i;k++){
//         Console.Write("*");
//     }
//     Console.WriteLine();

// }
// bu örneği iyice bir inceleyip, bu örnek ile ilgili bazı değişiklikler yaparak derse geliniz.




Console.WriteLine("Bir değer giriniz:");
int deger = int.Parse(Console.ReadLine());

for (int i = 0; i < deger; i++)
{
    // Boşlukları yazdır
    for (int j = 0; j < deger - i - 1; j++)
    {
        Console.Write(" ");
    }

    // Sol kenar
    Console.Write("/");

    // Yıldızları yazdır
    for (int k = 0; k < 2 * i; k++)
    {
        Console.Write("*");
    }

    // Sağ kenar
    Console.WriteLine("\\");
}

// Alt kısmı çizgi ile kapat
Console.Write(" ");
for (int l = 0; l < 2 * deger - 1; l++)
{
    Console.Write("-");
}
Console.WriteLine();
