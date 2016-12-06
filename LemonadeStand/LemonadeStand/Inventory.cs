using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Inventory
    {
        int lemonInventory;
        int sugarInventory;
        int iceInventory;
        public int GetLemonInventory()
        {
            Console.WriteLine("Lemons: {0}", lemonInventory);
            return lemonInventory;
        }
        public int GetSugarInventory()
        {
            Console.WriteLine("Sugar: {0}", sugarInventory);
            return sugarInventory;
        }
        public int GetIceInventory()
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
    }
}
