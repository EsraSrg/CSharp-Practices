
//parametre alan ve geriye deger döndüren bir metot yazalım


System.Console.WriteLine(TersCevir("wissen besiktas"));

static string TersCevir(string deger){

    //parametre olarak aldıgı degeri ters çevirip geri donduren bir metot yazalım.
    string ters="";
    for (int i = deger.Length - 1; i >= 0 ; i--)
    {
        ters+=deger[i];
    }

    return ters;

}
