/*
byte: uzunluğu 1 byte'tır,0 ile 255 arasında değer alır
sbyte: Uzunluğu 1 byte -128 ile 127  sayıları arasında değer alır.
short = Uzunluğu 2 byte -32768 ile 32767 arasında değer alır.
ushort 2 byte 0 ile 65535 sayıları arasında değer alır.
int  uzunluğu 4 byte -2147483648 ile 2147483647
uint 4 byte 0 ile 4294967295 arasında değer alır.
long uzunluğu 8 byte -2x 10 üzeri 20 ile 2x10 üzeri 20 arasında değer alır.
ulong 8 byte 0 ile 2x 10 üzeri 20 sayıları arasında değer alır.
float  4 byte 1.5x10-45 ile 3.4x10 38 sayıları arasında değer alır.
double 8 byte
decimal 12 byte
char = 2 byte karekter tanımlanır:
örn char degisken='A' || '8'
string : Tek bir değer veya karekter veya metin veya cümle veya sayıları metinsel olarak içinde barındırır.
boolean = True False değer tutar arkada sakladığı değeride 1 veya 0.
*/
/*
+,-,/,++,--,% bunlar aritmetik operatörlerdir.
/,*,+,- matematiksel işlemlerdir.
% operatörü bölümden kalanı bulmak için yani mod almak içinde kullanılır.
++ ve -- işlemi uygulandığında değişken değerinin değerini bir arttırır. vea bir azaltır.
& bu işaret ise ve yi temsil eder
'!='=eşit değil demektir.
'=='=eşittir demektir.
< = küçüktür işareti
> = büyüktür işareti
<= =küçük eşit
>= büyük eşit demektir.
|| = veya işaretir.
 */
//string NameSurname=string.Empty;
//NameSurname = "Haşmet Tazegül";
//Console.WriteLine("Bir satır alta atarak yazar");

/*
 Değişken atamaları iki türlü olur
bir tanesi default(varsayılan) değerlerle tanmlanır.
diğeri ise kullanıcıdan değerleri alır.
kullanıcı merkezli değişkenler deriz biz bunlara.

 */
//double sayi1 = 0;
//Console.WriteLine("Bir sayı giriniz : ");
//sayi1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Girilen Değer : {0} ",sayi1);
//Console.WriteLine("Girilen Değer :  "+ sayi1);

#region Örnek - 1
//string ad, soyad;
//Console.Write("Adınızı Giriniz : ");
//ad = Console.ReadLine();
//Console.WriteLine();
//Console.Write("Soyadınızı Giriniz : ");
//soyad = Console.ReadLine();
//Console.WriteLine();
//Console.Write("Merhaba {0} {1}", ad, soyad);
#endregion
#region Örnek - 2
//int sayi1, sayi2, toplam = 0, carpim = 0, fark = 0,bolum=0 ;
//Console.Write("Lüfen sayı giriniz : ");
//sayi1 = int.Parse(Console.ReadLine());
//Console.WriteLine();
//Console.Write("Lüfen ikinci sayı giriniz : ");
//sayi2 = int.Parse(Console.ReadLine());
//toplam = sayi1+sayi2;
//Console.WriteLine("İki sayi toplamı : " + toplam);
//carpim = sayi1 * sayi2;
//Console.WriteLine("İki sayi çarpımı : " + carpim);
//fark=sayi1-sayi2;
//Console.WriteLine("İki sayi farkı : " + fark);
//bolum = sayi1 / sayi2;
//Console.WriteLine("İki sayi bölme : " + bolum);
#endregion
#region Örnek - 3
//double sayi, sonuc;
//Console.WriteLine("Lütfen Ürün Fiyatını Giriniz : ");
//sayi = double.Parse(Console.ReadLine());
//sonuc = ((sayi * 18) / 100) + sayi;
//sonuc = sayi * 1.18;
//Console.WriteLine("Ürünün KDV'li Tutarı : " + sonuc);
#endregion
#region Örnek - 4
//int kisa, uzun, alan, cevre;
//Console.Write("Kısa Kenar : ");
//kisa = Convert.ToInt32(Console.ReadLine());
//Console.Write("Uzun Kenar : ");
//uzun = Convert.ToInt32(Console.ReadLine());
//alan = kisa * uzun;
//cevre = 2 * (kisa + uzun);
//Console.WriteLine("Alan : " + alan);
//Console.WriteLine("Çevre : " + cevre);
#endregion
#region Örnek - 5
//double yazili1, yazili2, yazili3, ortalama;
//Console.Write("1. Yazılı : ");
//yazili1 = Convert.ToDouble(Console.ReadLine());
//Console.Write("2. Yazılı : ");
//yazili2 = Convert.ToDouble(Console.ReadLine());
//Console.Write("3. Yazılı : ");
//yazili3 = Convert.ToDouble(Console.ReadLine());
//ortalama = (yazili1 + yazili2 + yazili3) / 3;
//Console.WriteLine("Ortalamanız : " + ortalama);
#endregion
#region Tanım - Değişkenler
/*
byte: uzunluğu 1 byte'tır,0 ile 255 arasında değer alır
sbyte: Uzunluğu 1 byte -128 ile 127  sayıları arasında değer alır.
short = Uzunluğu 2 byte -32768 ile 32767 arasında değer alır.
ushort 2 byte 0 ile 65535 sayıları arasında değer alır.
int  uzunluğu 4 byte -2147483648 ile 2147483647
uint 4 byte 0 ile 4294967295 arasında değer alır.
long uzunluğu 8 byte -2x 10 üzeri 20 ile 2x10 üzeri 20 arasında değer alır.
ulong 8 byte 0 ile 2x 10 üzeri 20 sayıları arasında değer alır.
float  4 byte 1.5x10-45 ile 3.4x10 38 sayıları arasında değer alır.
double 8 byte
decimal 12 byte
char = 2 byte karekter tanımlanır:
örn char degisken='A' || '8'
string : Tek bir değer veya karekter veya metin veya cümle veya sayıları metinsel olarak içinde barındırır.
boolean = True False değer tutar arkada sakladığı değeride 1 veya 0.
*/
/*
+,-,/,++,--,% bunlar aritmetik operatörlerdir.
/,*,+,- matematiksel işlemlerdir.
% operatörü bölümden kalanı bulmak için yani mod almak içinde kullanılır.
++ ve -- işlemi uygulandığında değişken değerinin değerini bir arttırır. vea bir azaltır.
& bu işaret ise ve yi temsil eder
'!='=eşit değil demektir.
'=='=eşittir demektir.
< = küçüktür işareti
> = büyüktür işareti
<= =küçük eşit
>= büyük eşit demektir.
|| = veya işaretir.
 */
#endregion
#region TANIM ÖRNEKLERİ
//Guid identity = Guid.NewGuid();
//int ID;
//Console.WriteLine(identity.ToString("N"));
//Console.WriteLine(identity.ToString("D"));
//Console.WriteLine(identity.ToString("B"));
//Console.WriteLine(identity.ToString("P"));
//Console.WriteLine(Guid.NewGuid());
//int a = 0, b=0;
//double toplam = 0;
//Console.WriteLine("A değerini giriniz : ");
//a = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("B değerini giriniz : ");
//b = Convert.ToInt16(Console.ReadLine());
//toplam = Convert.ToDouble(a + b);
//Console.WriteLine(toplam);
#endregion
#region Koşullar
#region 1. Koşul
//double sayi;
//Console.WriteLine("Bir Sayı Değeri Giriniz Rasyonel Sayıda Olabilir : ");
//sayi = Convert.ToDouble(Console.ReadLine());
//if (sayi % 5 == 0 && sayi % 3 == 0)
//{
//    Console.WriteLine("Girdiğiniz hem 5 hemde 3 e tam bölünen sayıdır.");
//}
//else
//{
//    Console.WriteLine("Girdiğiniz hem 5 hemde 3 e tam bölünen sayı değildir.");
//}
#endregion
#region 2. Koşul
//double sayi = 0;
//Console.WriteLine("Bir sayı giriniz : ");
//sayi = Convert.ToDouble(Console.ReadLine());
//if (sayi % 5 == 0 && sayi % 3 == 0)
//{
//    Console.WriteLine("Girdiğiniz hem 5 hemde 3 e tam bölünen sayıdır.");
//}
//else if (sayi % 5 == 0 || sayi % 3 == 0)
//{
//    Console.WriteLine("Girdiğiniz hem 5 hemde 3 e tam bölünen sayı olmasada en az birtanesini sağlar.");
//}
//else
//{
//    Console.WriteLine("Girdiğiniz hem 5 hemde 3 e tam bölünen sayı değildir.");
//}
#endregion
#region 3. Koşul
//double sayi = 0;
//Console.WriteLine("Bir sayı giriniz : ");
//sayi = Convert.ToDouble(Console.ReadLine());
//switch (sayi % 5 == 0 && sayi % 3 == 0)
//{
//	case true:
//		Console.WriteLine("Sayı 3e ve 5e tam bölünür");
//		break;
//    default:
//        Console.WriteLine("Girdiğiniz hem 5 hemde 3 e tam bölünen sayı değildir.");
//        break;
//}
//int day = 4;
//switch (day)
//{
//	case 1:
//		Console.WriteLine("1.Gün");
//		break;
//    case 2:
//        Console.WriteLine("2.Gün");
//        break;
//    case 3:
//        Console.WriteLine("3.Gün");
//        break;
//    case 4:
//        Console.WriteLine("4.Gün");
//        break;
//    case 5:
//        Console.WriteLine("5.Gün");
//        break;
//    case 6:
//        Console.WriteLine("6.Gün");
//        break;
//    case 7:
//        Console.WriteLine("6.Gün");
//        break;
//    default:
//		break;
//}
#endregion
#endregion
#region Switch Case
//int sayi1, sayi2,islem;
//double sonuc;

