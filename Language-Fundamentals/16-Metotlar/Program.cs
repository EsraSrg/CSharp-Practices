
using System.Collections;
using System.Globalization;
/*
//parametre alan ve geriye deger döndüren bir metot yazalım

// çok katmanlı projelerde metodu hızlıca görüntülemek için go to definition kullanabilirsin.

System.Console.WriteLine(ReverseString("wissen besiktas"));
string ters = ReverseString("metin");
System.Console.WriteLine(ters);
// metot yazıldıgında bellekte yer kaplamaz , ancak metot çağırıldığında bellekte bir miktar alan işgal eder.
//içerisinde kullanılan degiskenlere bağlı olarak alan isgal eder.

System.Console.WriteLine(Sum(3, 4));
System.Console.WriteLine(CircleArea(2));
System.Console.WriteLine(RandomNum(1, 49));
System.Console.WriteLine(PlaceValuePı(1));
System.Console.WriteLine(CharToInt('A'));
System.Console.WriteLine(HowManyDays(2020));

System.Console.WriteLine(Login("root", "0101"));

static string ReverseString(string deger)
{

    //parametre olarak aldıgı degeri ters çevirip geri donduren bir metot yazalım.
    string ters = "";
    for (int i = deger.Length - 1; i >= 0; i--)
    {
        ters += deger[i];
    }
    // geriye deger donduren metotlarda return ifadesi kullanılır..
    return ters;

}

static int Sum(int sayi1, int sayi2)
{

    int toplam = sayi1 + sayi2;

    return toplam;
}

static double CircleArea(int yaricap)
{

    double sonuc = Math.PI * Math.Pow(yaricap, 2);

    return sonuc;
}

static int RandomNum(int sayi1, int sayi2)
{

    Random rnd = new Random();

    int rndSayi = rnd.Next(sayi1, sayi2);

    return rndSayi;
}



static string PlaceValuePı(int index)
{

    return Math.PI.ToString().Substring(index, 1);


}

static int CharToInt(char karakter)
{

    int sayi = (int)karakter;

    return sayi;
}

static int HowManyDays(int yil)
{

    DateTime baslangic = new DateTime(yil, 1, 1);
    DateTime bugun = DateTime.Now;

    TimeSpan fark = bugun - baslangic;

    return (int)fark.TotalDays; // sadece gün sayısını aldım.

}


static bool Login(string userName, string password)
{

    bool isOk = false;

    if (userName == "root" && password == "0101")
    {

        System.Console.WriteLine("Welcome...{0}", userName);

        isOk = true;
    }
    else
    {
        System.Console.WriteLine("Login failed..");
        isOk = false;
    }


    return isOk;
    //  //v2
    //  return userName=="root" && password=="0101";

}
// System.Console.WriteLine("username:");
// string userName=Console.ReadLine();

// System.Console.WriteLine("password:");
// string password=Console.ReadLine(); 

// Login(userName,password);

// bir metoda, array parametre alabilirsin
// aynı şekilde dizi de geri dönebilirsin
static string[] UpperFirstCase(ArrayList liste)
{

    // string dizisi alıp, bu dizinin içerisindeki değerlerin
    // baş harflerini büyük yapıp, metotdan geriye dönelim
    string[] resultArray = new string[liste.Count];
    int i = 0;
    foreach (string s in liste)
    {

        string value = s.ToString();
        string firstCase = value.Substring(0, 1);
        string lastCases = value.Substring(1, value.Length - 1);
        resultArray[i] = firstCase.ToUpper() + lastCases;
        i++;

    }
    return resultArray;



}

var arrayList = new ArrayList();
arrayList.Add("wissen");
arrayList.Add("besiktaş");
arrayList.Add("istanbul");
foreach (string item in UpperFirstCase(arrayList))
{

    Console.WriteLine(item);
}



// Örnek 10 : 
// kendi baş harf büyük metodumuzu yazalım
// parametre olarak bir string alan ve girmiş olduğumuz string'ini baş harfini büyüten bir metot yazınız

static void HarfiBuyut(string value)
{

    string ters = value[0].ToString().ToUpper();
    for (int i = 1; i < value.Length; i++)
    {
        ters += value[i].ToString();
    }

    Console.WriteLine(ters);
}



static void mySubstring(string value, int Startİndex, int length)
{


    string text = "";

    for (int i = Startİndex; i < Startİndex + length; i++)
    {

        text += value[i];
    }

    Console.WriteLine(text);

}
Console.WriteLine("enter text:");
string text = Console.ReadLine();
System.Console.WriteLine("start index:");
int start = int.Parse(Console.ReadLine());
System.Console.WriteLine("length:");
int lngth = int.Parse(Console.ReadLine());
mySubstring(text, start, lngth);

// tek çift kontrolü yapsin

static void TekMi(int sayi)
{
    bool tekmi = false;
    if (sayi % 2 == 0)
    {
        System.Console.WriteLine("sayı çift");
        tekmi = false;
    }
    else if (sayi % 2 == 1)
    {
        Console.WriteLine("sayı tek");
        tekmi = true;
    }

    Console.WriteLine(tekmi);


}

/*
System.Console.WriteLine("sayi girin:");
int sayi=int.Parse(Console.ReadLine());
TekMi(sayi);

*/
/*
// dizi sıralama örnegi
//8 4 6 7 1 2
static void mySort(int[] array)
{



    for (int i = 0; i < array.Length - 1; i++)
    {
        for (int j = 0; j < array.Length - i - 1; j++)
        {
            if (array[j] > array[j + 1])
            {

                int yer = array[j];
                array[j] = array[j + 1];
                array[j + 1] = yer;
            }
        }
    }


    Console.WriteLine("Sorted Array:");
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + "-");
    }


}



int[] newArray = { 8, 4, 6, 7, 1, 2 };
mySort(newArray);



// username kontrolü
static void PasswordGenerator(ArrayList userList)
{

    Random rnd = new Random();

    for (int i = 0; i < userList.Count; i++)
    {

        int num = rnd.Next(1, 300);
        char karakter = (char)rnd.Next(0, 200);
        System.Console.WriteLine(" şifreniz:" + userList[i] + num + karakter);
    }

}

ArrayList arraylist = new ArrayList();
arraylist.Add("Admin");
arraylist.Add("Deniz");
PasswordGenerator(arraylist);


static void UserLogin(SortedList liste, string username, string password)
{

    foreach (DictionaryEntry item in liste)
    { //sortedlist key value çifti oldugundan DictionaryEntry ile dönülür.

        if (item.Key.ToString() == username && item.Value.ToString() == password)
        {
            Console.WriteLine("giriş basarili");
            break;
        }
        else
        {
            Console.WriteLine("giris basarisiz..");
        }

    }
}


SortedList liste = new SortedList();
liste.Add("wissen", "1818");
liste.Add("root", "1010");
liste.Add("esra", "1618");
UserLogin(liste, "esra", "1618");

static void KelimeSay(string cumle)
{

    // bu işi bir metot ile yapalım
    var kelimeDizi = cumle.Split(' ');
    Console.WriteLine("Kelime sayısı : {0}", kelimeDizi.Length);
}
//Örnek :  Tekrar eden harfleri gösteren uygulama



static void CountLetters(string text)
{

    SortedList list = new SortedList();
    for (int i = 0; i < text.Length; i++)
    {

        string letter = text[i].ToString();
        if (list.ContainsKey(letter)) //harf var mı koleksiyonun içinde?
        {

           
// key degerine göre value getirmemiz lazım
            int value = (int)list[letter];
            value++;
            list[letter] = value;

        }
        else
        {
            list.Add(letter.ToString(), 1);
        }
    }

    foreach (DictionaryEntry item in list)
    {
        Console.WriteLine("{0} > {1}", item.Key, item.Value);

    }

}


CountLetters("ccccsshhharpppp");

*/

//Find the Factorial of a Number 
//Rsum of array(Arrays)
//Power of Two (Math)


Factorial(3);
Console.WriteLine(PowerOfTwo(254));


SortedList list = new SortedList();
list.Add(1, 3);
list.Add(2, 4);
list.Add(3, 3);
list.Add(4, 1);
list.Add(5, 2);

Console.WriteLine(SumOfSortedList(list));




static void Factorial(int num)
{

    int number = 1;
    for (int i = 1; i <= num; i++)
    {

        number *= i;

    }

    System.Console.WriteLine("{0}!={1}", num, number);
}

// is num equals 2^i 

static bool PowerOfTwo(int num)
{

    bool isOk = false;

    for (int i = 1; i <= num; i++)
    {

        if (num == (int)Math.Pow(2, i))
        {

            isOk = true;
        }

        if (num < (int)Math.Pow(2, i))
        {
            break;
        }

    }

    return isOk;
}


static int SumOfSortedList(SortedList list){

 int sum=0;

foreach (DictionaryEntry item in list)
{

    sum += (int)item.Value;

}
return sum;

 }

//sortedlist içine Arraylist ekleme
