using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Kapsulleme
{
    public class BiletSatis
    {
        #region Private Field
        private string nameSurname;
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
        public char Secim
        {
            get { return secim; }
            set { secim = value; }
        }
        public double Obilet
        {
            get { return 58.99; }
            set { obilet = 58.99; }
        }
        public double Tbilet
        {
            get { return 129.99; }
            set { tbilet = 129.99; }
        }
        #endregion

        #region Metotlar
        public double Ogrenci()
        {
            return Obilet;
        }
        public double TamBilet()
        {
            return Tbilet;
        }

        public void ActionMetot()
        {
            Console.WriteLine("Adınızı Soyadınız Giriniz : ");
            NameSurname = Console.ReadLine();
            Console.Clear();
            Console.WriteLine("1-Tam Biet\n2-Öğrenci Bilet : ");
            Secim = char.Parse(Console.ReadLine());
            switch (Secim)
            {
                case '1':
                    Console.WriteLine("Sayın {0};\n Sizden kesilen tutar{1}TL'dir iyi seyirler dileriz.", NameSurname, TamBilet());
                    break;
                case '2':
                    Console.WriteLine("Sayın {0};\n Sizden kesilen tutar{1}TL'dir iyi seyirler dileriz.", NameSurname, Ogrenci());
                    break;
                default:
                    Console.WriteLine("Yanlış İşlem Yaptınız.");
                    break;
            }
        }
        #endregion
    }
}