//Console.WriteLine("Lütfen sayı giriniz : ");
//sayi1=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Lütfen sayı giriniz : ");
//sayi2 = Convert.ToInt32(Console.ReadLine());
//basla:
//Console.WriteLine("1- Toplama\n2- Çıkarma\n3- Çarpma\n4- Bölme\n5- Sayı karesini alma");
//islem=Convert.ToInt32(Console.ReadLine());

//switch (islem)
//{
//	case 1:
//		sonuc = Convert.ToDouble(sayi1 + sayi2);
//		Console.WriteLine("Sonuç : " + sonuc);
//		break;
//	case 2:
//        sonuc = Convert.ToDouble(sayi1 - sayi2);
//        Console.WriteLine("Sonuç : " + sonuc);
//        break;
//	case 3:
//        sonuc = Convert.ToDouble(sayi1 * sayi2);
//        Console.WriteLine("Sonuç : " + sonuc);
//        break;
//	case 4:
//        sonuc = Convert.ToDouble(sayi1 / sayi2);
//        Console.WriteLine("Sonuç : " + sonuc);
//        break;
//     case 5:
//        sonuc = sayi1 * sayi1;
//        Console.WriteLine("Sonuç : " + sonuc);
//        break;
//    default:
//        Console.WriteLine("Yanlış işlem yaptınız");
//		break;
//}
//goto basla;
//Console.WriteLine("Lütfen bir ay giriniz : ");
//string ay=Console.ReadLine();
//switch (ay.ToLower())
//{
//	case "ocak":
//		Console.WriteLine("Kış");
//		break;
//    case "şubat":
//        Console.WriteLine("Kış");
//        break;
//    case "mart":
//        Console.WriteLine("İlkbahar");
//        break;
//    case "nisan":
//        Console.WriteLine("İlkbahar");
//        break;
//    case "mayıs":
//        Console.WriteLine("İlkbahar");
//        break;
//    case "haziran":
//        Console.WriteLine("Yaz");
//        break;
//    case "temmuz":
//        Console.WriteLine("Yaz");
//        break;
//    case "ağustos":
//        Console.WriteLine("Yaz");
//        break;
//    case "eylül":
//        Console.WriteLine("Sonbahar");
//        break;
//    case "ekim":
//        Console.WriteLine("Sonbahar");
//        break;
//    case "kasım":
//        Console.WriteLine("Sonbahar");
//        break;
//    case "aralık":
//        Console.WriteLine("Kış");
//        break;
//    default:
//        Console.WriteLine("La cahil böyle bir ay yok");
//		break;
//}
//switch (DateTime.Now.DayOfWeek)
//{
//	case DayOfWeek.Sunday:
//		Console.WriteLine("Sendromun bitmesin inşallah");
//		break;
//	case DayOfWeek.Monday:
//		Console.WriteLine("Başladı lanet hafta");
//		break;
//	case DayOfWeek.Tuesday:
//		Console.WriteLine("Bitmez Bu hafta");
//		break;
//	case DayOfWeek.Wednesday:
//		Console.WriteLine("Azı gitti çoğu kaldı");
//		break;
//	case DayOfWeek.Thursday:
//		Console.WriteLine("Üçün beşin lafını yapmayak işte avrupa 3 gün tatile geçti.");
//		break;
//	case DayOfWeek.Friday:
//        Console.WriteLine("Tatil zannettin dime Osmanlı devletinde mi yaşıyon hayırdır. Çalışlan Köpek");
//        break;
//	case DayOfWeek.Saturday:
//		Console.WriteLine("Hadi iyisin kaptın tatili köftor");
//		break;
//	default:
//		break;
//}

//double kisa, uzun,sonuc;
//int secim;
//Console.WriteLine("Kısa Kenarı Giriniz : ");
//kisa=Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Uzun Kenari Giriniz : ");
//uzun=Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("1-Alan\n2-Çevre");
//secim = Convert.ToInt16(Console.ReadLine());
//switch (secim)
//{
//	case 1:
//		sonuc = kisa * uzun;
//		Console.WriteLine("Alan Hesap Sonucu = {0}", sonuc);
//		break;
//	case 2:
//		sonuc = 2 * (kisa + uzun);
//        Console.WriteLine("Çevre Hesap Sonucu = {0}", sonuc);
//		break;
//    default:
//        Console.WriteLine("Yanlış işlem yaptınız");
//        break;
//}
/*
 Bir sinema bileti alınacak
 sinema biletin öğrenci bileti 45.99 olacak
 tam biletin fiyatı 99.99 olacak
 mısr menüsü fiyatı ise 78.56 olacak
 kullanıcıdan alınacak veri adı soyadı
 bilet türü ve son olarak mısır menüsü istiyor mu
istemiyor mu Kolay Gelsin

 */
//string name, surname;
//double obilet = 45.99, tbilet=99.99,mfiyat=78.56,sonuc=0;
//int secim = 0;
//basla:
//Console.WriteLine("1-Öğrenci Bileti\n2-Tam Bilet\n3-Öğrenci ve Mısır Menüsü\n4-Tam bilet ve Mısır Menüsü");
//secim = Convert.ToInt16(Console.ReadLine());
//Console.WriteLine("Adınızı Giriiz : ");
//name = Console.ReadLine();
//Console.WriteLine("Soyadınızı Giriiz : ");
//surname = Console.ReadLine();
//switch (secim)
//{
//	case 1:
//		sonuc = obilet * 1.18;
//		Console.WriteLine("Sayın {0} {1} Aşağıda ödeyeceğiniz tutar bulunmaktadır.", name, surname);
//		Console.WriteLine("Ara Toplam : {0}TL\nKDV Oranı : %18\nGenel Toplam : {1}TL", obilet.ToString("0.##"), sonuc.ToString("0.##"));
//		break;
//	case 2:
//        sonuc = tbilet * 1.18;
//        Console.WriteLine("Sayın {0} {1} Aşağıda ödeyeceğiniz tutar bulunmaktadır.", name, surname);
//        Console.WriteLine("Ara Toplam : {0}TL\nKDV Oranı : %18\nGenel Toplam : {1}TL", tbilet, sonuc.ToString("0.##"));
//        break;
//	case 3:
//		sonuc = 1.18 * (obilet + mfiyat);
//        Console.WriteLine("Sayın {0} {1} Aşağıda ödeyeceğiniz tutar bulunmaktadır.", name, surname);
//		Console.WriteLine("Ara Toplam : {0}TL\nKDV Oranı : %18\nMısır Fiyatı : {1}TL\nGenel Toplam : {2}TL", obilet.ToString("0.##"), mfiyat.ToString("0.##"), sonuc.ToString("0.##"));
//        break;
//	case 4:
//        sonuc = 1.18 * (tbilet + mfiyat);
//        Console.WriteLine("Sayın {0} {1} Aşağıda ödeyeceğiniz tutar bulunmaktadır.", name, surname);
//        Console.WriteLine("Ara Toplam : {0}TL\nKDV Oranı : %18\nMısır Fiyatı : {1}TL\nGenel Toplam : {2}TL", tbilet.ToString("0.##"), mfiyat.ToString("0.##"), sonuc.ToString("0.##"));
//        break;
//	default:
//		Console.WriteLine("Yanlış İşlem Yaptınız");
//		break;
//}
//goto basla;
/*
 3 adet double işlemlerle ilgili örnek
 3 adet int işlemleri alakalı örnek
 1 adet string işlemleri ile alaklı örnek
 2 switch case örneği
 
 
 */
//Console.Write("1. metni giriniz: ");
//string metin1 = Console.ReadLine();
//Console.Write("2. metni giriniz: ");
//string metin2 = Console.ReadLine();
//Console.Write("3. metni giriniz: ");
//string metin3 = Console.ReadLine();
//string birlestirilen = metin1 + " " + metin2 + " " + metin3;
//Console.WriteLine("{0}, {1} ve {3} kelimelerinin birleştirilmiş hali: {3}", metin1, metin2, birlestirilen);
//Console.ReadKey();


#region Örnek-1 "Kullanıcıdan alınan iki sayının toplamını, farkını, çarpımını ve bölümünü hesaplama"

//double sayi1, sayi2;
//Console.WriteLine("Lütfen ilk sayıyı giriniz:");
//sayi1 = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Lütfen ikinci sayıyı giriniz:");
//sayi2 = Convert.ToDouble(Console.ReadLine());

//double toplam = sayi1 + sayi2;
//double fark = sayi1 - sayi2;
//double carpim = sayi1 * sayi2;
//double bolum = sayi1 / sayi2;

//Console.WriteLine("İki sayının toplamı: " + toplam);
//Console.WriteLine("İki sayının farkı: " + fark);
//Console.WriteLine("İki sayının çarpımı: " + carpim);
//Console.WriteLine("İki sayının bölümü: " + bolum);
#endregion


#region Örnek-2
//int x = 0;
//int y = 0;

//Console.WriteLine("X koordinatını giriniz:");
//x = int.Parse(Console.ReadLine());

//Console.WriteLine("Y koordinatını giriniz:");
//y = int.Parse(Console.ReadLine());

//Console.WriteLine("Konumunuz: (" + x + ", " + y + ")");
//#endregion

//#region Örnek-3 Ad Soyad ve tc ÖRNEĞİ
//Console.WriteLine("Adınızı giriniz:");
//string ad = Console.ReadLine();

