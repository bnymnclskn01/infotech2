using System;

public class Program
{
    public static void Main()
    {
        switch (DateTime.Now.DayOfWeek)
        {
            case DayOfWeek.Monday:
            case DayOfWeek.Tuesday:
            case DayOfWeek.Wednesday:
            case DayOfWeek.Thursday:
            case DayOfWeek.Friday:
                Console.WriteLine("Haftaiçindeyiz çalışmaya devam...");
                break;
            case DayOfWeek.Saturday:
            case DayOfWeek.Sunday:
                Console.WriteLine("Dinlen şimdi pazartesi iş bizi bekler...");
                break;
        }
    }
}

static void Main(string[] args)
{
    double birinci = 123.04;
    double ikinci = -1233;
    double maxDoubleDegeri = double.MaxValue;
    double minDoubleDegeri = double.MinValue;

    Console.WriteLine("Birinci degisken: " + birinci);
    Console.WriteLine("Ikinci degisken: " + ikinci);
    Console.WriteLine("Maksimum deger: " + maxDoubleDegeri);
    Console.WriteLine("Minimum deger: " + minDoubleDegeri);
}

static void Main(string[] args)
{
    int sayi;
    Console.Write("Sayıyı Girin : ");
    sayi = Convert.ToInt32(Console.ReadLine());
    if (sayi % 4 == 0 && sayi % 7 == 0)
    {
        Console.WriteLine("Sayı 4 ve 7 ye tam bölünüyor");
    }
    else
    {
        Console.WriteLine("Sayı 4 ve 7 ye tam bölünmüyor");
    }
    Console.ReadKey();

    static void Main(string[] args)
    {
        int sayi;
        Console.Write("Sayıyı Girin : ");
        sayi = Convert.ToInt32(Console.ReadLine());
        if (sayi % 4 == 0 && sayi % 7 == 0)
        {
            Console.WriteLine("Sayı 4 ve 7 ye tam bölünüyor");
        }
        else
        {
            Console.WriteLine("Sayı 4 ve 7 ye tam bölünmüyor");
        }
        Console.ReadKey();
        #region
        static void Main(string[] args)
{
    int sayi, adet = 0;
    for (int i = 1; i <= 10; i++)
    {
        Console.Write(i + ".sayıyı Girin : ");
        sayi = Int32.Parse(Console.ReadLine());
        if (sayi < 50)
        {
            adet++;
        }
    }
    Console.WriteLine("50 den küçük girilen sayı adeti : " + adet);
    Console.ReadKey();
}
#endregion

static void Main(string[] args)
{
    double alis, karOran, satis;
    Console.Write("Sayıyı Girin : ");
    alis = Convert.ToDouble(Console.ReadLine());
    Console.Write("Kar Oranını Girin : ");
    karOran = Convert.ToDouble(Console.ReadLine());
    satis = alis + (alis * karOran / 100);
    Console.WriteLine("Satış Fiyatı : {0}", satis);
    Console.ReadKey();
}
