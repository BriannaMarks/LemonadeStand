using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        double lemonInventory;
        double sugarInventory;
        double iceInventory;
        private double GetLemonInventory()
        {
            Console.WriteLine("Lemons: {0}", lemonInventory);
            return lemonInventory;
        }
        private double GetSugarInventory()
        {
            Console.WriteLine("Sugar: {0}", sugarInventory);
            return sugarInventory;
        }
        private double GetIceInventory()
        {
            Console.WriteLine("Ice: {0}", iceInventory);
            return iceInventory;
        }

        public void EmptyAllInventory()
        {
            lemonInventory = 0;
            sugarInventory = 0;
            EmptyIceInventory();
        }
        public void EmptyIceInventory()
        {
            iceInventory = 0;
        }
        public void GetAllInventories()
        {
            GetLemonInventory();
            GetSugarInventory();
            GetIceInventory();
        }
        public void AddToLemonInventory(double amountBought)
        {
            lemonInventory = lemonInventory + amountBought;
        }
        public void AddToSugarInventory(double amountBought)
        {
            sugarInventory = sugarInventory + amountBought;
        }
        public void AddToIceInventory(double amountBought)
        {
            iceInventory = iceInventory + amountBought;
        }
    }
}
