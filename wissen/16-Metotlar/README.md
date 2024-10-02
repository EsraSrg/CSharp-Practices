# Metotlar

Metotlar, iş yapan küçük program parçalarıdır. İçlerine aldıkları değerler ve size geriye döndürdükleri değerler ile birlikte çalışır.

## Gerçek Hayat ve Yazılım Problemleri

Gerçek hayatta problemler ile karşılaştığımızda, onları çözüm yoluna gideriz. Genelde büyük problemler karşımıza çıktığında, büyük bir problem ile uğraşmak oldukça zordur. 

Bu tarz durumlarda, küçük bir problemi küçük parçalar haline bölüp çözmeye çalışmak önerilir. Yazılım tarafındaki büyük boyuttaki işler gerçek hayattaki probleme benzer. Eğer bu tip işleri o boyutuyla çözmeye çalışırsak, genelde çok karmaşık çözümlerle karşılaşırız.

Problemi ufak parçalara ayırmak yazılım dünyasında, metotlara denk gelir. Metotlar, yukarıda da belirttiğimiz gibi ufak kod parçacıklarıdır. Her bir problem çözümünü ufak metotlara ayırarak, problem çözüm süreci boyunca başarılı olunur.

## Metot Türleri

1. **Parametre alan metotlar:** Bir veya daha fazla parametre alabilir.
2. **Geriye değer döndüren metotlar:** Çalıştıktan sonra bir değer üretiyor ve onu döndürüyor.
3. **Parametre almayan metotlar:** Dışarıdan parametre almadan kendi işini kendi yapan metotlardır.
4. **Geriye değer döndürmeyen metotlar:** Çalıştıktan sonra geriye bir değer döndürmeyen metotlardır.

## Metot Syntax

erişim belirteci + static/yada static olmama + geri dönüş tipi/yada değer dönmeyecekse void + Metot Adı(Metot Parametreleri) { // Metot Gövdesi }


### Erişim Belirteçleri

Bir metodun hangi katmandan ya da nereden erişilebileceğini belirler. Erişim belirteçleri şunlardır:

- **Public**
- **Private**
- **Protected**
- **Protected Internal**
- **Internal**

Yukarıdaki erişim belirteçlerden şimdilik sadece `public` olanı kullanacağız; diğerlerine daha sonra değineceğiz.

### Static veya Static Olmama

Metotlar için en önemli kavramlardan biridir. Bu belirteçten şimdilik sadece `static` olanı kullanacağız. Static olmama durumu daha sonra açıklanacaktır.

### Geri Dönüş Tipi

Bir metottan geriye .NET içerisindeki tüm değişken tipleri dönebilir. Ancak metot geriye değer döndürmüyorsa, `void` olarak işaretlenmelidir.

### Metot Adı

Metot adı, metodun yapacağı işle ilgili olmalıdır. (Tek harf metot olmamalıdır.)

#### Metot İsimlendirme Kuralları

- Metot adı tek harf olmamalıdır.
- Metot adından önce rakam veya karakter kullanılmamalıdır.
- Metot adı metodun yapacağı işle ilgili olmalıdır.
- Metot adı çok uzun olmamalıdır.
- Metotlar isimlendirilirken Pascal Casing kullanılmalıdır. Örnek: `WissenMetot` yani metot isminin baş harfi büyük, sonraki harfler küçük olmalıdır.
- Eğer metot adı iki kelime ise, her kelimenin baş harfi büyük, geri kalan harfler küçük olmalıdır.

### Metot Parametreleri

Bir metot 1 veya birden çok parametre alabilir. Parametre sayısının bir sınırı yoktur. Aynı yer gibi, dönüş tipi de .NET içerisindeki tüm değişken tiplerini parametre olarak alabilir.

## Bazı Kurallar

- Metot yazarken, satır sayısına dikkat edilmelidir. Bu bir yazılım görgü kuralıdır; 30-34 satır kodu geçmemelidir.
- Aynı şekilde metot parametrelerinde de bir genel geçer kural vardır. Metot parametre sayısı 4'ü geçerse buraya bir önlem alınması gerektiğini söyler.

