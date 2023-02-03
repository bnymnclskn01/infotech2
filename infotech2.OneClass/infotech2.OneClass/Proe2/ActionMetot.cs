using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Proe2
{
    public class ActionMetot : IHesap
    {
        public decimal Hesaplama(decimal say1, decimal say2, char? secim)
        {
            if (secim == '1')
            {
                return say1 + say2;
            }
            else if (secim == '2')
            {
                return say1 - say2;
            }
            else if (secim == '3')
            {
                return say1 / say2;
            }
            else if (secim == '4')
            {
                return say1 * say2;
            }
            else
            {
                return 0;
            }
        }
    }
}
