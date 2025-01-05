# C# Fundamentals Project
Patika+ Back-End Web Developer Programı ilk üç haftanın temellerini içerir.

Proje dosyalarını tamamı Program.cs dosyasında düzenli ve kullanılır bir şekilde bulunmaktadır.

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

## 1 - Rastgele Sayı Bulma Oyunu
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

## 2 - Hesap Makinesi
Bizden istenilen kullanıcıdan ilk sayıları almak. Ancak ben ilk istediği işlemi girmesini istiyorum ki ona göre bir console yazısı kullanıcıya vereceğim.

Kullanıcıdan yapmak istediği işlemi istiyoruz ve bunu islem değişkenine atıyoruz.
```C#
Console.WriteLine("Yapmak istediğiniz işlemi seçiniz\nToplama için: +\nÇıkarma için: -\nÇarpma için: x\nBölme için: /");
Console.WriteLine("-------------------");
Console.Write("Seciminiz=>> ");
string? islem = Console.ReadLine();
```

Kullanıcı istediği işleme göre yapılacak işlemi beliriyoruz.
```C#
switch (islem)
{
    case "+":  // toplama işlemi
        Console.WriteLine("--------------Toplama işlemini seçtiniz--------------");
        Console.Write("İlk sayınızı giriniz: ");
        int topla_sayi = Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci sayınızı giriniz: ");
        int topla_sayi1 = Convert.ToInt32(Console.ReadLine());
        int toplam = topla_sayi + topla_sayi;
        Console.WriteLine("Toplama sonucu: "+ toplam);
        break;
    
    case "-": // çıkarma işlemi
        Console.WriteLine("--------------Çıkarma işlemini seçtiniz--------------");
        Console.Write("İlk sayınızı giriniz: ");
        int cikarma_sayi = Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci sayınızı giriniz: ");
        int cikarma_sayi1 = Convert.ToInt32(Console.ReadLine());
        int cikarma = cikarma_sayi - cikarma_sayi1;
        Console.WriteLine("Çıkarma sonucu: "+ cikarma);
        break;

    case "x": // çarpma işlemi
        Console.WriteLine("--------------Çarpma işlemini seçtiniz--------------");
        Console.Write("İlk sayınızı giriniz: ");
        int carpma_sayi = Convert.ToInt32(Console.ReadLine());
        Console.Write("İkinci sayınızı giriniz: ");
        int carpma_sayi1 = Convert.ToInt32(Console.ReadLine());
        int carpma = carpma_sayi * carpma_sayi1;
        Console.WriteLine("Çarpma sonucu: "+ carpma);
        break;

    case "/": // bölme işlemi
        Console.WriteLine("--------------Bölme işlemini seçtiniz--------------");
        Console.Write("Bölünecek sayınızı giriniz: ");
        int bolunen = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bölen sayınızı giriniz: ");
        int bolen = Convert.ToInt32(Console.ReadLine());
        if (bolen == 0)
        {
            Console.WriteLine("Bölen 0 olamaz!!");
        }
        else 
        {
            // sonucun ortalama olarak tam çıkması için bölünen double çevrildi
            double bolum = (double)bolunen / bolen; 
            Console.WriteLine("Bölüm sonucu: "+ bolum);
        }
        break;
    
    default:
        Console.WriteLine("Seçiminiz geçersiz.");
        break;
}
```

Kullanıcı eğer bölme işlemi seçti ise bölen değşkeninin sıfır olmaması kontrolü yapılıyor.
```C#
while (true)
{
    case "/": // bölme işlemi
        Console.WriteLine("--------------Bölme işlemini seçtiniz--------------");
        Console.Write("Bölünecek sayınızı giriniz: ");
        int bolunen = Convert.ToInt32(Console.ReadLine());
        Console.Write("Bölen sayınızı giriniz: ");
        int bolen = Convert.ToInt32(Console.ReadLine());
        if (bolen == 0)
        {
            Console.WriteLine("Bölen 0 olamaz!!");
        }
        else 
        {
            // sonucun ortalama olarak tam çıkması için bölünen double çevrildi
            double bolum = (double)bolunen / bolen; 
            Console.WriteLine("Bölüm sonucu: "+ bolum);
        }
        break;
}
```

