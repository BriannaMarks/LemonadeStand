using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Ice : Item
    {
        double icePrice;
        protected double SetIcePrice()
        {
            icePrice = 0.10;
            return icePrice;
        }
        public double GetIcePrice()
        {
            return icePrice;
        }
    }
}
