using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Classes // Benim Açtığım Sınıfın Adresini belirtir.
// infotech2.OneClass Projesinde Classes Klasörünün içinde olduğunu belirtir.
{
    public class MatematikselHesaplamalar
    {
        char secim;
        public double say1, say2;
        #region Void Metotlu Tanımlamalar
        public void VToplama(double sayi1, double sayi2)
        {
            sayi1 = sayi1 + sayi2;
            Console.WriteLine("İki sayının toplamı : " + sayi1);
        }
        public void VCikarma(double sayi1, double sayi2)
        {
            sayi1 = sayi1 - sayi2;
            Console.WriteLine("İki sayının bir birinden çıkartıldığında kalan sonuc : " + sayi1);
        }
        public void VCarpma(double sayi1, double sayi2)
        {
            sayi1 = sayi1 * sayi2;
            Console.WriteLine("İki Sayının Çarpımından Çıkan Sonuç : " + sayi1);
        }
        public void VBolme(double sayi1, double sayi2)
        {
            sayi1 = sayi1 / sayi2;
            Console.WriteLine("İki sayının bölümünden kalan farkı : " + sayi1);
        }
        #endregion
        #region Değişken Tipli Geriye Değer Döndüren Metotlar
        public double DToplama(double sayi1,double sayi2)
        {
            return sayi1 + sayi2;
        }
        public double DCikarma(double say1,double sayi2)
        {
            return say1 - sayi2;
        }
        public double DCarpma(double sayi1,double sayi2)
        {
            return sayi1 * sayi2;
        }
        public double DBolme(double sayi1,double sayi2)
        {
            return sayi1 / sayi2;
        }
        #endregion
        #region İşlemler Metotu Geriye Değer Döndürülmeyecek şekilde hazırlancak.
        public void VoidHesaplamalar()
        {
            Console.WriteLine("Lütfen seçim ypaınız :\n1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme : ");
            secim = Convert.ToChar(Console.ReadLine());
            if (secim == '1')
            {
                VToplama(say1, say2);
            }
            else if (secim == '2')
            {
                VCikarma(say1, say2);
            }
            else if (secim == '3')
            {
                VCarpma(say1, say2);
            }
            else if (secim=='4')
            {
                VBolme(say1, say2);
            }
            else
            {
                Console.WriteLine("Yanlış İşlem Yaptınız");
            }
        }
        #endregion
        #region İşlemler Geriye Değer Döndülecek Şekilde Hazılrnacaktır.
        public double DHesaplamalar()
        {
            Console.WriteLine("Lütfen seçim ypaınız :\n1-Toplama\n2-Çıkarma\n3-Çarpma\n4-Bölme : ");
            secim = Convert.ToChar(Console.ReadLine());
            switch (secim)
            {
                case '1':
                    Console.WriteLine(say1 + "+" + say2 + "=" + DToplama(say1, say2));
                    break;
                case '2':
                    Console.WriteLine(say1+"-"+say2+"="+DCikarma(say1, say2));
                    break;
                case '3':
                    Console.WriteLine(say1 + "*" + say2 + "=" + DCarpma(say1, say2));
                    break;
                case '4':
                    Console.WriteLine(say1 + "/" + say2 + "=" + DBolme(say1, say2));
                    break;
                default:
                    Console.WriteLine("Yanlış İşlem Yaptınız");
                    break;
            }
            return secim;
        }
        #endregion
    }
}
