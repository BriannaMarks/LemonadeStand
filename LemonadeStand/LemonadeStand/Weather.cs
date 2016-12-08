using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {
        bool weatherHasBeenCreated;
        int weatherCreatedToday;
        string weatherToday;
        int temperature;
        int weather;
        private string WeatherGenerator()
        {
            List<string> Weather = new List<string> {"Thunderstorm", "Overcast", "Partly Cloudy", "Sunny"};
            weather = new Random().Next(Weather.Count);
            switch (weather)
            {
                case 0:
                    weatherToday = "Thunderstorming";
                    TemperatureGenerator();
                    break;
                case 1:
                    weatherToday = "Overcast";
                    TemperatureGenerator();
                    break;
                case 2:
                    weatherToday = "Partly Cloudy";
                    TemperatureGenerator();
                    break;
                case 3:
                    weatherToday = "Sunny";
                    TemperatureGenerator();
                    break; 
                default:
                    return WeatherGenerator();
            }
            return weatherToday;
        }
        private int TemperatureGenerator()
        {
            Random random = new Random();
            temperature = random.Next(40, 100);
            ForcastForToday();
            return temperature;
        }
        private void ForcastForToday()
        {
            Console.WriteLine("");
            Console.WriteLine("Today it's {0} and {1}°F", weatherToday, temperature);
            Console.WriteLine("");
        }
        public void RunWeather()
        {
            if (weatherCreatedToday <= 0)
            {
                WeatherGenerator();
                weatherCreatedToday++;
                weatherHasBeenCreated = true;
            }
            else
            {
                ForcastForToday();
            }
        }
        public int GetWeather()
        {
            return weather;
        }
        public int GetTemperature()
        {
            return temperature;
        }
        public bool WeatherHasBeenCreated()
        {
            return weatherHasBeenCreated;
        }
    }
}