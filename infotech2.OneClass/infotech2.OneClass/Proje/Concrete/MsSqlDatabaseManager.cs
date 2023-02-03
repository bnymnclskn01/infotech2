using infotech2.OneClass.Proje.Abstract;
using infotech2.OneClass.Proje.Inheritance;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Proje.Concrete
{
    public class MsSqlDatabaseManager : Tanimlamalar, IDatabase
    {

        
        public object Create(int ID, object Value)
        {
            MssqlServer.Add(ID, Value.ToString());
            return Value;
        }

        public void Delete(int ID)
        {
            GetAllList();
            int sayac = MssqlServer.Count;
            if (sayac > 0)
            {
                Console.WriteLine("Silmek istediğiniz ID değerini giriniz : ");
                ID = Convert.ToInt32(Console.ReadLine());
                MssqlServer.Remove(ID);
                Console.Clear();
                Console.WriteLine("Veritabanı Bilgisi sistemden silinmiştir.");
            }
            else
            {
                Console.WriteLine("Sistemizde kayıt bulunamadığı için silme işlemi yapamazsınız");
            }
        }

        public void GetAllList()
        {
            int sayac = MssqlServer.Count;
            if (sayac > 0)
            {
                foreach (var item in MssqlServer)
                {
                    Console.WriteLine($"Sql ID : {item.Key}\tSql Bilgileri : {item.Value}");
                }
            }
            else
            {
                Console.WriteLine("Listelencek kayıt bulunamadı.");
                return;
            }
        }

        public void GetById(int ID)
        {
            int sayac = MssqlServer.Count;
            if (sayac > 0)
            {
                foreach (var item in MssqlServer)
                {
                    Console.WriteLine($"Sql ID : {item.Key}\nSql Bilgileri : {item.Value}");
                }

                char sec;
                bool kayitDurum;
                Console.WriteLine("ID'ye göre mi aramak istiyorsunuz\nSql database bilgisine göremi aramak istiyorsunuz?\n1-ID\n2-Sql");
                sec = Convert.ToChar(Console.ReadLine());
                if (sec == '1')
                {
                    Console.WriteLine("Lütfen Aramak İstediğiniz ID'yi Giriniz : ");
                    ID = Convert.ToInt32(Console.ReadLine());
                    kayitDurum = MssqlServer.ContainsKey(ID);

                    if (kayitDurum==true)
                    {
                        Console.WriteLine("Aradaığınız Kayıt Sistemimizde Bulunmaktadır.");
                    }
                    else
                    {
                        Console.WriteLine("Kayıt Bulunamadı.");
                    }
                }
                else
                {
                    Console.WriteLine("ID dışında bir arama yapamazsınız.");
                }
            }
            else
            {
                Console.WriteLine("Listelencek kayıt bulunamadı.");
            }
        }

        public void Update(int ID)
        {
            GetAllList();
            Console.WriteLine("Güncellemek İStedğiniz ID Değerini Giriniz : ");
            ID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sql Bilgisini Yeni Güncelleme İşlemi Yapınız : ");
            string val = Console.ReadLine();

            if (MssqlServer[ID] != null)
            {
                MssqlServer[ID] = val.ToString();
            }
        }
    }
}
