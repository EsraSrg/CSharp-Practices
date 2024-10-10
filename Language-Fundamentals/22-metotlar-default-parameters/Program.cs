
TestMethod();

//  parametre olarak almıs oldugu a degiskenin degerini default olarak belirledik.
//  metot cagirilirken a degiskenine deger verilirse, o deger gelecektir.
// metot cagırılırken deger verilmezse parametre olarak , default deger ile çalışıcaktır.



static void TestMethod(int a=10){

    System.Console.WriteLine(a);


}