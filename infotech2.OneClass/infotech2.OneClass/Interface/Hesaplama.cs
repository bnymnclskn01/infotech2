using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Interface
{
    public class Hesaplama : ITanim
    {
        public decimal Bolme(decimal sayi1, decimal sayi2)
        {
            return sayi1 / sayi2;
        }

        public int Carpma(int sayi1, int sayi2)
        {
            return sayi1 * sayi2;
        }

        public int Cikarma(int sayi1, int sayi2)
        {
            return sayi1 - sayi2;
        }

        public int Topla(int sayi1, int sayi2)
        {
            return sayi1 + sayi2;
        }
    }
}
