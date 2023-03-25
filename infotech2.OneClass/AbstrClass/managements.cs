using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstrClass
{
    class managements : School
    {
        ArrayList personelDepartment = new ArrayList();
        ArrayList personList = new ArrayList();
        public string PersonName;
        public string DeptName;
        public string Name;
        public int Capacity;
        public override string personName
        {
            get
            {
                return PersonName;
            }
            set
            {
                PersonName = value;
            }
        }
        public override string name
        {
            get
            {
                return Name;
            }
            set
            {
                Name = value;
            }
        }
        public override int capacity
        { get { return Capacity; } set { Capacity = value; } }

        public void Create()
        {
            Console.WriteLine("Lütfen Personelin Görevini Giriniz : ");
            personList.Add(Console.ReadLine());
            Console.WriteLine("Personelin Bilgisini Adını Soyadını Giriniz : ");
            DeptName = Console.ReadLine();
            personList.Add(PersonName);
            personelDepartment.Add(DeptName);
        }
        public void Update()
        {

        }
        public void Delete()
        {

        }
    }
}
