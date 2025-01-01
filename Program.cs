// kodlar düzenli gözüksün diye alt alta yazdım
Console.WriteLine("---------------HOŞGELDİNİZ---------------");
Console.WriteLine("Hangi programı seçmek istersiniz:");
Console.WriteLine("1 - Rastgele Sayı Bulma Oyunu");
Console.WriteLine("2 - Hesap Makinesi");
Console.WriteLine("3 - Ortalama Hesaplama");
Console.Write("Seçiminiz (1 / 2 / 3): ");
string? secim = Console.ReadLine() ?? string.Empty; // değer girilmez ise boş sayılır

secim = secim.Trim(); // trim ile değerin başındaki ve sonundaki boşluklar silinir


// sayı bulma oyunu
void Oyun()
{
    Console.WriteLine("----------------------------Sayı Bulma Oyununa Hoşgeldiniz----------------------------");
    // rastgele sayı
    Random rastgele = new Random();
    int sayi = rastgele.Next(1,101);

    int i = 0; // tahmin hakkı

    // kullanıcı tahmini
    Console.Write($"Üretilen rastgele sayıyı tahmin ediniz. 1 ile 100 arasında. Tahmin hakkınız 5\n{i + 1}.  Tahmininiz: ");
    int tahmin = Convert.ToInt32(Console.ReadLine());

    // tahmini döndüren do-while
    do
    {
        i++;
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


    Console.WriteLine("Oyun bitti. Tekrar oynamak için programı yeniden başlatın!");
}


// hesap makinesi
void HesapMakinesi()
{
    Console.WriteLine("----------------------------Hesap Makinesine Hoşgeldiniz----------------------------");
    // ilk önce kullanıcıdan işlem bilgisi alarak istediği işleme göre aksiyon alınması sağlanıyor

    // tekrar işlem değişkeni
    string tekrar = "e";

    while (tekrar == "e")
    {
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
                    // sonucun ortalama olarak tam çıkması için bölünen double çevrildi
                    double bolum = (double)bolunen / bolen; 
                    Console.WriteLine("Bölüm sonucu: "+ bolum);
                }
                break;
            
            default:
                Console.WriteLine("Seçiminiz geçersiz.");
                break;
        }

        Console.Write("Başka bir işlem yapmak istiyor musunuz?\n(Evet(e) / Hayır(enter)): ");
        tekrar = Console.ReadLine() ?? string.Empty;
        Console.WriteLine("-------------------");
    }

    Console.WriteLine("Hesap makinesi kapatılıyor.");
}


// ortalama hesaplama uygulaması
void OrtalamaHesapla()
{
    Console.WriteLine("----------------------------Ortalama Hesaplamaya Hoşgeldiniz----------------------------");
    
    // ortalama not değişkeni
    double ortalama_not = 0;
    // uygulama devamlılığı sağlama değişkeni
    int i = 0;
    // notların harf karşılığını veren metot
    string HarfNotuHesapla(double ortalama)
    {
        if (ortalama >= 90 && ortalama <= 100)     // 90-100: AA
            return "AA";
        else if (ortalama >= 85 && ortalama <= 89) // 85-89:  BA
            return "BA";
        else if (ortalama >= 84 && ortalama <= 80) // 80-84:  BB
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
    // kullanıcının girdiği not 0-100 arası kontrolü
    bool NotKontrol(int not)
    {
        return not >= 0 && not <= 100;
    }

    
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

        // not burada double dönüşümü yapıyor
        ortalama_not = (double)(not1 + not2 + not3) / 3; 
        Console.WriteLine($"Not ortalamanız: {ortalama_not}");
        Console.WriteLine("--------------------");
        i++; // uygulamyı devam ettire bilmek için değişkeni artırıyorum
    }

    // consola harf notunu yazdıracağız
    while (i == 1)
    {
        string harf = HarfNotuHesapla(ortalama_not);
        Console.WriteLine($"Not ortalamanız {ortalama_not} : {harf} ile değerlendirildi. Başarılar..");
        break;
    }


    Console.WriteLine("--------------------");
    Console.WriteLine("Uygulama sonlandırılıyor..");

}


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