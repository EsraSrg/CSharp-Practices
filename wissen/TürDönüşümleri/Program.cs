// See https://aka.ms/new-console-template for more information
#region  mathFonksiyonları
//   double number = -10.7;
//   double aci=90;     
//         // Mutlak değer
//         double absDeger = Math.Abs(number);
//         Console.WriteLine("Mutlak Değer: " + absDeger);

//         // Karekök hesaplama
//         double sqrtDeger = Math.Sqrt(16);
//         Console.WriteLine("Karekök: " + sqrtDeger);

//         // Üs alma
//         double powDeger = Math.Pow(2, 5);
//         Console.WriteLine("2 üzeri 5: " + powDeger);
//             // Sinüs hesaplama
//         double sinDeger = Math.Sin(aci);
//         Console.WriteLine("Sin(90°): " + sinDeger);


#endregion




#region boolToInt  // bool tipi int tipine çevirilebilir. true 1 false 0 olur.

// bool boolDegisken  =false;

// int intDegisken = Convert.ToInt32(boolDegisken);
// System.Console.WriteLine(   intDegisken);

#endregion

#region  intToBool // int , bool'a çevrilebilir.

// int intDegisken=1;
// bool boolDegisken=Convert.ToBoolean(intDegisken);
// System.Console.WriteLine(   boolDegisken);
#endregion

#region charToInt // char,int'e çevrilir.her harfin rakam karşılığı çıktısını verir. // A ve a fark 32.küçük büyük karakterler arası fsrk 32.
// char  charDegisken='a';
// int intDegisken=Convert.ToInt32(charDegisken);
// System.Console.WriteLine(   intDegisken);
#endregion

#region intToChar // int char'a çevrildi. 0-255 arası farklı karakterlere dönüşür.
// int intDegisken =33;
// char charDegisken=Convert.ToChar(intDegisken);
// System.Console.WriteLine(   charDegisken);
#endregion
#region  Parse: string tipi verleri diger tiplere çevirir. !!sadece string alır
// string metin="a";
// char charDegisken=char.Parse(metin);
// System.Console.WriteLine(   charDegisken);

#endregion


//  Console.Write("Birinci sayıyı girin: ");
        
//         int sayi1 = int.Parse(Console.ReadLine());  

    
//  Console.Write("İkinci sayıyı girin: ");
       
//         int sayi2= int.Parse(Console.ReadLine());  


//         int topla = sayi1 + sayi2;
//         int cikar = sayi1- sayi2;   
//         int carp = sayi1 * sayi2;    
//         double bol = sayi1/ sayi2;

//         Console.WriteLine("Toplama:{0} Çıkarma:{1} Çarpma:{2} Bölme:{3} ",topla,cikar,carp, bol); 




#region RandomSayi

    //Random sayı oluşturma;
    //     Random rnd=new Random();
    //     int intRandom=rnd.Next();
    //  System.Console.WriteLine(   intRandom);

    //   Random rnd=new Random();
    //   double randomDouble=rnd.NextDouble();
    //   System.Console.WriteLine( randomDouble);
      #endregion

#region toString

//Parse'ın tersi olarak çalışır.
// //diğer tiplerden string tipine dönüşüm sağlar.
// int intDegisken=30;
// string stringDegisken=intDegisken.ToString();
// System.Console.WriteLine(   stringDegisken);

// // WriteLine metodu arkada toString çağırır.e

#endregion

/* Random rnd=new Random();
 int intRandom=rnd.Next(1,10);

 bool sonuc =intRandom%2!=0;

 System.Console.WriteLine( "{0} sayısı tektir:{1}",intRandom,sonuc);
*/




  
        char küçükHarf = 'a';

        // charı inte çevirdim
        int intDegisken = Convert.ToInt32(küçükHarf);

        
        int farkİslemi = intDegisken - 32;

        
        char büyükHarf = Convert.ToChar(farkİslemi);

        //stringe dönüşüm
        string sonuçString = Convert.ToString(büyükHarf);

        
        
        Console.WriteLine("Büyük harf: " + büyükHarf);
        Console.WriteLine("{0}-32={1} ",intDegisken, farkİslemi);
        