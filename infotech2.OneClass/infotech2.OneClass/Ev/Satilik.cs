using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Ev
{
    public class Satilik : EvOzellikler
    {
        private decimal fiyat;
        private long tel;

        public decimal Fiyat
        {
            get { return fiyat; }
            set { fiyat = value; }
        }
        public long Tel
        {
            get { return tel; }
            set { tel = value; }
        }
        public void satilikOzellik()
        {
            Console.WriteLine("Satılık Ev Özellikleri :");
            Console.WriteLine("Satılık Ev Fiyatı : " + Fiyat);
            Console.WriteLine("Telefon Numaranız : " + Tel);
        }
    }
}
