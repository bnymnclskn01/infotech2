using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Kapsulleme
{
    public class EnCapsulation
    {
        /*
         Bilindiği gibi  kullanmış olduğumuz
        C# programlama dili nesneye dayalı bir
        progralama dili olduğunda dolayı
        Kapsülleme(EnCapsulation) kavramı bir 
        nesnenin bazı özellik ve işlevlerini
        başka sınıflardan ve nesnelerden
        saklamaktır. Private erişim belirtici
        sayesinde bu şekilde field(alan)'ı
        başka sınıflardan gizlemiş oluruz.
        Ayrıca bu field(alan)başka sınıflarda
        kullanılamaz.
        Kapsülleme(EnCapsulation)
        nesneleri bilinçsiz kullanımlardan korur.
        Fakat bazı durumlarda private fieldlara
        bazı durumlarda erişmemiz gerekibilir.
        bir field geri döndürmeye (Get) ve 
        değeri ayarlamaya(SET) denir.
         */
        /*Prop = Özellik ve Field(Alan)*/
        private string country;
        public string Country
        {
            get { return country; }
            set
            {
                if (value == null || value == "")
                    country = "Türkiye";
                else
                {
                    country = value;
                }
            }
        }
    }
}
