using System;


namespace APIs_and_JSON_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {

            RonVSKayneAPI.Conversation();

            Console.WriteLine("--------------------------");

            OpenWeatherMapAPI.GetWeather();
        }
    }
}
