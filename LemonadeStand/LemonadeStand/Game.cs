using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Game
    {
        Day GameDay;
        public Player entrepreneur;
        Store Supermarket;
        public Inventory PlayerInventory;
        Weather LocalWeather;
        LemonadeRecipie Recipe;
        Customer Buyer;
        int choosenNumberOfDays;
        bool startDailySale;

        public void RunLemonadeStand()
        {
            GameDay = new Day();
            entrepreneur = new Player();
            Supermarket = new Store();
            PlayerInventory = new Inventory();
            LocalWeather = new Weather();
            Recipe = new LemonadeRecipie();
            Buyer = new Customer();

            IntroduceTheGame();
            OfferInstructions();
            ChooseNumberOfDays();
            entrepreneur.SetPlayerStartingMoney();
            PlayerInventory.EmptyAllInventory();
            StartTheDay();

            Console.ReadKey();
        }
        private void IntroduceTheGame()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
        }
        private void OfferInstructions()
        {
            Console.WriteLine("Would you like to read the instructions?");
            switch (Console.ReadLine().ToLower())
            {
                case "yes":
                case "y":
                    UserInterface.Instructions();
                    Console.WriteLine("Get help and view instructions at any time by entering 'help'");
                    Console.WriteLine("");
                    
                    break;
                case "no":
                case "n":
                    Console.WriteLine("Get help and view instructions at any time by entering 'help'");
                    Console.WriteLine(" ");
                    break;
                default:
                    Console.WriteLine("Invalid option. Please enter yes or no.");
                    OfferInstructions();
                    break;
            }
        }

        private int ChooseNumberOfDays()
        {
            Console.WriteLine("How many days would you like to play for?");
            Console.WriteLine("7   14   21   28");
            switch (Console.ReadLine())
            {
                case "7":
                    choosenNumberOfDays = 7;
                    Console.WriteLine("Ok, you will sell lemonade for one week. Good luck!");
                    return choosenNumberOfDays;
                case "14":
                    choosenNumberOfDays = 14;
                    Console.WriteLine("Ok, you will sell lemonade for two weeks. Good luck!");
                    return choosenNumberOfDays;
                case "21":
                    choosenNumberOfDays = 21;
                    Console.WriteLine("Ok, you will sell lemonade for three weeks. Good luck!");
                    return choosenNumberOfDays;
                case "28":
                    choosenNumberOfDays = 28;
                    Console.WriteLine("Ok, you will sell lemonade for one month. Good luck!");
                    return choosenNumberOfDays;
                case "help":
                    UserInterface.Instructions();
                    ChooseNumberOfDays();
                    return choosenNumberOfDays;
                default:
                    Console.WriteLine("Invalid game length. Please try again.");
                    Console.WriteLine(" ");
                    ChooseNumberOfDays();
                    return choosenNumberOfDays;
            }
        }
        private void StartTheDay()
        {
            int loopDurration;
            for (loopDurration = 1 ; loopDurration <= choosenNumberOfDays; loopDurration++)
            {
                startDailySale = false;
                Console.WriteLine("It's day {0}", loopDurration);
                entrepreneur.GetPlayerMoney();
                Console.WriteLine("You have ${0}",entrepreneur.GetPlayerMoney());
                while (startDailySale == false && LocalWeather.WeatherHasBeenCreated() == false)
                {
                    UserInterface.DailyMenuOptions();
                    DailyMenuChoice();
                }
                Recipe.ChangeLemonadeRecipe();
                int passersBy;
                for(passersBy = 1; passersBy < Buyer.GetCustomers(); passersBy++)
                {
                    Buyer.TotalLemonadeBuyers(Buyer.CalculateBuyerInterest(LocalWeather.GetWeather(), LocalWeather.GetTemperature()), Recipe.LemonadePotency());
                }
                Console.WriteLine("You sold lemonade to {0} customers!", Buyer.GetNumberOfBuyers());
                PlayerInventory.EmptyIceInventory();
            }
        }
        private bool DailyMenuChoice()
        {
            switch (Console.ReadLine().ToLower())
            {
                case "check the weather":
                    LocalWeather.RunWeather();
                    break;
                case "check inventory":
                    PlayerInventory.GetAllInventories();
                    break;
                case "go to the store":
                    Supermarket.StoreMenu();
                    Supermarket.StoreChoice(entrepreneur, PlayerInventory);
                    break;
                case "start selling lemonade":
                    StartDailySale();
                    break;
                case "help":
                    UserInterface.Instructions();
                    break;
                default:
                    Console.WriteLine("Invalid entry. Please select where you would like to go.");
                    Console.WriteLine("Enter 'help' for more information.");
                    DailyMenuChoice();
                    break;
            }
            return startDailySale;
        }
        private bool StartDailySale()
        {
            startDailySale = true;
            return startDailySale;
        }
    }
}