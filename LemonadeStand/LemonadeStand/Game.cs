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
        Player Entrepreneur;
        Store Supermarket;
        Inventory PlayerInventory;
        Weather LocalWeather;

        int choosenNumberOfDays;
        bool startDailySale;
        public void RunLemonadeStand()
        {
            GameDay = new Day();
            Entrepreneur = new Player();
            Supermarket = new Store();
            PlayerInventory = new Inventory();
            LocalWeather = new Weather();

            IntroText();
            OfferInstructions();
            ChooseNumberOfDays();
            Entrepreneur.PlayerStartingMoney();
            PlayerInventory.EmptyAllInventory();
            StartTheDay();

            Console.ReadKey();
        }
        private void IntroText()
        {
            Console.WriteLine("Welcome to Lemonade Stand!");
        }
        public void OfferInstructions()
        {
            string offerInstructions;
            Console.WriteLine("Would you like to read the instructions?");
            offerInstructions = Console.ReadLine().ToLower();

            switch (offerInstructions)
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
                default:
                    Console.WriteLine("Invalid game length. Please try again.");
                    Console.WriteLine(" ");
                    ChooseNumberOfDays();
                    return choosenNumberOfDays;
            }
        }
        public void StartTheDay()
        {
            int i;
            for (i = 1 ; i <= choosenNumberOfDays; i++)
            {
                startDailySale = false;
                Console.WriteLine("It's day {0}", i);
                Console.WriteLine("You have ${0}", Entrepreneur.GetPlayerMoney());
                while (startDailySale == false)
                {
                    UserInterface.DailyStartChoices();
                    PlayerStartChoice();
                }


            }
        }
        private bool PlayerStartChoice()
        {
            switch (Console.ReadLine().ToLower())
            {
                case "check the weather":
                    LocalWeather.WeatherGenerator();
                    break;
                case "check your supply inventory":
                    PlayerInventory.GetAllInventories();
                    break;
                case "go to the store":

                case "start selling lemonade":
                    StartDailySale();
                    break;
                //case "save your current progress":
                case "help":
                    UserInterface.Instructions();
                    break;
                default:
                    Console.WriteLine("Invalid entry. Please select where you would like to go.");
                    Console.WriteLine("Enter 'help' for more information.");
                    PlayerStartChoice();
                    break;

            }
            return startDailySale;
        }
        public bool StartDailySale()
        {
            startDailySale = true;
            return startDailySale;
        }
    }
}