//Console.WriteLine("Soyadınızı giriniz:");
//string soyad = Console.ReadLine();

//Console.WriteLine("TC Kimlik Numaranızı giriniz:");
//string tc = Console.ReadLine();

//Console.WriteLine("Adınız: " + ad);
//Console.WriteLine("Soyadınız: " + soyad);
//Console.WriteLine("TC Kimlik Numaranız: " + tc);
#endregion

#region Örnek -3
//Console.WriteLine("Evet mi yoksa hayır mı? (E/H)");
//string cevap = Console.ReadLine().ToUpper();

//switch (cevap)
//{
//    case "E":
//        Console.WriteLine("Evet seçildi.");
//        break;
//    case "H":
//        Console.WriteLine("Hayır seçildi.");
//        break;
//    default:
//        Console.WriteLine("Geçersiz seçim.");
//        break;
//}
#endregion

#region Örnek -4
//Console.WriteLine("Hangi ayı seçmek istersiniz? (1-12)");
//int ay = int.Parse(Console.ReadLine());

//switch (ay)
//{
//    case 1:
//        Console.WriteLine("Ocak seçildi.");
//        break;
//    case 2:
//        Console.WriteLine("Şubat seçildi.");
//        break;
//    case 3:
//        Console.WriteLine("Mart seçildi.");
//        break;
//    case 4:
//        Console.WriteLine("Nisan seçildi.");
//        break;
//    case 5:
//        Console.WriteLine("Mayıs seçildi.");
//        break;
//    case 6:
//        Console.WriteLine("Haziran seçildi.");
//        break;
//    case 7:
//        Console.WriteLine("Temmuz seçildi.");
//        break;
//    case 8:
//        Console.WriteLine("Ağustos seçildi.");
//        break;
//    case 9:
//        Console.WriteLine("Eylül seçildi.");
//        break;
//    case 10:
//        Console.WriteLine("Ekim seçildi.");
//        break;
//    case 11:
//        Console.WriteLine("Kasım seçildi.");
//        break;
//    case 12:
//        Console.WriteLine("Aralık seçildi.");
//        break;
//    default:
//        Console.WriteLine("Geçersiz ay seçimi.");
//        break;

//}
#endregion


//Console.Write("****************************************");
//Console.WriteLine();
//Console.Write("Ugulamalı koşul oyununa hoş geldiniz.");
//Console.WriteLine();
//Console.Write("****************************************");
//Console.WriteLine();
//Console.WriteLine("Lütfen adınızı soyadınızı giriniz : ");
//string nameSurname=Console.ReadLine();
//Console.WriteLine("Lütfen yaşınızı giriniz : ");

//int age = Convert.ToInt16(Console.ReadLine());
#region Yaşı 18 den büyükse kullanınıcın işlemlerin odluğu satırlar bu region blokları arasındadır.
//if (age >= 18)
//{
//    Console.Write("****************************************");
//    Console.WriteLine();
//    Console.Write("1- Korku evi oyunu\n2- Outlast\n3- Half-Life\n4-Microsoft Flight Sm\n");
//    int secim=Convert.ToInt16(Console.ReadLine());
//    Console.WriteLine();
//    Console.Write("****************************************");
//    Console.WriteLine();
//    // =>---------- Yorum Başlangıç --------- <=

//    //Buradaki secim bloğu yukardaki seçimi kapasyarak koşul ifadelerini yerine getirir.

//    // =>---------- Yorum Bitiş --------- <=
//    if (secim == 1)
//    {
//        Console.Write("****************************************");
//        Console.WriteLine();
//        Console.Write("1- Oyun başlasın mı?\n2- Oyunu iptal et\n");
//        secim = Convert.ToInt16(Console.ReadLine());
//        switch (secim)
//        {
//            case 1:
//                Console.WriteLine();
//                Console.Write("1. Kapıya gir\n2. Kapıya gir\n3.Kapıya gir.\n");
//                secim= Convert.ToInt16(Console.ReadLine());
//                Console.WriteLine();
//                if (secim == 1)
//                {
//                    Console.Write("1- Yerdeki sopayı al\n2- Oyun bitirme alanına git\n3- Oyundan çıkmayı dene");
//                    secim = Convert.ToInt16(Console.ReadLine());
//                    Console.WriteLine();
//                    switch (secim)
//                    {
//                        case 1:
//                            Console.Write("Sopa zehirliydi öldünüz.");
//                            break;
//                        case 2:
//                            Console.WriteLine("Bu kadar kolay bu oyun bitemez bölüm sonu canavarına yakalandınız ve öldünüz.");
//                            break;
//                        case 3:
//                            Console.WriteLine("Ya girdin ölmeden çıkabilir misin aslan burası kurtlar vadisi");
//                            break;
//                        default:
//                            Console.WriteLine("Bazen risk almak başarıyı getirir.");
//                            break;
//                    }
//                    break;
//                }
//                else if (secim == 2)
//                {
//                    Console.Write("Yanarak Öldünüz.");
//                    Console.WriteLine();
//                    break;
//                }
//                else if(secim == 3)
//                {
//                    Console.Write("Uçuruma denk geldiniz kapılar kapatıldı kurtuluşunuz ölümdür. İyi şanslar.");
//                    Console.WriteLine();
//                    break;
//                }
//                else
//                {
//                    Console.WriteLine("Bazen risk almak başarıyı getirir. Dediklerine bakma sen gene öldün öldün o bir kere olur bug buldun heryerde aynısı mı olacak sandın.");
//                    break;
//                }

//            case 2:
//                Console.WriteLine();
//                Console.Write("Simülasyon sona ermiştir. Game Over\n");
//                Console.WriteLine();
//                break;
//            default:
//                Console.WriteLine();
//                Console.Write("Yanlış İşlem Yaptınız");
//                break;
//        }
//    }
//}
#endregion
#region yaşı 0 dan büyük veya  17 ve veya 17den küçük olan yarışmacıların oynayacağı alan
//else if (age >= 0 || age <= 17)
//{

//}
#endregion
#region Hiçbir koşula uymayanlar için oluşturulan alan
//else
//{
//    Console.WriteLine("Hatalı yaş girdiniz oyun bitti.");
//}
#endregion
/*
 Dögü kalıpları
 For
 While
 Do While
 foreach
 Hepsindeki mantık hepsinin döngünün kendi içinde döngüyü bağlayıcı
 bir döngü koşulu olması zorunludur.
For döngüsü her zaman kendini yenileyerek giden döngüler için
kullanılır. Yani döndürüğü sonuç hiçbir zaman aynı olmaz.
while
do while
Hem kendini yenileyen hemde tekrarlayan döngüler için kullanılır.
sonuç her zaman aynı da gelebilir farklıda gelebilir. Ama bu döngülerde her zaman sabit çıktıya ihtiyacı vardır. döngü sonlanabilmesi için.
do while döngüsünün bütün döngülerden tek farkı do while döngüsünde önce işlem yapılır sonra koşul ifadesi devregirer.
foreach döngüsünde her zaman bir referansa ihtiyacı vardır. 
foreach(var item in Model)
for (var i; i<Model.Length(); i++)
do
{
  İşlem gelir.
}
while(Model.Length);
 */
//double onluk_sayi = 0;
//bool durum = true;
//Console.WriteLine("İkilik tabannda bir sayı giriniz : (11100112211) : ");
//string? ikilik_sayi = Console.ReadLine();
//for (int i = 0; i < ikilik_sayi?.Length; i++)
//{
//	if (Convert.ToDouble(ikilik_sayi.Substring(i, 1)) < 2)
//	{
//		onluk_sayi += Convert.ToDouble(ikilik_sayi.Substring(i, 1));
//	}
//	else
//	{
//		Console.WriteLine("İkilik sayı sistemi 1 ve 0 lardan oluşmaktadır.");
//		durum = false;
//	}
//}
//if (durum == true)
//{
//	Console.WriteLine(ikilik_sayi + " sayısının onluk sayı tabanındaki karşılığı : " + onluk_sayi);
//}
//for (int i = 0; i <= 200; i++)
//{
//	if (i % 3 == 0 && i % 5 == 0)
//		Console.WriteLine(i);
//}
//int taban, us, sonuc = 1;
//Console.WriteLine("Taban sayısını giriniz : ");
//taban = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Kuvvet sayısını giriniz : ");
//us = Convert.ToInt32(Console.ReadLine());
//for (int i = 0; i < us; i++)
//{
//    sonuc = sonuc * taban;
//}
//Console.WriteLine("Tabanı {0} ve kuvveti {1} olan sayının değeri = {2}", taban, us, sonuc);
//string name = "admin", password = "admin";
//int girisHakki = 3;
//for (int i = 0;i < girisHakki; i++)
//{
//	if (i < 3)
//	{
//		Console.WriteLine("Kullanıcı Adını Giriniz : ");
//		string userName = Console.ReadLine();
//        Console.WriteLine("Kullanıcı Adını Giriniz : ");
//        string userPassword = Console.ReadLine();
//		if (userName == name && password == userPassword)
//		{
//			Console.WriteLine("ID'niz {0} Kullanıcı Adınız : {1} Kullanıcı Şifreniz : {2} bilgilerinize ulaştık başarılı giriş yaptınız tebrikler", Guid.NewGuid(), name, password);
//			break;
//		}
//		else
//		{
//			Console.WriteLine("Yanlış İşlem Yaptınız.");
//		}
//    }
//	else { Console.WriteLine("İşlem hakkınız bitmiştir"); }
//}
//int sayi, hak = 5;
//bool durum = false;
//Random rnd= new Random();
//int rastgelesayi = rnd.Next(0, 100);
//for (int i = hak; i > 0; i--)
//{
//    Console.WriteLine("Hakkınız : {0}", i);
//    Console.WriteLine("Tahmininiz : ");
//    sayi=int.Parse(Console.ReadLine());
//    if (sayi == rastgelesayi)
//    {
//        Console.WriteLine("Full zararsın. Sözde kasa kazanır diyorlardı hep sen kazanıyorsun.");
//        durum= true;
//        break;
//    }
//}
//if (!durum || durum == false)
//{
//    Console.WriteLine("Tekrar Deneyiniz.");
//    Console.WriteLine("Sayi : {0}", rastgelesayi);
//}
//int sayi = 30, toplam = 0;
//while (sayi >= 0)
//{
//    Console.WriteLine("Bir sayı giriniz : ");
//    sayi = Convert.ToInt32(Console.ReadLine());
//    if (sayi > 0)
//    {
//        toplam += sayi;
//    }
//}
//Console.WriteLine("Girdiğiniz sayıların Toplamı = {0}", toplam);
//int tahmin = 0, tutulan, sayac = 0;
//Random rastgele=new Random();
//tutulan = rastgele.Next(0, 10);
//while (tahmin != tutulan)
//{
//    sayac++;
//    Console.WriteLine("Bir sayı giriniz");
//    tahmin=Convert.ToInt32(Console.ReadLine());
//    if (tahmin > tutulan)
//    {
//        Console.WriteLine("Sayıyı Küçült");
//    }
//    else if (tahmin < tutulan)
//    {
//        Console.WriteLine("Sayıyı Büyült");
//    }
//}
//Console.WriteLine("Tebrikler sayıyı bildiniz sayınız : {0}", tahmin);
//Console.WriteLine("{0}. hakkınızda bildiniz. ",sayac);
/*
 tahmin=0 tutulan sayac=0
 Random rastgele=random
tutulan=rastgele
döngü eğer ki tahminle tutlan esit değilse
döngü devam edecek
tutaln tahmin esitse ekrana 
tutulan sayı ve kacınca bildiği cıkacak 
 */
