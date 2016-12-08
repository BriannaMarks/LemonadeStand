using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Store
    {
        double amountOfItem;
        bool checkBalance;
        double totlaItemCost;
        double addToInventory;

        public void StoreMenu()
        {
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("-Lemons");
            Console.WriteLine("-Sugar");
            Console.WriteLine("-Ice");
            Console.WriteLine("-Go Back");

        }
        public void StoreChoice(Player player, Inventory inventory)
        {
            switch (Console.ReadLine().ToLower())
            {
                case "lemons":
                    selectItemAmount("lemon", new Lemon().GetLemonPrice(), player, inventory);
                    inventory.AddToLemonInventory(amountOfItem);
                    break;
                case "sugar":
                    selectItemAmount("sugar", new Sugar().GetSugarPrice(), player, inventory);
                    inventory.AddToSugarInventory(amountOfItem);
                    break;
                case "ice":
                    selectItemAmount("ice", new Ice().GetIcePrice(), player, inventory);
                    inventory.AddToIceInventory(amountOfItem);
                    break;
                case "go back":
                    break;
                case "help":
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please enter what you would like to buy.");
                    StoreChoice(player, inventory);
                    break;
            }
        }
        protected void selectItemAmount(string itemName, double costPerItem, Player player, Inventory inventory)
        {
            Console.WriteLine("How much {0} would you like?", itemName);
            try
            {
                amountOfItem = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid entry. Please enter the amount you would like to buy.");
                selectItemAmount(itemName, costPerItem, player, inventory);
            }
            TotalItemCost(itemName, costPerItem, amountOfItem, player, inventory);
        }
        public void TotalItemCost(string itemName, double costPerItem, double amountOfItem, Player player, Inventory inventory)
        {
            
            checkBalance = player.CheckBalance(costPerItem * amountOfItem);
            if (checkBalance == true)
            {
                double x;
                for (x = 0; x <= amountOfItem; x++)
                {
                    AddToAnyInventory();
                }
                totlaItemCost = (costPerItem * amountOfItem);
                player.playerMoney = player.GetPlayerMoney();
                player.playerMoney = player.playerMoney - totlaItemCost;
                Console.WriteLine("You bought {0} units of {1}", amountOfItem, itemName);
                Console.WriteLine("You now have ${0} left", player.playerMoney);
                Console.WriteLine("");
            }
            else if (checkBalance == false)
            {
                Console.WriteLine("You don't have enough money to purchase that. Enter a smaller amount.");
                selectItemAmount(itemName, costPerItem, player, inventory);
            }
            else
            {
                Console.WriteLine("ERROR");
            }
        }
        public double AddToAnyInventory()
        {
            addToInventory++;
            return addToInventory;
        }
    }
}
