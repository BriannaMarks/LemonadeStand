using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Customer
    {
        Random newRandom = new Random();
        int personalTaste;
        int customers;
        int interestInLemonade;
        int isALemonadeBuyer;
        public int GetCustomers()
        {
            customers = 50;
            return customers;
        }
        public int CalculateBuyerInterest(int theWeather, int theTemperature)
        {
            interestInLemonade = theWeather + theTemperature;
            return interestInLemonade;
        }
        public int GetNumberOfBuyers()
        {
           return isALemonadeBuyer;
        }
        public int TotalLemonadeBuyers(int intrest, int recipe)
        {
           personalTaste = newRandom.Next(1, 50);
            interestInLemonade = interestInLemonade - personalTaste;
            if (interestInLemonade >= recipe)
            {
                isALemonadeBuyer++;

            }
            else if (interestInLemonade < recipe)
            {
                
            }
            else
            {
                Console.WriteLine("ERROR");
                
            }
            return isALemonadeBuyer;
        }
    }
}