//double bakiyemiz = 0, miktar=0;
//int secim = 0;
//while (secim == 0 || secim > 0 || secim != 5 || secim < 5) 
//{
//    Console.WriteLine("*****************************");
//    Console.WriteLine("Tosun Bank'a hoşgeldiniz.");
//    Console.WriteLine("*****************************");
//    Console.WriteLine("Sayın Yetkili Bakiyeniz {0} TL'dir", bakiyemiz);
//    Console.WriteLine("1- Para Çekme\n2- Para Yükleme\n3- Hesap Bakiyesi\n4 Fatura Ödeme\n(0 || 5) - Çıkış Yap");
//    secim=Convert.ToInt32(Console.ReadLine());
//    switch (secim)
//    {
//        case 1:
//            Console.WriteLine("Çekeceğiniz Miktarı giriniz : ");
//            miktar = Convert.ToDouble(Console.ReadLine());

//            if (bakiyemiz - miktar <= 0)
//            {
//                Console.WriteLine("Allah'ın fakiri git önce para yatır!");
//                break;
//            }
//            else
//            {
//                bakiyemiz = bakiyemiz - miktar;
//                Console.WriteLine("Çektiğiniz Miktar {0}TL\nKalan Bakiyeniz {1}TL", miktar, bakiyemiz);
//                Console.Clear();
//                break;
//            }

//        case 2:
//            Console.WriteLine("Lütfen yüklemek istediğiniz tutarı giriniz : ");
//            miktar = Convert.ToDouble(Console.ReadLine());
//            bakiyemiz += miktar;
//            Console.Clear();
//            break;
//        case 3:
//            Console.WriteLine("Hesabınızda {0}TL Bakiye Bulunmaktadır.", bakiyemiz);
//            Console.Clear();
//            break;
//        case 4:
//            Console.WriteLine("Fatura ödeyeceğiniz Tutar  : ");
//            miktar = Convert.ToDouble(Console.ReadLine());

//            if (bakiyemiz <= 0)
//            {
//                Console.WriteLine("Allah'ın fakiri git önce para yatır!");
//            }
//            else
//            {
//                bakiyemiz = bakiyemiz - miktar;
//                Console.WriteLine("Fatura ödedikten sonra fatura tutarınız {0}TL\nKalan Bakiyeniz {1}TL", miktar, bakiyemiz);
//            }
//            Console.Clear();
//            break;
//        default:
//            break;
//    }
//}
#endregion
#region Başlangıç Örnekleri
//Console.WriteLine("Bu Bir Deneme Yazısıdır");
//Console.WriteLine("Bu bir ikinci deneme yazısıdır");

//Console.Write("Bu Bir Deneme Yazısıdır");
//Console.Write("Bu bir ikinci deneme yazısıdır");
// Varsayılan Değer Atama
//string metin = "Bu bir metindir";
//Console.Write(metin);
//Console.WriteLine("Bir Yazı giriniz : ");
//string metinler=Console.ReadLine();
//Console.WriteLine(metinler);
//Console.WriteLine("Bir Sayı giriniz : ");
//int sayilar = Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Girdiğiniz sayı : " + sayilar);
//int sayi = 25;
//char karekter = 'A';
//string ad, soyad;
//int yas;
//decimal geliri;
//float boy;
//Console.Write("Adınızı Girinz : ");
//ad=Console.ReadLine();
//Console.WriteLine();
//Console.Write("Soyadınızı Giriniz : ");
//soyad=Console.ReadLine();
//Console.WriteLine();
//Console.Write("Yaşınızı Giriniz : ");
//yas = Convert.ToUInt16(Console.ReadLine());
//Console.WriteLine();
//Console.Write("Gelirinizi Giriniz : ");
//geliri = Convert.ToDecimal(Console.ReadLine());
//Console.WriteLine();
//Console.WriteLine("Lütfen Boyunuzu Giriniz : ");
//boy = float.Parse(Console.ReadLine());
//Console.Clear();
//Console.WriteLine("Adınız Soyadınız : {0} {1}\nYaşınız : {2}\nGelirinizi : {3}\nBoyunuz : {4}", ad, soyad, yas, geliri, boy);

//int yas;
//Console.WriteLine("Lütfen Yaşınızı Giriniz : ");
//yas = int.Parse(Console.ReadLine());
//if (yas > 0 && yas >= 18)
//{
//    Console.WriteLine("Ehliyet sınavına katılabilirsiniz.");
//}
//else if (yas > 0 && yas < 18)
//{
//    Console.WriteLine("Ehliyet sınavına katılamazsınız.");
//}
//else
//{
//    Console.WriteLine("Yanlış İşlem Yaptınız");
//}
//switch (yas)
//{
//    case > 17:
//        Console.WriteLine("Ehliyet Alabilirsiniz");
//        break;
//    case > 0:
//        Console.WriteLine("Ehliyeti bu koşulda da alamazsınız");
//        break;
//    default:
//        Console.WriteLine("Yanlış Yaptınız");
//        break;
//}


//int secim;
//Console.WriteLine("1 ile 12 sayıları arasında değer giriniz. Girdiğiniz değere karşılık size hangi ay olduğunu vereceğiz : ");
//secim = Convert.ToInt32(Console.ReadLine());
//if (secim == 1)
//    Console.WriteLine("Ocak Ayını Seçtiniz");
//else if (secim == 2)
//    Console.WriteLine("Şubat Ayını Seçtiniz");
//else if (secim == 3)
//    Console.WriteLine("Mart Ayını Seçtiniz");
//else if (secim == 4)
//    Console.WriteLine("Nisan Ayını Seçtiniz");
//else if (secim == 5)
//    Console.WriteLine("Mayıs Ayını Seçtiniz");
//else if (secim == 6)
//    Console.WriteLine("Haziran Ayını Seçtiniz");
//else if (secim == 7)
//    Console.WriteLine("Temmuz Ayını Seçtiniz");
//else if (secim == 8)
//    Console.WriteLine("Ağustos Ayını Seçtiniz");
//else if (secim == 9)
//    Console.WriteLine("Eylül Ayını Seçtiniz");
//else if (secim == 10)
//    Console.WriteLine("Ekim Ayını Seçtiniz");
//else if (secim == 11)
//    Console.WriteLine("Kasım Ayını Seçtiniz");
//else if (secim == 12)
//    Console.WriteLine("Aralık Ayını Seçtiniz");
//else
//    Console.Write("Yanlış İşlem Yaptınız");
//switch (secim)
//{
//    case 1:
//        Console.WriteLine("Ocak Ayını Seçtiniz");
//        break;
//    case 2:
//        Console.WriteLine("Şubat Ayını Seçtiniz");
//        break;
//    case 3:
//        Console.WriteLine("Mart Ayını Seçtiniz");
//        break;
//    case 4:
//        Console.WriteLine("Nisan Ayını Seçtiniz");
//        break;
//    case 5:
//        Console.WriteLine("Mayıs Ayını Seçtiniz");
//        break;
//    case 6:
//        Console.WriteLine("Haziran Ayını Seçtiniz");
//        break;
//    case 7:
//        Console.WriteLine("Temmuz Ayını Seçtiniz");
//        break;
//    case 8:
//        Console.WriteLine("Ağustos Ayını Seçtiniz");
//        break;
//    case 9:
//        Console.WriteLine("Eylül Ayını Seçtiniz");
//        break;
//    case 10:
//        Console.WriteLine("Ekim Ayını Seçtiniz");
//        break;
//    case 11:
//        Console.WriteLine("Kasım Ayını Seçtiniz");
//        break;
//    case 12:
//        Console.WriteLine("Aralık Ayını Seçtiniz");
//        break;
//    default:
//        Console.Write("Yanlış İşlem Yaptınız");
//        break;
//}
//int toplam = 0;
//for (int i = 0; i <= 5; i++)
//{
//	toplam = toplam + i;
//	Console.WriteLine(toplam);
//}
//int sayac = 0;
//for (int i = 0; i < 50; i++)
//{
//	if (i % 3 == 0 && i % 5 == 0)
//	{
//		Console.WriteLine("Koşul Sağlanan Sayı : " + i);
//		sayac++;
//	}
//}
//Console.WriteLine("Toplam Döngü içindeki koşulu sağlayan sayı : " + sayac);
//Console.WriteLine("Yksekliği Giriniz : ");
//int yukseklik=Convert.ToInt32(Console.ReadLine());
//Console.WriteLine("Genişliği Giriniz : ");
//int genislik=Convert.ToInt32(Console.ReadLine());
//for(int i = 1; i <= yukseklik; i++)
//{
//	for (int j = 1; j <= genislik; j++)
//	{
//		if(i==1 || i == yukseklik)
//		{
//			Console.Write("*");
//		}
//		else
//		{ Console.Write(""); }
//	}
//	Console.WriteLine();
//}
//string metin;
//Console.WriteLine("Bir Metin Giriniz : ");
//metin =Console.ReadLine();
//int sayac = 0;
//for (int i = 0; i<metin.Length; i++)
//{
//	if (metin[i] == 'a')
//	{
//		sayac++; 
//	}
//}
//Console.WriteLine("Girilen Metindeki a adeti : {0}", sayac);

