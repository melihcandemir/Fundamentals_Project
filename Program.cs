// C# Fundamentals Project
// Proje haftasına hoş geldiniz! Bu projede sizlerden 3 aşamalı bir uygulama geliştirmeniz isteniyor. 
// Uygulamayı çalıştıran kullanıcıya program seçeneklerini konsol üzerinden sunarak bir tanesini seçmesini isteyiniz.

// Hangi programı çalıştırmak istersiniz - 3 farklı seçenek :
// 1 - Rastgele Sayı Bulma Oyunu
// 2 - Hesap Makinesi
// 3 - Ortalama Hesaplama

// kodlar düzenli gözüksün diye alt alta yazdım
Console.WriteLine("---------------HOŞGELDİNİZ---------------");
Console.WriteLine("Hangi programı seçmek istersiniz:");
Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
Console.WriteLine("2 - Hesap Makinesi");
Console.WriteLine("3 - Ortalama Hesaplama");
Console.Write("Seçiminiz: ");
string? secim = Console.ReadLine() ?? string.Empty; // değer girilmez ise boş sayılır

secim = secim.ToLower(); // girilen değerleri küçültür
secim = secim.Trim(); // trim ile string değerin başındaki ve sonundaki boşluklar silinir

// sayı bulma oyunu
// Rastgele Sayı Bulma Oyunu
// Bilgisayar bir rastgele sayı belirlesin (örneğin 1 ile 100 arasında).
// Kullanıcıdan bu sayıyı tahmin etmesini isteyin.
// Kullanıcı her tahmininde, bilgisayarın seçtiği sayıya yakınlığını kontrol edin ve ipucu verin (daha yüksek veya daha düşük).
// Kullanıcının 5 canı olsun (5 tahmin hakkı). Her tahmin sonrası kalan canını gösterin.
// Kullanıcı doğru tahminde bulunursa oyunu bitirin ve tebrik edin.
// Eğer 5 tahmin hakkı dolarsa, doğru sayıyı gösterin ve oyunu bitirin.

// sayı bulma oyunu
void Oyun()
{
    Console.WriteLine("----------------------------Sayı Bulma Oyununa Hoşgeldiniz----------------------------");
    // rastgele sayı
    Random rastgele = new Random();
    int sayi = rastgele.Next(1,5);

    int i = 0; // tahmin hakkı

    // kullanıcı tahmini
    Console.Write($"Üretilen rastgele sayıyı tahmin ediniz. 1 ile 100 arasında. Tahmin hakkınız 5\n{i + 1}.  Tahmininiz: ");
    int tahmin = Convert.ToInt32(Console.ReadLine());

    do
    {
        i++;

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
        
        if (sayi == tahmin)
        {
            Console.WriteLine($"Tahmin sayınız: {tahmin}\nBulmanız gereken sayı: {sayi}\n{i + 1}. seferde doğru tahmin ettiniz....");
            Console.WriteLine("----------------");
            break;
        }
    
        if (i == 4)
        {
            Console.WriteLine("----------------");
            Console.WriteLine($"5 denemede bulamadınız. Tahmin etmeye çalıştığınız sayı: {sayi}");
            Console.WriteLine("----------------");
            break;
        }
            
        


    } while(i < 4);


    Console.WriteLine("Oyundan çıkılıyor..");
}


switch (secim)
{
    case "1":
    case "rastgele sayı bulma oyunu":
        Oyun();
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
