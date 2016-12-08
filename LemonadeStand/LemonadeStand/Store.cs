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
        double playerMoney;
        public void StoreMenu()
        {
            Console.WriteLine("What would you like to buy?");
            Console.WriteLine("-Lemons");
            Console.WriteLine("-Sugar");
            Console.WriteLine("-Ice");
            Console.WriteLine("-Go Back");

        }
        public void StoreChoice(Player player)
        {
            switch (Console.ReadLine().ToLower())
            {
                case "lemons":
                    selectItemAmount("lemon", new Lemon().GetLemonPrice(),player);
                    break;
                case "sugar":
                    selectItemAmount("sugar", new Sugar().GetSugarPrice(), player);
                    break;
                case "ice":
                    selectItemAmount("ice", new Ice().GetIcePrice(), player);
                    break;
                case "go back":
                    break;
                case "help":
                    break;
                default:
                    Console.WriteLine("Invalid selection. Please enter what you would like to buy.");
                    StoreChoice(player);
                    break;
            }
        }
        protected void selectItemAmount(string itemName, double costPerItem, Player player)
        {
            Console.WriteLine("How much {0} would you like?", itemName);
            try
            {
                amountOfItem = int.Parse(Console.ReadLine());
            }
            catch
            {
                Console.WriteLine("Invalid entry. Please enter the amount you would like to buy.");
                selectItemAmount(itemName, costPerItem, player);
            }
            TotalItemCost(itemName, costPerItem, amountOfItem, player);
        }
        public double TotalItemCost(string itemName, double costPerItem, double amountOfItem, Player player)
        {
            
            checkBalance = player.CheckBalance(costPerItem * amountOfItem);
            if (checkBalance == true)
            {
                totlaItemCost = (costPerItem * amountOfItem);
                playerMoney = player.GetPlayerMoney();
                playerMoney = playerMoney - totlaItemCost;
                Console.WriteLine("You bought {0} units of {1}", amountOfItem, itemName);
                Console.WriteLine("You now have ${0} left", playerMoney);
                Console.WriteLine("");
                return playerMoney;
            }
            else if (checkBalance == false)
            {
                Console.WriteLine("You don't have enough money to purchase that. Enter a smaller amount.");
                selectItemAmount(itemName, costPerItem, player);
                return playerMoney;
            }
            else
            {
                Console.WriteLine("ERROR");
                return playerMoney;
            }
        }
    }
}
