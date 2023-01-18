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
#endregion
Console.ReadKey();