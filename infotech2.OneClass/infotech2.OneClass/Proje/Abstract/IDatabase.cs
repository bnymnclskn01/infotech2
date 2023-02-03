using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Proje.Abstract
{
    public interface IDatabase
    {
        public void GetAllList();
        public void GetById(int ID);
        public object Create(int ID, object Value);
        public void Update(int ID);
        public void Delete(int ID); 
    }
}
