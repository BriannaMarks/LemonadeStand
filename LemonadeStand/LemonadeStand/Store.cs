using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        public void StoreMenu()
        {
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("-Lemons");
            Console.WriteLine("-Sugar");
            Console.WriteLine("-Ice");
            Console.WriteLine("-Go Back");
            StoreChoice();
        }
        private void StoreChoice()
        {
            switch (Console.ReadLine().ToLower())
            {
                case "lemons":
                case "sugar":
                case "ice":
                case "go back":
                case "help":

                default:
                    Console.WriteLine("Invalid selection. Please enter what you would like to buy.");
                    StoreChoice();
                    break;
            }
        }
        public void BuyingMenu()
        {

        }
    }
}