//Console.WriteLine("Döngü limiti giriniz : ");
//int donguLimit = Convert.ToInt32(Console.ReadLine());
//double sayi, toplam = 0;
//for (int i = 1; i <= donguLimit; i++)
//{
//	// Sayı isteyeceksiniz
//	Console.WriteLine("Sayıyı giriniz : ");
//	//Gelen sayıyı sayi atayacaksın
//	sayi= Convert.ToDouble(Console.ReadLine());
//	//formül toplam=((sayi*20)/100)+sayi;
//	toplam = sayi * 20 / 100 + sayi;
//	//Formül 2 toplam = sayi * 120 / 100;
//	//toplam = sayi * 120 / 100;
//	//Formüle ekrana yazdıracaksınız
//	Console.WriteLine(toplam);
//}
#endregion
#region  Döngüler
/*
 For (int a = 0; a<=10; a++)
 while(a<=10)
 do while (a<=10)
 foreach
 */

//char karekter;
//for (karekter ='a';  karekter <='z'; karekter++)
//{
//	Console.Write(karekter + "\n");

//}
#endregion
#region Koşullar
/*
 * 
 * if else koşullarında koşullarda program gezerken
 * koşul sağlamasa bile kpşula uğrayarak hareket eder
 * if else if else 
 */
#endregion

/*
 *  Stringteki a harfinin metinde kaç kere geçtiğini bulan programı yazınız.
 */

#region Son For Döngü Örneği
//int ts=0, cs=0;
//for (int i = 1; i <= 100; i++)
//{
//	if (i % 2 == 0)
//	{
//		cs++;
//	}
//	else
//	{
//		ts++;
//	}
//}
//Console.WriteLine(ts);
//// ts adeti
//Console.WriteLine(cs);
//// cs Adeti ekrana yazdırılacak.
#endregion
#region While
//int toplam = 0;
//int x = 1;
//while (x <= 10) 
//{
//    //Console.WriteLine("Toplam = " + toplam + ("+") + x);
//    //Console.WriteLine($"Toplam = {toplam} + {x}");
//    Console.WriteLine("Toplamları değer : {0}+{1}={2}", toplam, x, toplam+x);
//    toplam =toplam + x;
//    x++;
//}
///// toplam = toplam+x; 
//Console.WriteLine("Genel Toplam : " + toplam);
//Random rnd = new Random();
//int tahmin = 0, tutulan, sayac = 0;
//tutulan = rnd.Next(1, 10);
//while (tahmin != tutulan)
//{
//    sayac++;
//    Console.WriteLine("Sayı Giriniz : ");
//    tahmin=Convert.ToInt32(Console.ReadLine());
//    if (tahmin > tutulan)
//    {
//        Console.WriteLine("Sayıyı Küçült");
//    }
//    else if (tahmin < tutulan)
//    {
//        Console.WriteLine("Sayıyı Büyült");
//    }
//}
//Console.WriteLine("{0}. hakkınızda bildiniz.", sayac);
//Console.WriteLine("Tebrikler Bildiniz");

//bool durum = true;
//int? sayi = null;
//while (durum!=true)
//{
//	if (sayi % 5 == 0 && sayi % 7 == 0)//sayi % 5 ==0  sayi & 7==0
//	{
//		durum = true;
//	}
//	else
//	{
//		durum = false;
//	}
//}
//while (sayi % 5 != 0 && sayi % 7 != 0)
//{

//}

/*
 Bir kahve makinemiz var bu kahve makinesinde
 Seçim yaptıracağız.
 Çay,Kahve,Americano,Türk Kahvesi
 Kahve Alırken Bakiye 0 sa hata verecek
 Kahve Tutarları Çay = 20 Filtre Kahve=90 Americano =15 Türk Kahvesi = 200
 */
//int bakiye = 0;
//bool x = true;


//while (x == true)
//{
//    Console.WriteLine($"Seçim yapınız \n1-)çay=20TL \n2-)filtre kahve=90TL \n3-)americano=15TL \n4-)türk kahvesi=200TL \n5-)Bakiye Yükle Mevcut Bakiyeniz : {bakiye} TL\n6-)Çıkış Yap");
//    int seçim = Convert.ToInt32(Console.ReadLine());
//    switch (seçim)
//    {
//        case 1:
//            if (bakiye >= 20)
//            {
//                Console.WriteLine("Çay İstediniz Afiyet Olsun.");
//                bakiye -= 20;
//            }
//            else
//            {
//                Console.WriteLine("Bakiye Yetersiz bakiye yükleyiniz");
//            }
//            break;
//        case 2:
//            if (bakiye >= 90)
//            {
//                Console.WriteLine("filtre kahve İstediniz Afiyet Olsun.");
//                bakiye -= 90;
//            }
//            else
//            {
//                Console.WriteLine("Bakiye Yetersiz bakiye yükleyiniz");
//            }
//            break;
//        case 3:
//            if (bakiye >= 15)
//            {
//                Console.WriteLine("Americano İstediniz Afiyet Olsun.");
//                bakiye -= 15;
//            }
//            else
//            {
//                Console.WriteLine("Bakiye Yetersiz bakiye yükleyiniz");
//            }
//            break;
//        case 4:
//            if (bakiye >= 200)
//            {
//                Console.WriteLine("Türk Kahvesi İstediniz Afiyet Olsun.");
//                bakiye -= 200;
//            }
//            else
//            {
//                Console.WriteLine("Bakiye Yetersiz bakiye yükleyiniz");
//            }
//            break;
//        case 5:
//            Console.WriteLine("yükleyeceğiniz bakiye tutarını giriniz");
//            int yüklenenbakiye = Convert.ToInt32(Console.ReadLine());
//            bakiye = yüklenenbakiye;
//            break;
//        case 6:
//            x = false;
//            break;
//        default:
//            Console.WriteLine("yanlış değer girdiniz.");
//            break;
//    }
//}
#endregion
#region Do While
// Tanımlamalar olacak.
//Console.Write("Bir tek sayı giriniz : ");
//int a = Convert.ToInt32(Console.ReadLine());
//do
//{
//    // Koşuldaki işlemler burada yapılacak.
//    Console.WriteLine(a);
//    a += 2;

//} while (a <= 100); //  koşul buraya yazılacak.
//int wholeNumber = 1, total = 0;
//do
//{
//    Console.Write("{0}+{1}", total, wholeNumber);
//    total += wholeNumber;
//    wholeNumber++;
//    Console.Write("={0}\n",total);
//} while (wholeNumber<=100);




/*
 Bir Vize Final ve Proje NNotlarının ortalamasını alacak uygulama yazacaksınız
 il açacağınız döngü for oda ne kadar öğrenci o kadar not girelecek
 ikinci açılacak döngü ne kadar vize ve final  not ortalaması belirlenecek.
 son do while da kaç kıişi kaç kişi geçti bunun bilgisini yazcak uygulamayı yazınız.
 
 */
// Seçim Yapıldı
//for (int i = 0; i <= amount; i++)
//{
//    string vmetot = "";
//    string fmetot = "";
//    string pmetot = "";
//    while  (i<=amount)
//    {
//        vmetot.Trim(",")
//    }
//}

/*
 * tip[] sequence;
 */
