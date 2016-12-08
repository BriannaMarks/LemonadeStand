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
            Console.WriteLine("---------------------------");
            Console.WriteLine("Buy supplies to make and then sell lemonade.");
            Console.WriteLine("Be sure to check the weather every day!");
            Console.WriteLine(" ");
        }
        public static void DailyMenuOptions()
        {
            Console.WriteLine("What would you like to do?");
            Console.WriteLine("");
            Console.WriteLine("-Check the weather");
            Console.WriteLine("-Check inventory");
            Console.WriteLine("-Go to the store");
            Console.WriteLine("-Start selling lemonade");
            //Console.WriteLine("-Save your current progress");
        }


    }
}
