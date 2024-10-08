int a=10;  // Deger tip

System.Console.WriteLine(a);

IntDegistir(a);
System.Console.WriteLine(a);


string [] isimler={"Esra","Ayse","Selin","Mustafa"};  // Referans tip

System.Console.WriteLine(isimler[0]);

DiziDegistir(isimler);
System.Console.WriteLine(isimler[0]);




static void IntDegistir(int degisken){

    degisken=11;
}

static void DiziDegistir(string [] dizi){

    dizi[0]="Degistirilmistir";
}