
#region  ref
// ref keyfordü deger tipli degiskenleri referans tipli gibi davranmasını sağlar.

using System.Collections;
/*
int a=10;
System.Console.WriteLine(a);

Degistir(ref a);
System.Console.WriteLine(a);

static void Degistir( ref int degisken){

    degisken=11;
}
*/
// Referansta tipte ref kullanılmaz genelde fakat istisna var. Bazı referans tiplilerde kullanılıyor.
// Array.Resize()
#endregion
#region out keyword

// bir metot içerisinden değer çıkartabilmek için kullanılan bir yöntem.
// degeri olmayan bir degiskene metot içinde deger verilecekse out ile deger atanabilir.
// out kullanılırken degiskene baslangic degeri verilmez.deger metot çalıstıktan sonra degiskene gider.

//out ref'e benzer bir davranıs sergiler.
//aralarındaki fark: ref baslangıc degeri olan degiskenlerle out ise baslangıc degeri olmayan degiskenlerle kullanılır.
//
int a;
DegerAta(out a);
System.Console.WriteLine(a);

//.net içinde out kullanan metot var mı? int.TryParse("deger", out degisken);

#region int.TryParse()
int b;
bool isOk=int.TryParse("10",out b);
// bir stringi inte cevirip cevirmeyecegini kontrol eder. eger cevirirse
//out ile yukarıdaki baslangıc degeri olmayan b degerine, donusturulmus degeri atayacaktır.
//dönüştüremezse false döner.
System.Console.WriteLine(isOk);
System.Console.WriteLine(b);
#endregion

static void DegerAta(out int a){

    //out ile gelen a degiskenine metot icindeki baslangic degeri verildi.
    a=10;
}


#endregion



static bool IsNum(char karakter){
    
    return char.IsDigit(karakter);
}


static bool MyTryParse(string value, out int result){
   
   
    bool isOk=false;
     result=0;
     string num="";

 for(int i=0;i<value.Length;i++){

    if(IsNum(value[i])){

        isOk=true;
        num+=value[i];
        result=Convert.ToInt32(num);
    }

 }

return isOk;

}

int s;
Console.WriteLine(MyTryParse("20",out s));
System.Console.WriteLine(s);