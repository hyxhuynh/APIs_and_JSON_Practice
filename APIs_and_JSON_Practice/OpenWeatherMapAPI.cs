﻿using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIs_and_JSON_Practice
{
    public class OpenWeatherMapAPI
    {
        
        public static void GetWeather() 
        {
            HttpClient client = new HttpClient();
            Console.WriteLine("Enter City Name:");
            string cityName = Console.ReadLine();

            string APIKey = "3348f655915a59e3040c3e2a407583c3";

            string weatherURL = $"https://api.openweathermap.org/data/2.5/weather?q={cityName}&appid={APIKey}&units=imperial";
            string weatherInfoStr = client.GetStringAsync(weatherURL).Result;

            JObject weatherParse = JObject.Parse(weatherInfoStr);

            Console.WriteLine($"\nHere is the weather forecast for your city:");
            Console.WriteLine($"City Name: {weatherParse["name"]}");
            Console.WriteLine($"Weather Descriptionn: {weatherParse["weather"][0]["description"]}");
            Console.WriteLine($"Temperature: {weatherParse["main"]["temp"]} Fahrenheit");
            Console.WriteLine($"Feels Like: {weatherParse["main"]["feels_like"]} Fahrenheit");
            Console.WriteLine($"Humidity: {weatherParse["main"]["humidity"]}%");
            Console.WriteLine($"Wind Speed: {weatherParse["wind"]["speed"]} MPH");

        }
    }
}
