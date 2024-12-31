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
Console.Write("Seçiminiz (1 / 2 / 3): ");
string? secim = Console.ReadLine() ?? string.Empty; // değer girilmez ise boş sayılır

secim = secim.ToLower(); // girilen değerleri küçültür
secim = secim.Trim(); // trim ile string değerin başındaki ve sonundaki boşluklar silinir


// sayı bulma oyunu
void Oyun()
{
    Console.WriteLine("----------------------------Sayı Bulma Oyununa Hoşgeldiniz----------------------------");
    // rastgele sayı
    Random rastgele = new Random();
    int sayi = rastgele.Next(1,100);

    int i = 0; // tahmin hakkı

    // kullanıcı tahmini
    Console.Write($"Üretilen rastgele sayıyı tahmin ediniz. 1 ile 100 arasında. Tahmin hakkınız 5\n{i + 1}.  Tahmininiz: ");
    int tahmin = Convert.ToInt32(Console.ReadLine());

    // tahmini döndüren do-while
    do
    {
        i++;
        // tahminin rastgele sayı ile arasındaki büyüklük küçüklük farkını belirler
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
        
        // tahmin doğruluğunu belirler
        if (sayi == tahmin)
        {
            Console.WriteLine("----------------");
            Console.WriteLine($"Tahmin sayınız: {tahmin}\nBulmanız gereken sayı: {sayi}\n{i + 1}. seferde doğru tahmin ettiniz....");
            Console.WriteLine("----------------");
            break;
        }

        // deneme hakkının bittiğini belirtir
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

// Hesap Makinesi
// Kullanıcıya ilk sayıyı girmesini isteyin.
// Kullanıcıya ikinci sayıyı girmesini isteyin.
// Kullanıcıya yapmak istediği işlemi seçmesini isteyin:
// Toplama için +
// Çıkarma için -
// Çarpma için *
// Bölme için /
// Kullanıcının seçimine göre uygun işlemi gerçekleştirip sonucu ekrana yazdırın. Eğer bölme işlemi seçildiyse, sıfıra bölme hatası durumunu kontrol edin.
// Programı yazarken dikkat etmeniz gereken noktalar:
// Kullanıcı girdilerini doğru bir şekilde almak için Console.ReadLine() ve Convert.ToInt32() gibi metodları kullanın.
// İşlem seçiminde if-else veya switch-case yapısını kullanarak uygun işlemi gerçekleştirin.
// Bölme işlemi yapılırken sıfıra bölme hatasını kontrol edin ve kullanıcıya uygun bir mesaj gösterin.

void HesapMakinesi()
{
    Console.WriteLine("----------------------------Hesap Makinesine Hoşgeldiniz----------------------------");
    // ilk önce kullanıcıdan işlem bilgisi alarak istediği işleme göre aksiyon alınması sağlanıyor
    Console.WriteLine("Yapmak istediğiniz işlemi seçiniz\nToplama için: +\nÇıkarma için: -\nÇarpma için: x\nBölme için: /");
    Console.WriteLine("-------------------");
    Console.Write("Seciminiz=>> ");
    string? islem = Console.ReadLine();

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
                // sonucun otalama olarak tam çıkması için bölünen double çevrildi
                double bolum = (double)bolunen / bolen; 
                Console.WriteLine("Bölüm sonucu: "+ bolum);
            }
            break;
        
        default:
            Console.WriteLine("Seçiminiz geçersiz. Çıkış yapılıyor...");
            break;
    }
}

switch (secim)
{
    case "1":
        Oyun();
        break;

    case "2":
        HesapMakinesi();
        break;

    case "3":
        Console.WriteLine("başarılı-3");
        break;

    default:
        Console.WriteLine("Lütfen yukarıda yazan üçünden birini seçiniz..");
        Console.WriteLine(secim);
        break;
}
