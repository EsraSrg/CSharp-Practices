
// metotun aldıgı parametreleri params keyword'u ile sınırsız hale getirmek mümkündür.


UnlimitedParameters(10,20,30,80,1,3,4,55,67,765,443,33);

static void UnlimitedParameters(params int[] parameters){

   

   //params ile sınırsız parametreli bir metot yazabilirsiniz.
   //params ile gelen parametreler dizi üzerinden yakalanabilir.
   // Örnek:ortalamalarını alalım parametrelerin..
    int toplam=0;
   foreach (int item in parameters){

    toplam+=item;
   }
   System.Console.WriteLine("toplam:{0} ortalama:{1}",toplam,toplam/parameters.Length);

}