using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Ev
{
    public class Kiralik : EvOzellikler
    {
        public decimal Fiyat;
        public decimal Depozito;
        public int sozlesmeZamani;
        public long Tel;
        public void kiralikOzellik()
        {
            Console.WriteLine("Kiralık Ev Özellikleri");
            Console.WriteLine("Kira Fiytı : " + Fiyat);
            Console.WriteLine("Depozito Tutar : " + Depozito);
            Console.WriteLine("Sözleşme Zamanı : " + sozlesmeZamani);
            Console.WriteLine("Telefon : " + Tel);
        }
    }
}
