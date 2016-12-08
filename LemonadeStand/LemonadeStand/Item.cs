using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Item
    {
        protected double costPerItem;

        protected double GetItemPrice()
        {
            return costPerItem;
        }


    }
}
