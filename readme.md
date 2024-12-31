# C# Fundamentals Project
Patika+ Back-End Web Developer Programı ilk üç haftanın temellerini içerir

## Bu projede 3 aşamalı bir uygulama geliştirmemiz isteniyor.
Hangi programı çalıştırmak istersiniz - 3 farklı seçenek:
- 1 - Rastgele Sayı Bulma Oyunu
- 2 - Hesap Makinesi
- 3 - Ortalama Hesaplama

### Kullanıcıdan hangi uygulamayı istediğini soruyoruz.
```C#
// kodlar düzenli gözüksün diye alt alta yazdım
Console.WriteLine("---------------HOŞGELDİNİZ---------------");
Console.WriteLine("Hangi programı seçmek istersiniz:");
Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
Console.WriteLine("2 - Hesap Makinesi");
Console.WriteLine("3 - Ortalama Hesaplama");
Console.Write("Seçiminiz (1 / 2 / 3): ");
string? secim = Console.ReadLine() ?? string.Empty; // değer girilmez ise boş sayılır

secim = secim.Trim(); // trim ile string değerin başındaki ve sonundaki boşluklar silinir
```
### Daha sonra hangisini istedi ise uygulamayı çalıştırıyoruz.
```C#
// switch ile yapılan seçimi çalıştırıyoruz
switch (secim)
{
    case "1": // rastgele sayı bulma oyunu
        Oyun();
        break;

    case "2": // hesap makinesi
        HesapMakinesi();
        break;

    case "3": // ortalama hesaplama
        OrtalamaHesapla();
        break;

    default:
        Console.WriteLine("Lütfen yukarıda yazan üç uygulamadan birini seçiniz!");
        Console.WriteLine(secim);
        break;
}
```

## Rastgele Sayı Bulma Oyunu
Rastgele 0-100 arası sayı üretiyoruz.
```C#
// rastgele sayı
Random rastgele = new Random();
int sayi = rastgele.Next(1,101);
```

Kullanıcıdan 1 ile 100 arasında bir sayı tahmin etmesini istiyoruz. 5 tahmin hakkı var.
```C#
// kullanıcı tahmini
Console.Write($"Üretilen rastgele sayıyı tahmin ediniz. 1 ile 100 arasında. Tahmin hakkınız 5\n{i + 1}.  Tahmininiz: ");
int tahmin = Convert.ToInt32(Console.ReadLine());
```

Kullanıcı her tahmininde, bilgisayarın seçtiği sayıya yakınlığını kontrol edip ipucu veriyoruz (daha yüksek veya daha düşük).
```C#
// tahminin ve rastgele sayı arasındaki büyüklük küçüklük farkını belirler
if (sayi < tahmin)
{
    Console.WriteLine("----------------");
    Console.Write($"Tahmininizden daha küçük bir sayı giriniz.\n{5 - i} hakkınız kaldı.\n{i + 1}.- Tahmininizi giriniz: ");
    tahmin = Convert.ToInt32(Console.ReadLine());
}
else if (sayi > tahmin)
{
    Console.WriteLine("----------------");
    Console.Write($"Tahmininizden daha büyük bir sayı giriniz.\n{5 - i} hakkınız kaldı.\n{i + 1}.- Tahmininizi giriniz: ");
    tahmin = Convert.ToInt32(Console.ReadLine());
}
```

Tahmin hakkının ne kadar kaldığını kullanıcıya söylüyoruz.
```C#
Console.Write($"Tahmininizden daha büyük bir sayı giriniz.\n{5 - i} hakkınız kaldı.\n{i + 1}.- Tahmininizi giriniz: ");

//

// deneme hakkının bittiğini belirtir
if (i == 4)
{
    Console.WriteLine("----------------");
    Console.WriteLine($"5 denemede bulamadınız. Tahmin etmeye çalıştığınız sayı: {sayi}");
    Console.WriteLine("----------------");
    break;
}
```

Kullanıcı doğru bildiyse tebrik ediyoruz.
```C#
// tahmin doğruluğunu belirler
if (sayi == tahmin)
{
    Console.WriteLine("----------------");
    Console.WriteLine($"Tahmin sayınız: {tahmin}\nBulmanız gereken sayı: {sayi}\n{i + 1}. seferde doğru tahmin ettiniz....");
    Console.WriteLine("----------------");
    break;
}
```

Ardından oyunu sonlandırıyoruz.
```C#
Console.WriteLine("Oyun bitti. Tekrar oynamak için programı yeniden başlatın!");
```



```C#
```