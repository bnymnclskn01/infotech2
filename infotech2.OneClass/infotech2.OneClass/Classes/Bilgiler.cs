using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Classes
{
    public class Bilgiler
    {
        public string Name;
        public string Surname;
        public int Age;
        public string Gender;
        // Bu değişkenleri kullanarak Bilgilerini alacağınız işlem metotunu yazacaksınız.
        public void BilgileriYazdir()
        {
            Console.WriteLine("Lütfen Adınızı Giriniz : ");
            Name = Console.ReadLine();
            Console.WriteLine("Lütfen Soyadınızı Giriniz : ");
            Surname = Console.ReadLine();
            Console.WriteLine("Lütfen Yaşınızı Giriniz : ");
            Age=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Cinsiyetinizi Giriniz : ");
            Gender = Console.ReadLine().ToLower();
        }

        public void ErkekseYapilacaklar()
        {
            Console.WriteLine("Bu ne cinsiyetçi yaklaşım böyle ya kadın erkek ayrımı mı olur:D");
        }
        public void KadinsaYapilacaklar()
        {
            Console.WriteLine("Bu ne cinsiyetçi yaklaşım böyle ya kadın erkek ayrımı mı olur:D");
        }
        public void GenelIslemler()
        {
            if (Gender == "erkek")
            {
                ErkekseYapilacaklar();
            }
            else if (Gender == "kadın")
            {
                KadinsaYapilacaklar();
            }
            else
            {
                Console.WriteLine("Yanlış İşlem Yapınız");
            }
        }
    }
}
