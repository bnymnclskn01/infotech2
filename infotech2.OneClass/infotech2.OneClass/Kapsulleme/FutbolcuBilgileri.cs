using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Kapsulleme
{
    public class FutbolcuBilgileri
    {
        #region Private Field
        private string nameSurname;
        private string position;
        private string club;
        private string leuge;
        private int age;
        private decimal testimonial;
        private char secim;
        private double obilet;
        private double tbilet;
        #endregion

        #region Public Field
        public string NameSurname
        {
            get { return nameSurname; }
            set { nameSurname = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
        public string Club
        {
            get { return club; }
            set { club = value; }
        }
        public string Leuge
        {
            get { return leuge; }
            set { leuge = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }
        public decimal Testimonial
        {
            get { return testimonial; }
            set { testimonial = value; }
        }
        public char Secim
        {
            get { return secim; }
            set { secim = value; }
        }
        public double Obilet
        {
            get { return obilet; }
            set { obilet = 58.99; }
        }
        public double Tbilet
        {
            get { return tbilet; }
            set { tbilet = 129.99; }
        }
        #endregion
        #region Metot
        public void BilgileriKullan()
        {
            Console.WriteLine("Futbolcuların Billgilerini girerken\n1-Genel Bilgier\n2-Kimlik Bilgileri\nseçimlerinden birini yaparak işlemi tamamlayınız.");
            secim = char.Parse(Console.ReadLine());
            if (secim == '1')
            {
                Console.WriteLine("Adınızı ve Soyadınızı giriniz : ");
                NameSurname = Console.ReadLine();
                Console.WriteLine("Oynadığınız pozisyonu seçiniz. : ");
                Position = Console.ReadLine();
                Console.WriteLine("Lütfen Oynadığınız Klubün ismini yazabilir misiniz? : ");
                Club = Console.ReadLine();
                Console.WriteLine("Oynadığınız klübün hangi ligtedir? : ");
                Leuge = Console.ReadLine();
                Console.WriteLine("Lütfen yaşınızı giriniz : ");
                Age = int.Parse(Console.ReadLine());
                Console.WriteLine("Ne kadar kazanıyorsunuz ? : ");
                Testimonial = decimal.Parse(Console.ReadLine());
                Console.Clear();
                var Degerler = NameSurname + "\t" + Position + "\t" + Club + "\t" + Leuge + "\t" + Age + "\t" + Testimonial;
                Console.WriteLine("Girdiğiniz bilgilere\nGenel Billgiler\n" + Degerler);
            }
            else if (secim == '2')
            {
                Console.WriteLine("Adınızı ve Soyadınızı giriniz : ");
                NameSurname = Console.ReadLine();
                Console.WriteLine("Lütfen yaşınızı giriniz : ");
                Age = int.Parse(Console.ReadLine());
                Console.Clear();
                var Degerler=NameSurname+ "\t" + Age;
                Console.WriteLine("Girdiğiniz bilgilere\nKimlik Billgileri\n" + Degerler);
            }
            else
            {
                Console.WriteLine("Yanlış işlem yazdınız.");
            }
        }
        #endregion
    }
}
