using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonadeStand
{
    class Weather
    {

        string weatherToday;
        int temperature;
        public string GetWeatherToday()
        {
            return weatherToday;
        }
        public string WeatherGenerator()
        {
            List<string> Weather = new List<string> {"Thunderstorm", "Overcast", "Partly Cloudy", "Sunny"};
            int weather = new Random().Next(Weather.Count);
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
        public int TemperatureGenerator()
        {
            Random random = new Random();
            temperature = random.Next(40, 100);
            ForcastForToday();
            return temperature;
        }
        public void ForcastForToday()
        {
            Console.WriteLine("");
            Console.WriteLine("Today it's {0} and {1}°F", weatherToday, temperature);
            Console.WriteLine("");
        }
    }
}
