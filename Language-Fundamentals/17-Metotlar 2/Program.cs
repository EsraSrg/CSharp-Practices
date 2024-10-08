// c#da bir metot başka bir metodu çağırabilir. 


using System.Collections;


string text="Bugün Hava çok G ü zel..";
FindSpaces(text);
CountUpper(text);
SeslileriBul(text);

#region Örnek : Bir metot içerisinden başka bir metodu çağırmak
/*DersleriGetir("2.Sınıf");

static ArrayList Hazirla(string ders)
{
    SortedList dersler = new SortedList();
    dersler.Add("1.Sınıf", new ArrayList() { "Türkçe", "Matematik" });
    dersler.Add("2.Sınıf", new ArrayList() { "Türkçe", "Matematik", "Fizik" });
    dersler.Add("3.Sınıf", new ArrayList() { "Türkçe", "Matematik", "Beden" });
    dersler.Add("9.Sınıf", new ArrayList() { "Türkçe", "Matematik", "Tarih" });

    ArrayList liste = (ArrayList)dersler[ders];
    return liste;
}
static void DersleriGetir(string ders)
{
    // bu metot hazirla metodunu çağırıyor, Hazirla metodu, geriye arraylist dönen bir metot,
    // aynı zamanda DersleriGetir metoduna gelen string parametreyi, Hazirla metoduna gönderdik
    ArrayList liste = Hazirla(ders);
    foreach (string s in liste){

        Console.WriteLine(s);
    }
}
*/

#endregion

#region Bir strig  içerisinde kaç tane rakam olduğunu bize söyleyen uygulama
/*
RakamlariBul("bu örn2ekte, 3 üç tane r4k4m v4r");
static bool Rakammi(char value){

    return char.IsDigit(value);
}

static void RakamlariBul(string value){

    int rakamToplam = 0;
    for(int i =0;i<value.Length;i++){

        // başka bir metodu çağırdık!!!
        bool rakammi = Rakammi(value[i]);
        if(rakammi){
            rakamToplam++;
        }

    }
    Console.WriteLine("Girmiş olduğunuz metinde, {0} adet rakam vardır" ,rakamToplam);
}

*/
#endregion

#region bosluk sayısı
static bool IsSpace(char value){

    return char.IsWhiteSpace(value);
}

static void FindSpaces(string value){

    int spaceTotal=0;
    for(int i=0;i<value.Length;i++){


        bool isOk=IsSpace(value[i]);

        if(isOk){
            spaceTotal++;
        }

    }
    System.Console.WriteLine("there's {0} space in the text",spaceTotal);
}
#endregion

#region Büyük harf sayısı

static bool isUpper(char value){

    return char.IsUpper(value);
}

static void CountUpper(string value){

    int total=0;

    foreach(char item in value){

        if(isUpper(item)){
            total++;
        }
    }
    System.Console.WriteLine("{0} upper case letters.",total);
}

#endregion

#region sesli harf sayısı

static bool SesliMi(char harf){
  bool isOk=false;
    char [] harfler={'a','e','ı','i','o','u','ü','A','E','I','O','U','Ü'};
   for(int i=0;i<harfler.Length-1;i++){

   
   if(harf==harfler[i]){
    isOk=true;
   }
   }
    return isOk;

}

static void SeslileriBul(string value){

int toplam=0;

for(int i=0;i<value.Length;i++){

    bool sesliMi=SesliMi(value[i]);
    if(sesliMi){
        toplam++;
    }
}
System.Console.WriteLine("{0} adet sesli harf var.",toplam);
}

#endregion 

