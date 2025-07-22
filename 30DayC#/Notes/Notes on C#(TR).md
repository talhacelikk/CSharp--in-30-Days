-----

# 30 Days in C#
![C# 30 Günlük Eğitim Serisi](https://img.shields.io/badge/C%23-30Days-blueviolet)

C# dilini öğrenmek isteyenler için 30 günlük bir yolculuk! Her gün temel bir konuyu ele alıp kod örnekleriyle öğreniyoruz.

> Hazırlayan: M.Talha Çelik
> Not: Bu rehber, günlük notları, örnekleri ve açıklamaları içerir. Başlangıç seviyesinden ileri seviyeye kadar kapsar.

-----

## Main Metodu - Programın Giriş Kapısı

C#'ta her program `Main` metodundan başlar. Kodun çalışmaya başladığı yer burasıdır.

```csharp
static void Main(string[] args)
{
    Console.WriteLine("Program başladı!");// Ekrana yazı basar
}
```

- `static`: Program çalışırken nesne yaratmadan çalışması için kullanılır.
- `void`: Geriye değer döndürmediğini belirtir.
- `string[] args`: Komut satırından gelen argümanları alır.

## Veri Tipleri

C# dilinde temel veri tipleri:

| Veri Tipi | Açıklama               |
|-----------|------------------------|
| int       | Tam sayılar            |
| double    | Ondalıklı sayılar      |
| char      | Tek karakter           |
| string    | Metin verileri         |
| bool      | true/false değerleri   |

Dönüştürmek için `Convert.ToInt32()`, `int.Parse()`, `TryParse()` gibi metotlar kullanılır.

------


## 30 Days in C##

Bu rehber, C# dilini sıfırdan öğrenmek isteyenler için hazırlanmış 30 günlük bir gelişim yolculuğudur. Her gün, bir konsepti detaylıca öğrenip örneklerle pekiştirerek ilerleyeceğiz. Günlük ilerleme planı aşağıdaki gibidir:

-----

## Day 0 - Hello World
C# dilinde ilk uygulamayı yazma, `Main` metodu ve `Console.WriteLine()` ile çıktı alma.

## Day 1 - Data Types
Temel veri tipleri (`int`, `double`, `char`, `string`, `bool`) ve `Convert` sınıfı ile dönüşümler.

## Day 2 - Operators
Aritmetik, karşılaştırma ve mantıksal operatörler. İfadelerin nasıl çalıştığını anlamak.

## Day 3 - Intro to Conditional Statements
`if`, `else if`, `else`, `switch` gibi koşullu ifadelerle program akışını kontrol etmek.

## Day 4 - Class vs. Instance
Class nedir, instance nedir? OOP'nin ilk adımı olan nesne yaratmayı öğren.

## Day 5 - Loops
`for`, `while`, `do-while`, `foreach` döngüleri. Döngülerin ne zaman ve nasıl kullanıldığı.

## Day 6 - Let’s Review
Daha önce öğrenilen konuların kısa tekrarı ve mini bir uygulama.

## Day 7 - Arrays
Tek boyutlu ve çok boyutlu diziler. `Length`, `IndexOf`, `Sort` gibi metotlar.

## Day 8 - Dictionaries and Maps
`Dictionary<TKey, TValue>` kullanımı. Anahtar-değer eşlemesi mantığı.

## Day 9 - Recursion
Kendini çağıran metotlar. Faktöriyel ve Fibonacci gibi klasik örneklerle anlatım.

## Day 10 - Binary Numbers
Binary (ikili) sayı sistemine giriş. Bit işlemleri ve sayıları binary olarak yorumlamak.

## Day 11 - 2D Arrays
Matris yapısına giriş. Satır ve sütunlarla veri işleme.

## Day 12 - Inheritance
Kalıtım (inheritance) nedir, neden kullanılır? `: base` kullanımı ve alt sınıflar.

## Day 13 - Abstract Classes
Soyut sınıflar ve soyut metotlar. Sınıflar arası ortak davranışları soyutlama.

## Day 14 - Scope
Değişkenlerin kapsamı (local vs. global). `public`, `private`, `protected` gibi erişim belirleyiciler.

## Day 15 - Linked List
Bağlı liste nedir, nasıl çalışır? Kendi `Node` sınıfını tanımlayarak örnekleme.

## Day 16 - Exceptions - String to Integer
Hataları yakalama (`try-catch-finally`). `int.Parse`, `Convert.ToInt32`, `TryParse` karşılaştırması.

## Day 17 - More Exceptions
Özel exception sınıfları, `throw`, `InnerException`, `finally` blokları.

## Day 18 - Queues
`Queue<T>` ve `Stack<T>` yapıları. FIFO vs. LIFO mantığı.

## Day 19 - Interfaces
Interface nedir, class ve interface farkları. `IComparable`, `IDisposable` gibi örnek arayüzler.

## Day 20 - Sorting
Verileri sıralama yöntemleri. `Array.Sort()`, `List.Sort()`, `IComparer` kullanımı.

## Day 21 - Generics
Generic sınıf ve metotlar. T türünde çalışma ve type safety.

## Day 22 - Binary Search Trees
Ağaç yapısına giriş. Düğümlerle veri yapısı oluşturma.

## Day 23 - BST Level-Order Traversal
Binary tree üzerinde seviye seviye gezme (`Queue` ile BFS).

## Day 24 - More Linked Lists
Çift yönlü bağlı listeler. Ekstra fonksiyonlarla zenginleştirme.

## Day 25 - Running Time and Complexity
Algoritmaların çalışma süresi. `Big-O` notasyonu.

## Day 26 - Nested Logic
İç içe geçmiş mantıksal yapılar. Koşulların iç içe nasıl çalıştığı.

## Day 27 - Testing
Basit test senaryoları yazma. `Debug.Assert` ve manuel test yaklaşımları.

## Day 28 - Regex, Patterns and Intro to Databases
Regex (düzenli ifadeler) ile string eşleştirme. Veritabanlarına giriş.

## Day 29 - Bitwise AND
Bit düzeyinde işlemler (`&`, `|`, `^`, `~`, `<<`, `>>`). Özellikle algoritmalarda kullanılan güçlü araçlar.

------

## 💡 BONUSLAR VE ÖZEL KATKILAR
"You win some. You lose some." ifadesiyle Split() kullanımını örneklerle gösterdi; hem boşluk hem de nokta karakteriyle parçalama uygulandı.

Regex kullanımında mantıksal bir hata düzeltildi (&& yerine gruplandırma içinde | kullanımı sağlandı).

Release modda çalışan test örnekleri oluşturuldu.

Kullanıcı etkileşimli test senaryoları geliştirildi.

"Code With Love (cwl)" imzasıyla açıklayıcı ve anlaşılır örnekler yazıldı.

Kod puanlama ve stil değerlendirmesi yapıldı (örneğin okunabilirlik, kullanıcı deneyimi, modülerlik).

a & b < k koşulunu sağlayan maksimum kombinasyonu bulan örnek analiz edildi.


------

## 💡 Kafaları Karıştırabilecek Noktalar

| Konu | Neden Karışır? | Açıklama |
|------|----------------|----------|
| == vs .Equals() | Değer mi referans mı? | == primitive, .Equals() nesneler için. |
| ref vs out | Benzer gibi görünür | ref giriş-çıkış, out sadece çıkış. |
| var | Tür gizli gibi gelir | Derleyici zamanı tipi. |
| static | Nesne olmadan çağrılır | Sınıfa aittir. |
| new keyword | Farklı anlamlar | Nesne oluşturma vs. override bastırma. |
| abstract vs interface | Hangisi ne zaman? | abstract kod içerebilir, interface sadece tanım. |
| params | Argüman sayısı değişken | Çoklu argüman için kullanılır. |
| is, as, typeof | Tip kontrol araçları | is: kontrol, as: cast, typeof: tip döndürür. |
| Nullable<int> vs int? | Aynıdır | int? sade halidir. |
| List vs Array | Hangisi kullanılmalı? | List dinamik, Array sabit boyutlu. |

-----

## 🎓 Yeni Başlayanlara Tavsiyeler

1. Her örnekte Console.WriteLine() ile log tut.
2. Kodu debug ederek öğren.
3. Dizi, liste ve dictionary farklarını öğren.
4. Döngüleri deneyerek farklarını gör.
5. Split(), Parse(), TryParse() gibi methodları öğren.
6. Anlatamıyorsan öğrenmemişsindir.
7. StackOverflow ve Microsoft Docs kullan.
8. Küçük kodu bile ciddiye al.
9. Proje yapısına dikkat et.


-----
