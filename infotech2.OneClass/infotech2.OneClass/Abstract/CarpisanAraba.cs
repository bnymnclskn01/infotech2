using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Abstract
{
    public class CarpisanAraba : Araba
    {
        public override void YolculugaBasla()
        {
            Marka = "BMW";
            MaksimumHiz = 200;
            Tur = "Spor Araba";
            Console.WriteLine("Arabanın Markası : {0}\nArabanın Maksimum Hızı : {1}\nArabanın Türü : {2}\nYukarıda belirtilen araba bilgisindeki araçla yolculuğa başlanmıştır.", Marka, MaksimumHiz, Tur);
        }
    }
}
