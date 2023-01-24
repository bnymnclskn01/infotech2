/* double
//double alis, karOrani, satis;
//Console.WriteLine("Sayıyı Giriniz : ");
//alis = Convert.ToDouble(Console.ReadLine());
//Console.WriteLine("Kar Oranını Giriniz : ");
//karOrani = Convert.ToDouble(Console.ReadLine());
//satis = alis + (alis * karOrani / 100);
//Console.WriteLine("Satış Fiyatı : {0} ", satis);
//Console.ReadKey();
**/

/* double
//double yaricap, alan, cevre;
//Console.WriteLine("Yarıçapı Giriniz : ");
//yaricap = Convert.ToDouble(Console.ReadLine());
//alan = 3.14 * yaricap * yaricap;
//cevre = 2 * 3.14 * yaricap;
//Console.WriteLine("Alan : " + alan);
//Console.WriteLine("Çevre : " + cevre);
//Console.ReadKey();
*/

/* double
//double sayi1, sayi2, sayi3, toplam;
//Console.WriteLine("1. Say : ");
//sayi1 = Convert.ToDouble((Console.ReadLine);
//Console.WriteLine("2. Say : ");
//sayi2 = Convert.ToDouble((Console.ReadLine);
//Console.WriteLine("3. Say : ");
//sayi3 = Convert.ToDouble((Console.ReadLine);
//toplam = sayi1 + sayi2 + sayi3;
//Console.WriteLine("Toplam : " + toplam);
//Console.ReadKey();
*/

/* int
Console.Write("Sayıyı Giriniz : ");
int sayi = int.Parse(Console.ReadLine());
if (sayi > 0)
Console.WriteLine("{0} sayısı Pozitiftir", sayi);
else if (sayi < 0)
Console.WriteLine("{0} sayısı Negatiftir", sayi);
else
Console.WriteLine("{0} sayısı sıfırdır", sayi);
Console.ReadKey();
*/

/* int
Console.Write("Sayıyı Giriniz : ");
int sayi = int.Parse(Console.ReadLine());
if (sayi % 2 == 0)
Console.WriteLine("{0} sayısı çifttir", sayi);
else
Console.WriteLine("{0} sayısı tektir", sayi);
Console.ReadKey();
*/

/* int
Console.Write("Kenar Uzunluğunu : ");
int kenar = int.Parse(Console.ReadLine());
int alan = 4 * kenar;
int cevre = kenar * kenar;
Console.WriteLine("Çevresi {0} ", cevre);
Console.WriteLine("Alanı {0} ", alan);
Console.ReadKey();
*/

/* hatalı hocaya sor
Console.Write("1. metni giriniz: ");
string metin1 = Console.ReadLine();
Console.Write("2. metni giriniz: ");
string metin2 = Console.ReadLine();
Console.Write("3. metni giriniz: ");
string metin3 = Console.ReadLine();
string birlestirilen = String.Concat(metin1, metin2, metin3);
Console.WriteLine("{0}, {1} ve {3} kelimelerinin birleştirilmiş hali: {3}", metin1, metin2, birlestirilen);
Console.ReadKey();
*/

/* Switch
 
Console.WriteLine("Lütfen bir sayı giriniz");
int sayi = Int32.Parse(Console.ReadLine());
switch (sayi)

    case 1: Console.WriteLine("Pazartesi"); break;
    case 2: Console.WriteLine("Salı"); break;
    case 3: Console.WriteLine("Çarşamba"); break;
    case 4: Console.WriteLine("Perşembe"); break;
    case 5: Console.WriteLine("Cuma"); break;
    case 6: Console.WriteLine("Cumartesi"); break;
    case 7: Console.WriteLine("Pazar"); break;
    default: Console.WriteLine("Hata Böyle bir gün yok"); break;

Console.ReadLine(); 
*/


/**
Console.WriteLine("Lütfen mevsimi giriniz");
string mevsim = Console.ReadLine();
switch (mevsim)

    case "kış": Console.WriteLine("Aralık, Ocak, Şubat"); 
        break;
    case "ilkbahar": Console.WriteLine("Mart, Nisan, Mayıs"); 
        break;
    case "yaz": Console.WriteLine("Haziran, Temmuz, Ağustos"); 
        break;
    case "sonbahar": Console.WriteLine("Eylül, Ekim, Kasım"); 
        break;
    default: Console.WriteLine("Böyle bir mevsim yok"); 
        break;

Console.ReadLine();
*/
