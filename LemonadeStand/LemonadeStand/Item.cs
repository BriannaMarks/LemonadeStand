using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Item
    {
        public double amountOfItems;
        
        public double AddToNumberOfItems(double bought)
        {
            amountOfItems = amountOfItems + bought;
            return amountOfItems;
        }

    }
}
