using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _04.Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;
            var weather = new Dictionary<string, Weather>();
            while ((input = Console.ReadLine()) != "end")
            {
                var matches = Regex.Match(input, @"(?<city>[A-Z]{2})(?<temp>\d+\.\d+)(?<weather>[A-Za-z]+)\|");
                if (!matches.Success)
                {
                    continue;
                }
                var city = matches.Groups["city"].Value;
                var temp = double.Parse(matches.Groups["temp"].Value);
                var weatherType = matches.Groups["weather"].Value;

                var currentWeather = new Weather(temp, weatherType);

                weather[city] = currentWeather;
                
            }

            foreach (var city in weather.OrderBy(t => t.Value.temp))
            {
                Console.WriteLine($"{city.Key} => {city.Value.temp:F2} => {city.Value.wheatherType}");
            }
        }

        class Weather
        {
            public double temp { get; set; }
            public string wheatherType { get; set; }

            public Weather(double temp, string wheatherType)
            {
                this.temp = temp;
                this.wheatherType = wheatherType;
            }
        }
    }
}
