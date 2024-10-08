﻿using System;
using System.Collections;  //namespace cagirmak icin using ifadesi kullanılır..

//NameSpace
// dışarıdan indirilen kütüphsneler oldugu gibi, .net'in kendi içerisinde olan kütüphaneler olabilir.
//namespace aynı isimde olan tipleri birbirinden ayırmak ve içinde tutmak için vardir.. unique olmasını sağlıyor..
// mesela wissen adlı iki sınıf yazacaksın namespace karışmasın diye grupluyor.namespace ile çağırıyorsun karismasin diye
// namespace örnekleri: system , collection , system.data.sql


// stack: LIFO - last in first out çalışan bir koleksiyon.
// birçok koleksiyon object alır..

//tır dorsesi yükleme işlemi örneği, son koyulan ilk çikar.

Stack stack = new Stack();

stack.Push("yük 1" );
stack.Push("yük 2" );
stack.Push("yük 3" );
stack.Push("yük 4" );
stack.Push("yük 5" );
stack.Push("yük 6" );
stack.Push("yük 7" );
stack.Push("yük 8" );
stack.Push("yük 9" );
stack.Push("yük 10" );
stack.Push("yük 11" );
stack.Push("yük 12" );

// peek metodu silinmek üzere bekleyen item'ı döndürür fakat silmez.
string silinecek=stack.Peek().ToString();    
Console.WriteLine(silinecek);  


int donguDegisken=stack.Count; // stack count sabit bir yerde tutulmalı , yoksa dinamik oldugundan koleksiyon küçülüyor.

for(int i=0; i<donguDegisken;i++){
    Console.WriteLine("stack koleksiyonundan eleman cikarmak için enter'a basın");
    Console.ReadLine();
    string silinen=stack.Pop().ToString(); 
    Console.WriteLine("silinen:{0} - Koleksiyon sayısı {1}",silinen,stack.Count);   
}