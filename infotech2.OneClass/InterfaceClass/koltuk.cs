using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceClass
{
    public class koltuk : IMobilya
    {
        public string renk { get; set; }
        public string malzeme { get; set; }
        public void MalzemeGir()
        {
            Console.WriteLine("Koltuğun malzeme giriniz : ");
            malzeme = Console.ReadLine();
        }

        public void OzellikGir()
        {
            Console.WriteLine("Koltuğun Özelliklerini Gösterelim");
            Console.WriteLine("Renk {0}", renk);
            Console.WriteLine("Malzeme {0}", malzeme);
        }

        public void RenkGir()
        {
            Console.WriteLine("Koltuğun rengini giriniz : ");
            renk = Console.ReadLine();
        }
    }
}
