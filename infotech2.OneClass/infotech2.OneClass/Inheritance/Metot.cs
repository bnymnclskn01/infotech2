using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Inheritance
{
    public class Metot : Personel
    {
        public void BilgileriYazdir()
        {
            Console.WriteLine(AS);
            NameSurname = Console.ReadLine();
            Console.WriteLine(CT);
            Country = Console.ReadLine();
            Console.WriteLine(CY);
            City = Console.ReadLine();
            Console.WriteLine(DP);
            Department = Console.ReadLine();
            Console.WriteLine(SY);
            Sallary = decimal.Parse(Console.ReadLine());
            Console.Clear();
            var deger = "Adınız Soyadınız : " + NameSurname + "\n" + "Yaşadığınız Ülke : " + Country + "\nYaşadığınız Şehir: " + City + "\nÇalıştığınız Departman : " + Department + "\nMaaşınız : " + Sallary;
            Console.WriteLine(deger);
        }
    }
}
