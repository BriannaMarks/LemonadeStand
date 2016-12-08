using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Sugar : Item
    {
        double sugarPrice;
        public double SetSugarPrice()
        {
            sugarPrice = .20;
            return sugarPrice;
        }
        public double GetSugarPrice()
        {

            return sugarPrice;
        }

    }
}