//int[] dizi; // Buradaki dizinin boyutu belli değildir
//// dizi eklendiği eleman kadar dizi boyutunu oluşturur.
//string[] sdizi; // Buradaki dizinin boyutu belli değildir
//// dizi eklendiği eleman kadar dizi boyutunu oluşturur.
//int[] bdizi=new int[100]; // Dizi Boyutu Bellidir.
//// Belirlenen Dizi kadar alan kaplar.
////1,2,3,4,5,6,7,8,9,0,null,null,null
//string[] Names = { "Ali", "Ahmet", "Mehmet", "Cengiz" };
//int[] wholeNumber2 = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 };
//int available = 0;
//Console.WriteLine("Sınıf Mevcudu Giriniz : ");
//available = Convert.ToInt32(Console.ReadLine());
//string[] studentClass = new string[available];
//for (int i = 0;i < available; i++)
//{
//    Console.WriteLine("Öğrenci Adını Giriniz : ");
//    studentClass[i] = Console.ReadLine();
//}
/*
  Döngü başlıyr döngünün başlangı sayısı 0 dan başlıyor 
  kullanıcıdan girilen mevcut kadar gidiyor.
  Kullanıcıdan girilecek olan mevcut kadar öğrenci bilgilerini istiyoruz.
  Her girilen öğrenci değerleri örnek
  [i] = Dizideki 0'ncı eleman = Haşmet Tazegül
  [i] = Dizideki 1'nci eleman = Ferhat Aydın
  [i] = Dizideki 2'nci eleman = Umut Türk
  Buradaki bahsi geçen i hem döngünün mevcuta yaklaştığı değeri hem de
  diziye eklenen elamının dizideki kaçıncı elemana denk geldiğini gösteriyor.
 */

//Console.Clear(); // Consol ekranını temizlemek için kullanırız.
//for (int i = 0; i < studentClass.Length; i++)
//{
//    Console.WriteLine("Öğreci Adı Soyadı" + studentClass[i]);
//}
//foreach (var item in studentClass)
//// var bir değişten türüdür
//// tip olarak ta değer olarakta sürekli değişkenlik gösterir.
//// ortamların kaypak delikanlısı.
//// in içinde demek.
//// model kapsayıcıı studentClasstır.
//// foreach döngüsü modeli referans alarak döngü oluşturur.

//{
//    Console.WriteLine("Öğrencinin Adı Soyadı : " + item);
//    // item ana referanstan aldığı tek değeri her döngü değiştiğinde ekrana yazarak bir alt satıra iner.
//}
//int pozitif = 0;
//int negatif = 0;
//int notr = 0;
//Random rnd=new Random();
//int[] sayilar = new int[20];
//for (int i = 0;i < 20; i++)
//{
//    sayilar[i] = rnd.Next(-100, 100);
//}
//foreach (var item in sayilar)
//{
//    Console.WriteLine(item);
//    if (item > 0)
//    {
//        pozitif++;
//    }
//    else if (item < 0)
//    {
//        negatif++;
//    }
//    else
//    {
//        notr++;
//    }
//}
//Console.WriteLine("Pozitif Sayı Adeti : " + pozitif);
//Console.WriteLine("Negatif Sayı Adeti : " + negatif);
//Console.WriteLine("Notr Sayı Adeti : " + notr);
//using System.Collections;
//int[] myArray = new int[] { 1,2,3,4,5 };
//int elemansayisi = myArray.Length;
//Console.WriteLine("Değer Ataması Yapınız");
//int sayi =int.Parse(Console.ReadLine());
//if (elemansayisi!=0)
//{
//    myArray[elemansayisi - 1] = sayi;
//}
//else
//{
//    myArray[elemansayisi] = sayi;
//}
//foreach (var item in myArray)
//{
//    Console.WriteLine(item);
//}
//int rehberMevcut = 0, secim = 0;

//Console.WriteLine("Kaç Kişi Ekleyeceksiniz ?");
//rehberMevcut = int.Parse(Console.ReadLine());
//string[] numaralar = new string[rehberMevcut];
//string[] kisiler = new string[rehberMevcut];
//string[] butunDizi = new string[rehberMevcut];

//basla:
//Console.WriteLine("1-) Kişi Ekle");
//Console.WriteLine("2-) Kişi Listele");
//secim = int.Parse(Console.ReadLine());
//switch (secim)
//{
//    case 1:
//        for (int i = 0; i < rehberMevcut; i++)
//        {

//            Console.WriteLine("Ad Soyad : ");
//            string name = Console.ReadLine();
//            Console.WriteLine("Telefon Numarası : ");
//            string number = Console.ReadLine();
//            kisiler[i] = name;
//            numaralar[i] = number;
//            butunDizi[i] = name + " " + number;
//            Console.Clear();
//        }
//        goto basla;
//     case 2:
//        for (int i = 0; i < kisiler.Length; i++)
//        {
//            Console.WriteLine("Ad Soyad: {0} - Numara: {1}", kisiler[i], numaralar[i]);
//        }
//        foreach (var item in butunDizi)
//        {
//            Console.WriteLine("Ad Soyad Numara : {0} ", item);
//        }
//        break;
//    default:
//        break;
//}

//string[] ogrno = { "101", "102", "103", "104", "105", "106", "107", "108", "109", "110" };
//string[] isim = { "Ali", "Veli", "Hasan", "Kemal", "Can", "Ahmet", "Mehmet", "Enis", "Bilal", "Burak" };
//string[] telefon = { "111", "222", "333", "444", "555", "666", "777", "888", "999", "1000" };
//string[] mail = { "aaaa@aaa.aa", "bbbbb@bbb.bb", "cccc@ccc.cc", "dddd@ddd.dd", "eeee@eee.ee", "ffff@eee.ee", "gggg@eee.ee", "hhhh" };
//Console.WriteLine("Kişi No'yu Giriniz : ");
//string aranan = Console.ReadLine();
//int no = Array.IndexOf(ogrno, aranan);
//isim[no] = null;
//Console.WriteLine("Aranan Kişi {0}\nTelefonu:{1}\nEmail{2}", isim[no], telefon[no], mail[no]);
//int ogrnosayisi = ogrno.Length;
//// ArrayList
//ArrayList list = new ArrayList();

//// List
//List<string> liste = new List<string>();

//int rehberMevcut = 0, secim = 0;

//Console.WriteLine("Kaç Kişi Ekleyeceksiniz ?");


//rehberMevcut = int.Parse(Console.ReadLine());
//string[] numaralar = new string[rehberMevcut];
//string[] kisiler = new string[rehberMevcut];

//basla:
//Console.WriteLine("1-) Kişi Ekle");
//Console.WriteLine("2-) Kişi Listele");
//Console.WriteLine("3-) Kişi Güncelle");
//secim = int.Parse(Console.ReadLine());
//switch (secim)
//{
//    case 1:

//        for (int i = 0; i < rehberMevcut; i++)
//        {

//            Console.WriteLine("Ad Soyad : ");
//            string name = Console.ReadLine();
//            Console.WriteLine("Telefon Numarası : ");
//            string number = Console.ReadLine();

//            kisiler[i] = name;
//            numaralar[i] = number;
//            Console.Clear();
//        }
//        goto basla;
//        break;
//    case 2:

//        foreach (var item in kisiler.Select((value, i) => new { value, i }))
//        {
//            Console.WriteLine("Ad Soyad: {0} - Numara: {1}", item.value, numaralar[item.i]);
//        }
//        break;
//    case 3:
//        for (int i = 0; i < kisiler.Length; i++)
//        {
//            Console.WriteLine("{0} -) {1} {2}", i, kisiler[i], numaralar[i]);

//        }
//        Console.WriteLine("Hangi kişiyi güncellemek istiyorsunuz ?\n\nÇıkış ypamak için 'çıkış' Yazınız");
//        string kisiSecim = Console.ReadLine();
//        if (kisiSecim == "çıkış")
//        {
//            goto basla;
//        }
//        else
//        {

//            int kisiSecim2 = Convert.ToInt32(kisiSecim);

//            Console.WriteLine("Yeni Ad: ");
//            string newName = Console.ReadLine();
//            Console.WriteLine("Yeni Numara: ");
//            string newPhone = Console.ReadLine();



//            kisiler[kisiSecim2] = newName;
//            numaralar[kisiSecim2] = newPhone;

//            Console.Clear();
//            Console.WriteLine("Güncelleme işlemi başarılı!");
//            goto basla;
//        }

//    default:
//        break;
//}
//decimal bakiye = 0;
//int girisHak = 3;
//string[] menu ={"Cola","Karemel Frapp" };
//decimal[] fiyat ={20,65 };
//int secim;
//int menuSayisi = menu.Length;
//int fiyatSayisi = menu.Length;
//string userName="admin", password="admin";
//Console.WriteLine("1Admin Giriş\n2-Müşteri Giriş : ");
//secim=int.Parse(Console.ReadLine());
//if (secim == 1)
//{
//	for (int i = 0; i < girisHak; i++)
//	{
//		Console.WriteLine("Kullanıcı Adınız : ");
//		string user=Console.ReadLine();
//		Console.WriteLine("Şifreniz : ");
//		string pass=Console.ReadLine();
//		if (userName == user && password == pass)
//		{
//			Basla:
//			Console.WriteLine("1- Ürün Ekle\n2- Ürün Düzenle\n3- Ürun Listele\n0- Çıkış Yap");
//			secim = int.Parse(Console.ReadLine());
//			switch (secim)
//			{
//				case 1:
//					Array.Resize(ref menu, 3);
//					Console.WriteLine("Ürün Adını Giriniz : ");
//					string deger=Console.ReadLine();
//					menu[menu.Length - 1] = deger;
//					Array.Resize(ref fiyat, 3);
//                    Console.WriteLine("Ürün Fiyatını Giriniz : ");
//					decimal pdeger=decimal.Parse(Console.ReadLine());
//					fiyat[fiyat.Length - 1] = pdeger;
//					goto Basla;
//				case 2:
//					for (int x = 0; x < menu.Length; x++)
//					{
//						Console.WriteLine("Menu Numarası {0}\t Ürün Adı : {1}", x, menu[i]);
//					}
//					int secim2 = int.Parse(Console.ReadLine());
//					Console.WriteLine("Güncellenen Ürün Adı : ");
//					menu[secim2] = Console.ReadLine();
//					Console.WriteLine("Güncellenen Ürün Fiyatı : ");
//					fiyat[secim2] =decimal.Parse(Console.ReadLine());
//					goto Basla;
//				case 3:
//                    for (int x = 0; x < menu.Length; x++)
//                    {
//                        Console.WriteLine("Menu Numarası {0}\t Ürün Adı : {1}\t Ürün Fiyatı {2}TL", x, menu[x], fiyat[x]);
//                    }
//                    goto Basla;
//				case 0:
//					break;
//				default:
//					break;
//			}
//		}
//	}
//	Console.WriteLine("Yanlış İşlem Yaptınız.");
//}
//else
//{

