# Değer Tip ve Referans Tip Kavramı
- Dot net içerisinde bazı tipler değer tipli, bazıları ise referans tiplidir.
- Değer Tip ve referans tipli değişkenler bellekte duruş şekli olarak bibirlerinden farklıdırlar.

- Değer tipli değişkenler belleğin STACK bölgesinde yer alırlar.
- Referans tipli değişkenler ise belleğin HEAP bölgesinde yer alırlar.

- Değer tip kopyalanır, referans tiplerin adresine işaret eden pointerlar kopyalanır.
- pointer stack bölgesinden heap bölgesindeki referans tipin adresini işaret eder.

- Genelde referans tipler ağır veriler içerir. Değer tipler ise daha hafif veriler içerdiğinden dolayı bu şekilde bir ayrım vardır.
- Daha ağır veri taşıyacak tipler kopyalanmaz sadece pointer
- hafif tipler direkt kopyalanır.

- Değer tip: struct
- Referans tip: class
