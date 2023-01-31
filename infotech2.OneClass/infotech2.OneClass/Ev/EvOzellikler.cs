using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Ev
{
    public class EvOzellikler : Mesajlar
    {
        private string il;
        private string ilce;
        private string oda;
        private string alan;
        private string isinma;

        public string Il
        {
            get { return il; }
            set { il = value; }
        }
        public string Alan
        {
            get { return alan; }
            set { alan = value; }
        }
        public string Ilce
        {
            get { return ilce; }
            set { ilce = value; }
        }
        public string Oda
        {
            get { return oda; }
            set
            {
                oda = value;
            }
        }
        public string Isinma
        {
            get { return isinma; }
            set
            {
                isinma = value;
            }
        }

        public void ozellikGoster()
        {
            Console.WriteLine("Evin Özellikleri");
            Console.WriteLine("İl : " + Il);
            Console.WriteLine("İlçe : " + Ilce);
            Console.WriteLine("Oda Sayısı : " + Oda);
            Console.WriteLine("Metre Karesi : " + Alan);
            Console.WriteLine("Isınma Tipi: " + Isinma);
        }
    }
}
