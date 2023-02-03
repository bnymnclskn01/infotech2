using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.SonOrnek
{
    public class CGeometri : IGeometri
    {
        public Dictionary<int,string> Alanlar=new Dictionary<int,string>();
        public Dictionary<int, string> Cevreler = new Dictionary<int, string>();
        int sonuc = 0;
        int formul = 2;
        public int Alan(int Key, int kisa, int uzun)
        {
            sonuc = kisa * uzun;
            Alanlar.Add(Key, sonuc.ToString());
            return sonuc;
        }

        public int Cevre(int Key, int kisa, int uzun)
        {
            sonuc = formul*(kisa + uzun);
            Cevreler.Add(Key, sonuc.ToString());
            return sonuc;
        }
    }
}
