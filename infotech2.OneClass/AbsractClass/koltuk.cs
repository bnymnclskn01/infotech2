using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractClass
{
    class koltuk : Mobilya
    {
        // Özellik Tanımlandı
        public string kumas;
        //Gövdesi olmayan metotudumuza işlem kazandırdık.
        // gövdeli metot oldu.
        public override void ozellikYaz()
        {
            Console.WriteLine("Koltuğun özellikleri");
            Console.Write("Koltuğun rengi {0}", renk);
            Console.WriteLine("Koltuğun kumaşı {0}", kumas);
        }
    }
}
