using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Lemon : Item
    {
        double lemonPrice;
        public double SetLemonPrice()
        {
            lemonPrice = 0.30;
            return lemonPrice;
        }
        public double GetLemonPrice()
        {
            SetLemonPrice();
            return lemonPrice;
        }
    }
}