//}
#endregion
#region Dizi Tanımlamaları
/*
 Değişken Tipli Dizi tanımlamalarında
 Dizide değişken tipi zorunlulu olduğu gibi
 Dizinin boyutuda zorunludur.
 Default Tanımlamalı dizilerde Varsayılan atamalarla
 Dizi oluşturulduğunda yeni ekleme yapmak için
 Yeniden Dizi Boyutlandırıılması yapılmak zorundadır.
 Aynı zamanda dizilerde silme işlemi yerine değeri
 null değerine atama işlemi yapılır.
 */
//string[] dizi = new string[] {"Pop Kek","Instense","Eti Cin" };
//Array.Resize(ref dizi, 4);
//Console.WriteLine("Lütfen Ürün Giriniz : ");
//string deger = Console.ReadLine();
//dizi[dizi.Length - 1] = deger;
//Console.Clear();
//for (int i = 0; i < dizi.Length; i++)
//{
//    Console.WriteLine(dizi[i]);
//}
#region Çok Boyutlu Diziler
using System.Collections;

//string[,] dizi2;
//dizi2 = new string[,] 
//{ 
//    { "a", "1", }, 
//    { "b", "2", }, 
//    { "c", "3" }, 
//    { "d", "4" }
//};
//string[,] dizi3;
//dizi3 = new string[,]
//{
//    { "a", "1","2" },
//    { "b", "2","3" },
//    { "c", "3","4" },
//    { "d", "4","5" }
//};
//Console.WriteLine(dizi2[0, 0] +","+dizi2[0, 1]);
//Console.WriteLine(dizi2[1, 0] + "," + dizi2[1, 1]);
//Console.WriteLine(dizi2[2, 0] + "," + dizi2[2, 1]);
//Console.WriteLine(dizi2[3, 0] + "," + dizi2[3,1]);
//Console.WriteLine(dizi2[4, 0] + "," + dizi2[4, 1]);
//int[,] dizi = new int[3,3];
//Random rnd=new Random();
//for (int i = 0; i < 3; i++)
//{
//	for (int j = 0; j < 3; j++)
//	{
//		dizi[i, j] = rnd.Next(10);
//		Console.Write(dizi[i, j] + " ");
//	}
//	Console.WriteLine();
//}
//for (int n = 0; n < 3; n++)
//{
//	int sutun_toplam = 0;
//	int satir_toplam = 0;
//	for (int a = 0; a < 3; a++)
//	{
//		satir_toplam += dizi[n, a];
//		sutun_toplam += dizi[a, n];
//	}
//	Console.WriteLine("{0}Satırın Toplamı\t:{1}\t\t{2} Sütunun Toplamı\t: {3}", (n + 1), satir_toplam, (n + 1), sutun_toplam);
//    Console.WriteLine("{0}Satırın Ortalama\t:{1}\t\t{2} Sütunun Ortalama\t: {3}", (n + 1), satir_toplam/3, (n + 1), sutun_toplam/3);
//}
#endregion

ArrayList list = new ArrayList();
/*
 * ArrayList dizileri boyut sınırladırılması yoktur.
 * Ekleme Güncelleme Silme İşlemleri Yapılır.
 * Aynı zamanda da  Ekleme yapmak için değişken tipli dizilerdeki gibi yeniden boyutlandırma yapmamıza gerek
 * yok.
 */
//list.Add("Ahmet");
//list.Add(123456);
//list.Add(true);
//foreach (var item in list)
//{
//    Console.WriteLine(item);
//}


/*
 * Random bir  değer oluşturacağız oluşan her bir sayı
 * 50 küçükse
 * kucuksayılar Array'a atılacak
 * 50'den büyüksede
 * Büyük Sayılar Array'a eklenecek.
 * İki Array'ide ekrana yazdıracağız.
 * 2- Forunda dönme değeri 15
 */

//ArrayList k=new ArrayList();
//ArrayList b=new ArrayList();
//Random rnd = new Random();
//for (int i = 0; i <= 15; i++)
//{
//    int sayi = rnd.Next(49);
//    k.Add(sayi);
//}
//for (int i = 0; i <= 15; i++)
//{
//    int sayi = rnd.Next(51, 100);
//    b.Add(sayi);
//}
//foreach (var item in k)
//{
//    Console.WriteLine("Küçük Sayılar : "+ item);
//}
//Console.WriteLine("************************************");
//foreach (var item in b)
//{
//    Console.WriteLine("Büyük Sayılar : " + item);
//}

//char secim;
//ArrayList Personel = new ArrayList();
//Console.BackgroundColor= ConsoleColor.Green;
//Console.Clear();
//Console.Title = "INFOTECH ACADEMY MCSD EĞİTİMİ";
//Console.WriteLine("=================================================");
//Console.WriteLine("Infotech Academy Otomasyonuna Hoş Geldiniz");
//Console.WriteLine("=================================================");
//Console.WriteLine("1-) Personel Ekle\n2-) Personel Güncelle\n3-) Personel Listele\n4-) Personel Sil\n5-)Çoklu Personel Ekle");
//secim=char.Parse(Console.ReadLine());
//switch (secim)
//{
//	case '1':
//		Console.WriteLine("Lütfen Persone Adını Giriniz : ");
//		Personel.Add(Console.ReadLine());
//		break;
//	case '2':
//		Console.WriteLine("Personel Listesinden lütfen güncellemek istediğiniz kişiyi yada veriyi seçiniz: ");
//		int pSecim = Convert.ToInt32(Console.ReadLine());
//		Console.WriteLine("Yeni Değer Giriniz : ");
//		Personel[pSecim]= Console.ReadLine();
//		break;
//	case '3':
//		foreach (var item in Personel)
//		{
//			Console.WriteLine(item);
//		}
//		break;
//	case '4':
//        Console.WriteLine("Personel Listesinden lütfen silmek istediğiniz kişiyi yada veriyi seçiniz: ");
//        int pSecim2 = Convert.ToInt32(Console.ReadLine());
//		Personel.RemoveAt(pSecim2);
//		Console.WriteLine("Personel Silindi");
//        break;
//	default:
//		break;
//}
#endregion
#region Ferhat Aydın
//char secim;
//string cizgi = "=============================================";
//ArrayList personelList = new ArrayList();
//Console.Clear(); // program her başladığında konsol sıfırlanıyor
//Console.Title = "INFOTECH ACADMEY MCSD EĞİTİMİ";
//Console.WriteLine(cizgi);
//Console.WriteLine("Infotech Academy Otomasyonuna Hoş Geldiniz");
//Console.WriteLine(cizgi);
//basla:
//Console.WriteLine("1-) Personel Ekle\n2-) Personel Güncelle\n3-) Personel Listele\n4-) Personel Sil\n5-) Çoklu Personel Ekle");
//secim = char.Parse(Console.ReadLine());

//switch (secim)
//{

//    case '1':
//        Console.WriteLine("Lütfen Personel Adı Giriniz : ");
//        string personelName = Console.ReadLine();
//        personelList.Add(personelName);
//        Console.Clear();
//        Console.WriteLine(cizgi);
//        Console.WriteLine("{0} isminde personel listeye eklendi!", personelName);
//        Console.WriteLine(cizgi);
//        goto basla;
//    case '2':
//    personelGuncelleme:
//        if (personelList.Count <= 0)
//        {
//            Console.Clear();
//            Console.WriteLine(cizgi);
//            Console.WriteLine("Peronel Listesi Boş Olduğu İçin Güncelleme Yapılamadı!");
//            Console.WriteLine(cizgi);
//            goto basla;
//        } // Veri tabanında eğer veri yoksa başlangıç ekranına geri dön
//        for (int i = 0; i < personelList.Count; i++)
//        {
//            Console.WriteLine("{0}. {1}", i, personelList[i]);
//        }

//        Console.WriteLine("Lütfen güncellemek istediğiniz personelin numarasını giriniz.");

//        int pSecim = int.Parse(Console.ReadLine());

