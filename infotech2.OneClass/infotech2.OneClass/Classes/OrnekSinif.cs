using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Classes
{
    /*
     * internal = Sınıf ve veya sınıf üyelerine aynı derlemedeki herhangi bir kod ile erişilebilir. 
     * public = Bir sınıf eğer public yapıldıysa bu sınıfa her yerden erişebilirim.
     * private : özel sınıf yani sadece bütün işlemleri kendisinde saklıdır.
     */
    public class OrnekSinif
    {
        public void MatematikIslemVoid(int sayi1,int sayi2)
        {
            sayi1=sayi1+sayi2;
            Console.WriteLine("Sonuç " + sayi1);
        }
        public int MatematikIslemDondur(int sayi1, int sayi2)
        { 
            return sayi1 = sayi1 + sayi2; 
        }
        /*fiyat= fiyat*1.18*/
        public double kdvHesaplamaDouble(double Fiyat,double kdv)
        {
            return Fiyat = (Fiyat * kdv / 100) + Fiyat;
        }
        public void kdvHesaplaVoid(double Fiyat, double KDV)
        {
            Fiyat = (Fiyat * KDV / 100) + Fiyat;
            Console.WriteLine("Kdvli Fiyatınız : {0}", Fiyat);
        }
    }
}
