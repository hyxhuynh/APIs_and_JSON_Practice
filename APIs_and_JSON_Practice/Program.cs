using System;


namespace APIs_and_JSON_Practice
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RonVSKayneAPI conversation = new RonVSKayneAPI();
            for (int i = 0; i <= 5; i++)
            {
                Console.WriteLine($"Ron Swanson: {conversation.RonSwanson()}\n");
                Console.WriteLine($"Kayne: {conversation.Kayne()}\n");
            }

            Console.WriteLine("--------------------------");

            OpenWeatherMapAPI weather = new OpenWeatherMapAPI();
            weather.GetWeather();
        }
    }
}
