
//parametre alan ve geriye deger döndüren bir metot yazalım

// çok katmanlı projelerde metodu hızlıca görüntülemek için go to definition kullanabilirsin.

System.Console.WriteLine(ReverseString("wissen besiktas"));
string ters=ReverseString("metin");
System.Console.WriteLine(ters);
// metot yazıldıgında bellekte yer kaplamaz , ancak metot çağırıldığında bellekte bir miktar alan işgal eder.
//içerisinde kullanılan degiskenlere bağlı olarak alan isgal eder.

System.Console.WriteLine(Sum(3,4));
System.Console.WriteLine(CircleArea(2));
System.Console.WriteLine(RandomNum(1,49));
System.Console.WriteLine(PlaceValuePı(1));
System.Console.WriteLine(CharToInt('A'));
System.Console.WriteLine( HowManyDays(2020));

System.Console.WriteLine(Login("root","0101"));

static string ReverseString(string deger){

    //parametre olarak aldıgı degeri ters çevirip geri donduren bir metot yazalım.
    string ters="";
    for (int i = deger.Length - 1; i >= 0 ; i--)
    {
        ters+=deger[i];
    }
// geriye deger donduren metotlarda return ifadesi kullanılır..
    return ters;

}

static int Sum(int sayi1, int sayi2){

    int toplam=sayi1+sayi2;

    return toplam;
}

static double CircleArea(int yaricap){

    double sonuc=Math.PI*Math.Pow(yaricap,2);

    return sonuc;
}

static int RandomNum(int sayi1, int sayi2){

    Random rnd=new Random();
   
   int rndSayi=rnd.Next(sayi1,sayi2);

   return rndSayi;
}



static string PlaceValuePı(int index){

return Math.PI.ToString().Substring(index,1);


}

static int CharToInt(char karakter){

    int sayi=(int)karakter;

    return sayi;
}

static int HowManyDays(int yil){

    DateTime baslangic=new DateTime(yil,1,1);
    DateTime bugun= DateTime.Now;

    TimeSpan fark= bugun- baslangic;

    return (int)fark.TotalDays; // sadece gün sayısını aldım.
    
}


static bool Login(string userName, string password){

bool isOk=false;

 if(userName=="root" && password=="0101"){

    System.Console.WriteLine("Welcome...{0}",userName);
    
    isOk=true;
 }
 else{
    System.Console.WriteLine("Login failed..");
 }

 
 return isOk;

}