İşlemler sonlandıktan sonra kullanıcıya tekrar işlem yapmak isteyip istemediğini soruyorum.
```C#
// tekrar işlem değişkeni
string tekrar = "e";

while (tekrar == "e")
{
    // işlemler

    Console.Write("Başka bir işlem yapmak istiyor musunuz?\n(Evet(e) / Hayır(enter)): ");
    tekrar = Console.ReadLine() ?? string.Empty;
    Console.WriteLine("-------------------");    
}
```
Ardından uygulamayı sonlandırıyoruz.
```C#
Console.WriteLine("Hesap makinesi kapatılıyor.");
```


## 3 - Ortalama Hesaplama
Ders notları hesaplama uygulaması.

Kullanıcıdan 3 adet 0-100 aralığında olan ders notu istiyoruz ve bu notlar 0-100 aralığında girilmediğinde uygulamyı sonlandırıyoruz.
```C#
// uygulama devamlılığı sağlama değişkeni
int i = 0;

// kullanıcının girdiği not 0-100 arası kontrolü
bool NotKontrol(int not)
{
    return not >= 0 && not <= 100;
}

// diğer kodlar

// not 0-100 olmaz ise uygulama sonlandırılır
while (i == 0)
{
    // kullanıcıdan 0-100 arası not alıyoruz
    Console.WriteLine("Ortalamasını hesaplamak istediğiniz notları giriniz.");
    Console.Write("Birinci not: ");
    int not1 = Convert.ToInt32(Console.ReadLine());
    if(!NotKontrol(not1))
    {
        Console.WriteLine("0-100 arasında not giriniz!!");
        break;
    }
    
    Console.Write("İkinci not: ");
    int not2 = Convert.ToInt32(Console.ReadLine());
    if(!NotKontrol(not2))
    {
        Console.WriteLine("0-100 arasında not giriniz!!");
        break;
    }

    Console.Write("Üçüncü not: ");
    int not3 = Convert.ToInt32(Console.ReadLine());
    if(!NotKontrol(not3))
    {
        Console.WriteLine("0-100 arasında not giriniz!!");
        break;
    }

    // diğer kolar
}
```

Uygulama sorunsuz devam etmesi halinde not ortalaması hesaplanıyor.
```C#
// ortalama not değişkeni
double ortalama_not = 0;

// diğer kodlar

while (i == 0)
{
    // diğer kodlar

    // not burada double dönüşümü yapıyor
    ortalama_not = (double)(not1 + not2 + not3) / 3; 
    Console.WriteLine($"Not ortalamanız: {ortalama_not}");
    Console.WriteLine("--------------------");
    i++; // uygulamyı devam ettire bilmek için değişkeni artırıyorum
}
```

Hesaplanan not ortalamasının harf karşılığı kullanıcıya sunuluyor.
```C#
// notların harf karşılığını veren metot
string HarfNotuHesapla(double ortalama)
{
    if (ortalama >= 90 && ortalama <= 100)     // 90-100: AA
        return "AA";
    else if (ortalama >= 85 && ortalama <= 89) // 85-89:  BA
        return "BA";
    else if (ortalama >= 80 && ortalama <= 84) // 80-84:  BB
        return "BB";
    else if (ortalama >= 75 && ortalama <= 79) // 75-79:  CB
        return "CB";
    else if (ortalama >= 70 && ortalama <= 74) // 70-74:  CC
        return "CC";
    else if (ortalama >= 65 && ortalama <= 69) // 65-69:  DC
        return "DC";
    else if (ortalama >= 60 && ortalama <= 64) // 60-64:  DD
        return "DD";
    else if (ortalama >= 55 && ortalama <= 59) // 55-59:  FD
        return "FD";
    else                                       // 0-54:   FF
        return "FF";
}

// diğer kodlar

// consola harf notunu yazdıracağız
while (i == 1)
{
    string harf = HarfNotuHesapla(ortalama_not);
    Console.WriteLine($"Not ortalamanız {ortalama_not} : {harf} ile değerlendirildi. Başarılar..");
    break;
}
```

Ardından uygulama sonlandırılıyor.
```C#
Console.WriteLine("Uygulama sonlandırılıyor..");
```

**_"Buraya kadar geldiyseniz teşekkürler. Proje bu kadar..."_**