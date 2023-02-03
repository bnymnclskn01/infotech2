using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Fats
{
    public class RepositoryBase : IRepository
    {
        public Dictionary<int, string> deger = new Dictionary<int, string>();
        public string Create(int Key, string Value)
        {
            deger.Add(Key, Value);
            return "Kayıt Başarılı bir şekilde eklendi";
        }
    }
}
