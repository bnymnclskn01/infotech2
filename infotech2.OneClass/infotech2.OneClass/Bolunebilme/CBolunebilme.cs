using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace infotech2.OneClass.Bolunebilme
{
    public class CBolunebilme : IBolunebilme
    {
        public double Hesap(double x)
        {
            if (x % 3 == 0)
            {
                return 1;
            }
            else if (x % 5 == 0)
            {
                return 2;
            }
            else if (x % 7 == 0)
            {
                return 3;
            }
            else
            {
                return 0;
            }
        }
    }
}
