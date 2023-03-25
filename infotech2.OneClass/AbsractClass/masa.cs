using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractClass
{
    class masa : Mobilya
    {
        public string Rrenk;
        public string malzeme { get; set; }


        public override void ozellikYaz()
        {
            Console.WriteLine("Masanın özellikleri");
            Console.Write("Masanın rengi {0}", renk);
            Console.WriteLine("Masanın malzeme {0}", malzeme);
        }
    }
}
