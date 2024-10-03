# Metotlar

Metotlar, iş yapan küçük program parçalarıdır. İçlerine aldıkları değerler ve size geriye döndürdükleri değerler ile birlikte çalışır.


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

- **Public** : her katmandan erisilebilir.
- **Private** : sadece kendi katmanından erisilebilir, diger tüm yerlere erisimi kapalıdır.
- **Protected** : kalıtım hiyerarsisi olan katmanlardan erisilebilir, diger katmanlara kapalıdır.
- **Protected Internal** : ya kalıtım hiyerarsisi ya da dış bir paket tarafından erisilebilir.
- **Internal** : sadece dış bir paket tarafından erisilebilir.


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

- Metot yazarken, satır sayısına dikkat edilmelidir. Bu bir yazılım görgü kuralıdır; 30-40 satır kodu geçmemelidir.
- Aynı şekilde metot parametrelerinde de bir genel geçer kural vardır. Metot parametre sayısı 4'ü geçerse buraya bir önlem alınması gerektiğini söyler.

## Metotların Faydaları

- Kod tekrarı önleniyor.Buna bağlı olarak hatalar önleniyor.
- Bakım kolaylığı sağlanır. Bir feature ekleneceğinde degisiklik kolayca yapılır.
- Çok tekrar edilen kod bloklarını metot haline getirmeliyiz.
