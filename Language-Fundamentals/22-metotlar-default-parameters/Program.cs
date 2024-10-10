
TestMethod();
Method1();
Method2(1);

Cevre(3);
//  parametre olarak almıs oldugu a degiskenin degerini default olarak belirledik.
//  metot cagirilirken a degiskenine deger verilirse, o deger gelecektir.
// metot cagırılırken deger verilmezse parametre olarak , default deger ile çalışıcaktır.



static void TestMethod(int a=10){

    System.Console.WriteLine(a);


}

static void Method1( string value="Metot cagırılırken parametre girilmediyse default deger çalışır."){

    System.Console.WriteLine(value);
}

static void Method2(int a,int b =100){
    System.Console.WriteLine(a);
    System.Console.WriteLine(b);
}


static void Cevre(int yariCap, double pi=3.14){
    System.Console.WriteLine(2*pi*yariCap);
}
