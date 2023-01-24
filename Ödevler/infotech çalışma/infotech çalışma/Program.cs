#region örnek1

//int girilensayi = 0;

//Console.Write("sayı giriniz :");
//girilensayi = Convert.ToInt32(Console.ReadLine());

//int sonuç = girilensayi * 18 / 100;

//int sonsonuç = girilensayi + sonuç;

//Console.WriteLine($"bölümü ve kendisi toplamı : {sonsonuç} ");

#endregion

#region örnek2
//bir dikdörtgenin alanını ve çevresini hesaplayarak ekrana yazdıran program

//alan=kısakenar*uzunkenar
//    çevre=2*(kısakenar+uzunkenar)

//int kısakenar = 0;
//int uzunkenar = 0;


//Console.Write("Dikdörtgenin uzun kenarı : ");
//uzunkenar = Convert.ToInt32(Console.ReadLine());

//Console.Write("Dikdörtgenin kısa kenarı : ");
//kısakenar = Convert.ToInt32(Console.ReadLine());

//int çevresi = (kısakenar + uzunkenar) * 2;
//int alani = kısakenar * uzunkenar;

//Console.WriteLine($"çevresi : {çevresi}");
//Console.WriteLine($"alani : {alani}");

//Console.ReadKey();


#endregion

#region örnek3

//3 yazılı notu al değer double ortalamasını al ekrana yazdır

//double yaziliBir , yaziliIki, yaziliUç, toplam;

//Console.Write("1. yazılı notu : ");
//yaziliBir = Convert.ToDouble(Console.ReadLine());

//Console.Write("2. yazılı notu : ");
//yaziliIki = Convert.ToDouble(Console.ReadLine());


//Console.Write("3. yazılı notu : ");
//yaziliUç = Convert.ToDouble(Console.ReadLine());

//toplam = (yaziliBir + yaziliIki + yaziliUç) / 3;

//Console.WriteLine($"Ortalamanız : {toplam}");

#endregion

//ödev 8 adet örnek çöz

#region 8 adet örnek



//int num1 = 5;
//int num2 = 10;
//int sonuc = num1 + num2;
//Console.WriteLine(sonuc);

//--------------------------------------------

//Console.WriteLine("bir numara giriniz : ");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine("girdğiniz rakam : " + num);

//--------------------------------------------

//Console.WriteLine("bir isim giriniz : ");
//string isim = Convert.ToString(Console.ReadLine());
//Console.WriteLine("girğiniz isim : " + isim);

//------------------------------------------------


//int girilensayi = 0;

//Console.Write("sayı giriniz :");
//girilensayi = Convert.ToInt32(Console.ReadLine());

//int sonuç = girilensayi * 10 / 100;

//int sonsonuç = girilensayi + sonuç;

//Console.WriteLine($"bölümü ve kendisi toplamı : {sonsonuç} ");

//---------------------------------------------------

//int girilensayi = 0;

//Console.Write("sayı giriniz :");
//girilensayi = Convert.ToInt32(Console.ReadLine());

//int sonuç = girilensayi * 25 / 100;

//int sonsonuç = girilensayi + sonuç;

//Console.WriteLine($"bölümü ve kendisi toplamı : {sonsonuç} ");

//-----------------------------------------------------------------

//int girilensayi = 0, yüzde = 0;

//Console.Write("sayı giriniz :");
//girilensayi = Convert.ToInt32(Console.ReadLine());
//Console.Write("hesaplayacağınız yüzde değerini giriniz :");
//yüzde = Convert.ToInt32(Console.ReadLine());

//int sonuç = girilensayi * yüzde / 100;

//Console.WriteLine($"girdiğiniz sayının yüzde {yüzde} değeri : {sonuç} ");

//-----------------------------------------------------------

//Console.WriteLine("isminizi giriniz : ");
//string name = Console.ReadLine();
//Console.WriteLine("SELAM, " + name);

//----------------------------------------------------

//int girilensayi = 0;

//Console.Write("Yarısını hesaplayacağınız sayıyı giriniz :");
//girilensayi = Convert.ToInt32(Console.ReadLine());

//int sonuç = girilensayi * 25 / 100;

//Console.WriteLine($"Sayının Yarısı : {sonuç} ");



//-------------------------------------------

#endregion

#region switchcase örnek

//int kısakenar;
//int uzunkenar;
//int seçim;

//Console.Write("Dikdörtgenin uzun kenarı : ");
//uzunkenar = Convert.ToInt32(Console.ReadLine());

//Console.Write("Dikdörtgenin kısa kenarı : ");
//kısakenar = Convert.ToInt32(Console.ReadLine());

//Console.Write("1- Alan Hesaplama \n2- çevre hesaplama\n ");
//seçim = Convert.ToInt32(Console.ReadLine());

//switch (seçim)
//{
//    case 1:
//        int alani = kısakenar * uzunkenar;
//        Console.WriteLine($"dikdörtgenin alanı : {alani}");
//        break;
//    case 2:
//        int çevresi = (kısakenar + uzunkenar) * 2;
//        Console.WriteLine($"dikdörtgenin çevresi : {çevresi}");
//        break;

