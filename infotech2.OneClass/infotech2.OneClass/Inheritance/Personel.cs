using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Inheritance
{
    // Sub Super  Class
    public class Personel : Messages
    {
        #region Private Field
        private string nameSurname;
        private string country;
        private string city;
        private string department;
        private decimal sallary;
        #endregion
        #region Public Field
        public string NameSurname
        {
            get { return nameSurname; }
            set { nameSurname = value; }
        }
        public string Country
        {
            get { return country; }
            set { country = value; }
        }
        public string City
        {
            get { return city; }
            set { city = value; }
        }
        public string Department
        {
            get { return department; }
            set{ department = value; }
        }
        public decimal Sallary
        {
            get { return sallary; }
            set { sallary = value;}
        }
        #endregion
    }
}
