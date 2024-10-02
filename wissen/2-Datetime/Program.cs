// See https://aka.ms/new-console-template for more information

string nowDate=DateTime.Now.ToString();
System.Console.WriteLine( nowDate);


string newString = DateTime.Now.ToLongDateString();
System.Console.WriteLine(   newString);

// System.Console.WriteLine("to long time string:"+DateTime.Now.ToLongTimeString());

System.Console.WriteLine("15 Yıl ekleme yaptım"+DateTime.Now.AddYears(15));
System.Console.WriteLine("10 Gün ekleme yaptım"+DateTime.Now.AddDays(10));

DateTime date= new DateTime(2000,12,1);
System.Console.WriteLine(   "Custom tarih ayarlayalım: "+date.ToLongDateString());
System.Console.WriteLine(  "sadece gün degerini alalım: "+ date.Day);

//iki tarihi birbirinden çıkartalım

DateTime firstDate= new DateTime(1923,10,29);
DateTime now =DateTime.Now;

//TimeSpan ile iki tarihi birbirinden çıkarıp farkını alabiliriz.

// TimeSpan fark=now-firstDate;
// System.Console.WriteLine("gün farkı: "+fark.TotalDays);
// System.Console.WriteLine("saat farkı:"+fark.TotalHours);





//ekrandan ay yıl gün bilgisi al , bu bilgilerle datetime tanımla,bugünden timespanle çıkart,ekrana kaç gün kaç dkdir yaşadigini yazdır.,

#region  ÖRNEK
// System.Console.WriteLine("Doğum yılınızı giriniz..");
// int year=int.Parse(Console.ReadLine());
// System.Console.WriteLine("Doğum ayınızı giriniz..");
// int month=int.Parse(Console.ReadLine());
// System.Console.WriteLine("Doğum gününüzü giriniz..");
// int day=int.Parse(Console.ReadLine());

// DateTime birthDate=new DateTime(year,month,day);

// TimeSpan fark =DateTime.Now-birthDate;
// System.Console.WriteLine( "{0} yıldır {1} gündür {2} saatir hayattasın",fark.TotalDays/365,fark.TotalDays,fark.TotalHours);

#endregion

#region ÖRNEK version 2              

// Console.WriteLine("Doğum tarihinizi girin...(örnek: gün.ay.yıl 23.04.2002)");
// string birthDateString=Console.ReadLine();

// int day=Convert.ToInt32(birthDateString.Substring(0,2));
// int month=Convert.ToInt32(birthDateString.Substring(3,2));
// int year=Convert.ToInt32(birthDateString.Substring(6,4));

// DateTime birthDate= new DateTime(year,month,day);

// TimeSpan fark= DateTime.Now-birthDate;
// System.Console.WriteLine("{0} yıldır dünyadasınız..",fark.TotalDays/365);

#endregion

//türkiyede çalışan iki programın entegrasyonu
//iki farklı ülkede çalışan entegrasyon

System.Console.WriteLine((DateTime.UtcNow.ToString())); //evrensel saat. UTC tüm ülkelerde geçerli saat farkı olmaksızın aynı degeri alabilmek için kullanılır.

