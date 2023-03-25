using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbsractClass
{
    abstract class Mobilya
    {
        // Özellik Tanımladık. Bu özellik
        // bütün kalıtım alan çeşitlilik
        //gerektiren classlarda ortak özellik
        // olarak kullanılacak.
        public string renk { get; set; }
        // Gövesiz Metot ve Gövdesiz Geriye Değer
        //döndürmeyen metot (void) olarak
        //kullanıyoruz
        abstract public void ozellikYaz();
        // eğer ki metotlarda bir değişkenli
        // beklenen metot kullanırsak
        // bu metot sonunda geriye bir
        // değer döndürmek zorunda kalırız.
    }
}