//        var personel = personelList[pSecim];
//        if (personel != null)
//        {
//            string newPersonelName = Console.ReadLine();
//            personelList[pSecim] = newPersonelName;
//            Console.Clear();
//            Console.WriteLine(cizgi);
//            Console.WriteLine("Başarılı bir şekilde {0} isimli personelin adını {1} olarak güncellediniz.", personel, newPersonelName);
//            Console.WriteLine(cizgi);
//            goto basla;
//        }
//        else
//        {
//            Console.Clear();
//            Console.WriteLine(cizgi);
//            Console.WriteLine("Güncellemek istediğiniz personel bulunamadı lütfen tekrar seçiniz!");
//            Console.WriteLine(cizgi);
//            goto personelGuncelleme; // eğer veri yanlış girildiyse veriyi tekrardan girmeisini istiyoruz
//        }
//    case '3':
//        if (personelList.Count <= 0)
//        {
//            Console.Clear();
//            Console.WriteLine(cizgi);
//            Console.WriteLine("Peronel Listesi Boş Olduğu İçin Listeleme Yapılamadı!");
//            Console.WriteLine(cizgi);
//            goto basla;
//        } // Veri tabanında eğer veri yoksa başlangıç ekranına geri dön
//        for (int i = 0; i < personelList.Count; i++) // personel listesini çağırıyoruz
//        {
//            Console.WriteLine("{0}. {1}", i, personelList[i]);
//        }
//        goto basla;
//    case '4':
//    personelSil:
//        if (personelList.Count <= 0)
//        {
//            Console.Clear();
//            Console.WriteLine(cizgi);
//            Console.WriteLine("Peronel Listesi Boş Olduğu İçin Silme Yapılamadı!");
//            Console.WriteLine(cizgi);
//            goto basla;
//        } // Veri tabanında eğer veri yoksa başlangıç ekranına geri dön
//        for (int i = 0; i < personelList.Count; i++) // personel listesini çağırıyoruz
//        {
//            Console.WriteLine("{0}. {1}", i, personelList[i]);
//        }

//        Console.WriteLine("Lütfen silmek istediğiniz personelin numarasını giriniz.");

//        int pSilmeSecim = int.Parse(Console.ReadLine()); // silmek istediğimiz üyenin index'ini belirliyoruz

//        var personelDelete = personelList[pSilmeSecim];
//        if (personelDelete != null)
//        {
//            personelList.RemoveAt(pSilmeSecim); // Personel Listesindeki Üyenin Index'ini siliyoruz.
//            Console.Clear();
//            Console.WriteLine(cizgi);
//            Console.WriteLine("Başarılı bir şekilde {0} isimli personeli sildiniz!", personelDelete);
//            Console.WriteLine(cizgi);
//            goto basla;
//        }
//        else
//        {
//            Console.Clear();
//            Console.WriteLine(cizgi);
//            Console.WriteLine("Silmek istediğiniz personel bulunamadı lütfen tekrar seçiniz!");
//            Console.WriteLine(cizgi);
//            goto personelSil;
//        };
//    case '5':
//        Console.WriteLine("Kaç adet personel eklemek istiyorsunuz ?");
//        int personelMiktar = int.Parse(Console.ReadLine());

//        for (int i = 0; i < personelMiktar; i++)
//        {
//            Console.WriteLine("Personel Adı : ");
//            string personelAd = Console.ReadLine();
//            personelList.Add(personelAd);
//            Console.Clear();
//            Console.WriteLine(cizgi);
//            Console.WriteLine("{0} isimli personel eklendi!", personelAd);
//            Console.WriteLine(cizgi);
//        }
//        goto basla;
//    default:
//        break;
//}
#endregion
#region Süleyman Yılmaz
//char secim;
//ArrayList personel = new ArrayList();
//Console.Title = "infotech academy";
//Console.BackgroundColor = ConsoleColor.DarkBlue;
//Console.WriteLine("============================================");
//Console.WriteLine("academy otomasyonuna hosgeldiniz");
//Console.WriteLine("=============================");
//Console.WriteLine("ilk girisiniz oldugundan lutfen personel ekleyiniz");
//Console.WriteLine("Personel Adini Giriniz: ");
//personel.Add(Console.ReadLine());
//Basla:
//Console.WriteLine("1-) Personel Ekle\n2-) Personel Guncelle\n3-) Personel Listele\n4-) Personel Sil\n5-) Coklu Personel Ekle");
//secim = char.Parse(Console.ReadLine());
//switch (secim)
//{
//    case '1':
//        Console.WriteLine("Personel Adini Giriniz: ");
//        personel.Add(Console.ReadLine());
//        goto Basla;
//    case '2':
//        Console.WriteLine("Guncellemek istediginiz veriyi seciniz: ");
//        int pSecim = Convert.ToInt32(Console.ReadLine());
//        if (pSecim < personel.Count)
//        {
//            Console.WriteLine("Yeni deger giriniz: ");
//            personel[pSecim] = Console.ReadLine();
//        }
//        else
//        {
//            Console.WriteLine("hatali bir secim yaptiniz, bastan basliyoruz");
//        }
//        goto Basla;
//    case '3':
//        foreach (var item in personel)
//        {
//            Console.WriteLine(item);
//        }
//        goto Basla;
//    case '4':
//        Console.WriteLine("Silmek istediginiz veriyi seciniz: ");
//        int pSecim2 = Convert.ToInt32(Console.ReadLine());
//        if (pSecim2 <= personel.Count)
//        {
//            personel.RemoveAt(pSecim2);
//            Console.WriteLine("Personel Silindi");
//        }
//        else
//        {
//            Console.WriteLine("hatali bir secim yaptiniz, bastan basliyoruz");
//        }
//        goto Basla;
//    case '5':
//        Console.WriteLine("eklemek istediginiz personel sayisini giriniz: ");
//        int ekkapasite = int.Parse(Console.ReadLine());
//        for (int i = 0; i < ekkapasite; i++)
//        {
//            Console.WriteLine("Personel Adini Giriniz: ");
//            personel.Add(Console.ReadLine());
//        }
//        goto Basla;
//    default:
//        break;
//}
#endregion
#region Umut Türk
//char secim;
//ArrayList Personel = new ArrayList();
//Console.Title = "UMUT";
//Console.BackgroundColor = ConsoleColor.DarkYellow;
//Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-");
//Console.WriteLine("Selamın Aleyküm Başkan");
//Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-");
//basla:
//Console.WriteLine("1-) Personel Ekleme\n2-) Personel Güncelleme\n3-) Personel Listeleme\n4-) Personel Sil\n5-) Toplu Personel Ekleme");
//secim = char.Parse(Console.ReadLine());
//switch (secim)
//{
//    case '1':
//        Console.WriteLine("Lütfen Personel Adını Giriniz : ");
//        string personelName = Console.ReadLine();
//        Personel.Add(personelName);
//        Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-");
//        Console.WriteLine("Başarıyla Eklediniz.");
//        Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-");
//        goto basla;

//    case '2':
//        if (Personel.Count == 0)
//        {
//            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-");
//            Console.WriteLine("Listede Personel Yoktur.");
//            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-");
//        }
//        else
//        {
//            Console.WriteLine("Personel Listesinden Lütfen Güncellemek İstediğiniz Kişiyi yada Veriyi Seçiniz: ");
//            int pSecim = Convert.ToInt32(Console.ReadLine());
//            Console.WriteLine("Yeni Değer Giriniz : ");
//            Personel[pSecim] = Console.ReadLine();


//        }
//        break;
//    case '3':

//        if (Personel.Count == 0)
//        {
//            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-");
//            Console.WriteLine("Listede personel yoktur.");
//            Console.WriteLine("-+-+-+-+-+-+-+-+-+-+-+-");
//        }
//        else
//        {
//            foreach (var item in Personel)
//            {
//                Console.WriteLine(item);
//            }
//        }
//        Console.Clear();
//        break;
//    case '4':
//        if (Personel.Count == 0)
//        {
//            Console.WriteLine("Listede personel yoktur.");
//        }
//        else
//        {
//            Console.WriteLine("Personel Listesinden lütfen silmek istediğiniz kişiyi yada veriyi seçiniz: ");
//            int pSecim2 = Convert.ToInt32(Console.ReadLine());
//            Personel.RemoveAt(pSecim2);
//            Console.WriteLine("Personel Silindi");
//        }

//        goto basla;
//    case '5':
//        Console.WriteLine("kaç adet personel ekleyeceksınız? : ");
//        int x = Convert.ToInt32(Console.ReadLine());

//        for (int i = 0; i < x; i++)
//        {
//            Console.WriteLine("Lütfen Personel Adını Giriniz : ");
//            Personel.Add(Console.ReadLine());
//        }
//        break;
//    default:
//        Console.WriteLine("yanlış değer girdiniz.");
//        break;
//}
#endregion
ArrayList Marka = new ArrayList();
ArrayList Model =new ArrayList();
ArrayList MotorHacim=new ArrayList();
ArrayList VitesTipi =new ArrayList();
ArrayList YakitTipi=new ArrayList();
char secim;
/*
 * Char Secim ilk kunumu Programa devam etmek istiyormusunuz istemiyormusunuz
 * İstiyorsa döngü devam edecek
 * istemiyorsa break kodu kırıp program sonlanacak
 * Arabanın Markasını Modelini Motor Hacimini Vites Tipini ve Yakıt Tipini
 * Gireceksiniz.
 * Marka Listesi String
 * Model Listesi String
 * Vites Tipi String
 * Motor Hacim int
 * YakitTipi String
 * olarak değer tipleri ayarlanacak.
 * Araba Bilgisi Ekleme
 * Araba Bilgisi Güncelleme
 * Araba Bilgisi Silme
 * Araba Bilgisi Arama
 * Araba Bilgisi Çoklu Ekleme
 * Araba Bilgisi Çoklu Güncelleme
 * Araba Bilgisi Çoklu Silme
 * İşlemleri yapılacak.
 * Artı olarak Bir Koşulunuzda Yeni dizi ekleme talebi oluşturacaksınız
 * Oluşturulan dizide arabanın model yılını alacaksınız içeriye alınacak değerleri
 * int tipinde olup
 * Her Araba Bilgisine Karşılık Gelecek Şekilde Ekleme Güncelleme ve Silme İşlemi yaptıracaksınız. Index bilgisini araba markasını ve modelini çekip yıl dizine ona karşılık gelmesini istediğiniz indexe ekleyeceksiniz.
 */
Console.ReadKey();
