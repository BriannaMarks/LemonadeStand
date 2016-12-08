using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        public double playerMoney;
        bool checkBalance;
        public void SetPlayerStartingMoney()
        {
            playerMoney = 20.00;
        }
        public double GetPlayerMoney()
        {
            return playerMoney;
        }
        public bool CheckBalance(double amount)
        {
            if (amount <= playerMoney)
            {
                GetPlayerMoney();
                checkBalance = true;
                return checkBalance;
            }

            else if (amount > playerMoney)
            {
                checkBalance = false;
                return checkBalance;
            }
            else
            {
                Console.WriteLine("ERROR");
                return checkBalance;
            }
        }

    }
}
