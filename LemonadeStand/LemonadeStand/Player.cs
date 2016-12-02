using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Player
    {
        double playerMoney;
        public double PlayerStartingMoney()
        {
            playerMoney = 20.00;
            return playerMoney;
        }
        public double ReturnCurrentPlayerMoney()
        {
            return playerMoney;
        }
    }
}