//    default:
//        Console.WriteLine("yanlış değer girdiniz.");
//        break;
//}

#endregion

#region örnek

//double öğrencibilet = 45.99;
//double tambilet = 99.99;
//double mısırmenü = 78.56;
//double tutar = 0;
//double kdv = 1.18;

//Console.Write("Adınız ve Soyadınız : ");
//string isim = Console.ReadLine();

//Console.Write("Bilet Türü (1-Öğrenci / 2-Tam) : ");
//int biletseçim = Convert.ToInt32(Console.ReadLine());

//Console.Write("Mısır İstermisiniz (1-Evet / 2-Hayır) : ");
//int mısırseçim = Convert.ToInt32(Console.ReadLine());

//switch (biletseçim)
//{

//    case 1:
//        tutar += öğrencibilet * kdv;
//        break;
//    case 2:
//        tutar += tambilet * kdv;
//        break;
//    default:
//        break;
//}
//switch (mısırseçim)
//{
//    case 1:
//        tutar += mısırmenü * kdv;
//        break;

//    default:
//        break;
//}
//Console.WriteLine(isim + ", toplam borcunuz : " + tutar.ToString("0.##") + " TL");

#endregion

#region

// 3 adet double islemlerle ilgili
//3 adet int işlemlerle ilgili
//1 adet string işlemlerle ilgili
//2 switch case örneği

//-----------------------------------------------------

//Console.Write("Toplamak istediğiniz virgüllü sayıyı giriniz : ");
//double sayi1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("Toplamak istediğiniz 2. Virgüllü sayıyı giriniz : ");
//Double sayi2 = Convert.ToDouble(Console.ReadLine());
//double sonuc = sayi1 + sayi2;
//Console.WriteLine($"Toplam Değer : {sonuc}");

//---------------------------------------------------------

//double num1 = 5.25;
//double num2 = 10.33;
//double sonuc = num1 + num2;
//Console.WriteLine(sonuc);

//---------------------------------------------------------

//Console.Write("Yarısını Hesaplayacağınız virgüllü sayıyı giriniz : ");
//double sayi = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("girdiğiniz değerin yarısı : " + sayi / 2);

//-------------------------------------------------------------

//Console.WriteLine("Toplamak istediğiniz sayıları girin. İşlemi bitirip toplamları görmek için 0 giriniz.\n");

//int sonuç = 0;

//while (true)
//{
//    Console.Write("Toplanacak Sayı : ");
//    int Sayi = Convert.ToInt32(Console.ReadLine());
//    if (Sayi == 0)
//    {
//        break;
//    }
//    sonuç += Sayi;
//}
//Console.WriteLine($"\nToplam sonuç : {sonuç}");

//--------------------------------------------------------

//int num1 = 5;
//int num2 = 10;
//int sonuc = num1 + num2;
//Console.WriteLine(sonuc);

//----------------------------------------------------

//Console.WriteLine("bir numara giriniz : ");
//int num = int.Parse(Console.ReadLine());
//Console.WriteLine("girdğiniz rakam : " + num);

//-----------------------------------------------------

//Console.Write("Adınızı Giriniz : ");
//string ad = Console.ReadLine();
//Console.Write("Soyadınızı Giriniz : ");
//string soyad = Console.ReadLine();
//Console.Write("TC Giriniz : ");
//string tc = Console.ReadLine();
//Console.Write("Adres Giriniz : ");
//string adres = Console.ReadLine();
//Console.WriteLine($"\nMerhaba {ad} {soyad}, Kargonuz {tc} TC numarası ile alınabilir. Kargonuz Dağıtıma çıkmıştır {adres} adresine teslimi gün içerisinde yapılacaktır.");

//------------------------------------------------------

//Console.WriteLine("Lütfen bir gün giriniz");
//string gun = Console.ReadLine();

//switch (gun.ToLower())
//{
//    case "pazartesi": Console.WriteLine("Hafta içi"); break;
//    case "salı": Console.WriteLine("Hafta içi"); break;
//    case "çarşamba": Console.WriteLine("Hafta içi"); break;
//    case "perşembe": Console.WriteLine("Hafta içi"); break;
//    case "cuma": Console.WriteLine("Hafta içi"); break;
//    case "cumartesi": Console.WriteLine("Hafta sonu"); break;
//    case "pazar": Console.WriteLine("Hafta sonu"); break;
//    default: Console.WriteLine("Böyle bir gün yok! hafta içi veya hafta sonu olduğu bulunamaz"); break;
//}

//--------------------------------------------------------------

//Console.WriteLine("Anlamını öğrenmek istediğiniz trafik lambası rengini giriniz (Kırmızı/Sarı/Yeşil) : ");
//string renk = Console.ReadLine();

//switch (renk.ToLower())
//{
//    case "kırmızı": Console.WriteLine("Dur"); break;
//    case "sarı": Console.WriteLine("Hazır Ol"); break;
//    case "yeşil": Console.WriteLine("İlerle"); break;

//    default: Console.WriteLine("Böyle bir trafik rengi yok"); break;
}
#endregion