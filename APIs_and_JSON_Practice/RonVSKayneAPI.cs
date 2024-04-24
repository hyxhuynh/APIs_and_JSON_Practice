using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json.Linq;

namespace APIs_and_JSON_Practice
{
    public class RonVSKayneAPI
    {
        public static void RonSwanson()
        {
            HttpClient client = new HttpClient();
            string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            string ronResponse = client.GetStringAsync(ronURL).Result;

            JArray ronQuote = JArray.Parse(ronResponse);

            Console.WriteLine($"Ron Swanson: {ronQuote[0]}");
        }
        public static void Kayne()
        {
            HttpClient client = new HttpClient();
            string kayneURL = "https://api.kanye.rest/";
            string kayneResponse = client.GetStringAsync(kayneURL).Result;

            JObject kayneQuote = JObject.Parse(kayneResponse);

            Console.WriteLine($"Kayne: {kayneQuote["quote"]}");
        }

        public static void Conversation()
        {
            for (int i = 0; i < 5; i++)
            {
                RonVSKayneAPI.RonSwanson();
                RonVSKayneAPI.Kayne();
                Console.WriteLine();
            }
        }
    }
}
