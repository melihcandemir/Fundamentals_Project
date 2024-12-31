// C# Fundamentals Project
// Proje haftasına hoş geldiniz! Bu projede sizlerden 3 aşamalı bir uygulama geliştirmeniz isteniyor. 
// Uygulamayı çalıştıran kullanıcıya program seçeneklerini konsol üzerinden sunarak bir tanesini seçmesini isteyiniz.

// Hangi programı çalıştırmak istersiniz - 3 farklı seçenek :
// 1 - Rastgele Sayı Bulma Oyunu
// 2 - Hesap Makinesi
// 3 - Ortalama Hesaplama
// küçük karaktere çevrilen string değerin kayıp yaşamaması için eklendi
using System.Globalization; // yapay zekadan yardım alındı 
Console.OutputEncoding = System.Text.Encoding.UTF8; // konsol utf-8 e göre çalışması için

// kodlar düzenli gözüksün diye alt alta yazdım
Console.WriteLine("---------------HOŞGELDİNİZ---------------");
Console.WriteLine("Hangi programı seçmek istersiniz:");
Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
Console.WriteLine("2 - Hesap Makinesi");
Console.WriteLine("3 - Ortalama Hesaplama");
Console.Write("Seçiminiz: ");
string? secim = Console.ReadLine() ?? string.Empty; // değer girilmez ise boş sayılır

foreach (char c in secim)
{
    Console.WriteLine($"Karakter: {c} | Unicode: {(int)c}");
}
Console.WriteLine("-------------------------");

secim = secim.ToLower(new CultureInfo("tr-TR")); // girilen değerleri küçültür utf-8 e uygun olarak
secim = secim.Trim(); // trim ile boşluklar silinir

foreach (char c in secim)
{
    Console.WriteLine($"Karakter: {c} | Unicode: {(int)c}");
}

switch (secim)
{
    case "1":
    case "rastgele sayı bulma oyunu":
        Console.WriteLine("başarılı-1");
        break;

    case "2":
    case "hesap makinesi":
        Console.WriteLine("başarılı-2");
        break;

    case "3":
    case "ortalama hesaplama":
        Console.WriteLine("başarılı-3");
        break;

    default:
        Console.WriteLine("Lütfen yukarıda yazan üçünden birini seçiniz..");
        Console.WriteLine(secim);
        break;
}
