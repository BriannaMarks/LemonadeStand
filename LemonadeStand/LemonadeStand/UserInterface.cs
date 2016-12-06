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
            Console.WriteLine("-Start selling lemonade");
            //Console.WriteLine("-Save your current progress");
        }


    }
}
