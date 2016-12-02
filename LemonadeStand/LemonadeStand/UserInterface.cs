using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    public static class UserInterface
    {
        public static void Instructions()
        {
            Console.WriteLine("How To Play:");
            Console.WriteLine("Buy supplies, make and then sell lemonade.");
            Console.WriteLine(" ");
        }
        public static void DailyStartChoices()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("");
            Console.WriteLine("-Check the weather");
            Console.WriteLine("-Check your supply inventory");
            Console.WriteLine("-Go to the store");
            //Console.WriteLine("-Save your current progress");
            PlayerStartChoice();
        }
        private static void PlayerStartChoice()
        {
            switch (Console.ReadLine().ToLower())
            {
                case "check the weather":

                case "check your supply inventory":

                case "go to the store":

                //case "save your current progress":
                case "help":
                    Instructions();
                    break;
                default:
                    Console.WriteLine("Invalid entry. Please select where you would like to go.");
                    Console.WriteLine("Enter 'help' for more information.");
                    PlayerStartChoice();
                    break;

            }
        }

    }
}
