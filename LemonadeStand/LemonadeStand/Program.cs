using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Program
    {
        static void Main(string[] args)
        {
            Game LemonadeStand = new Game();
            LemonadeStand.RunLemonadeStand();
        }
        //Game.DisplayName(game.player.getname()) 
        //    display name is from game, but we want to get 'name' from player.
        //    game has an instance of player which has "getname" so it works
        //        20.00m;
    }
}
