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


        HttpClient client = new HttpClient();
        public string RonSwanson()
        {
            string ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            string ronResponse = client.GetStringAsync(ronURL).Result;

            JArray ronQuote = JArray.Parse(ronResponse);

            return ronQuote[0].ToString();
        }
        public string Kayne()
        {
            string kayneURL = "https://api.kanye.rest/";
            string kayneResponse = client.GetStringAsync(kayneURL).Result;

            JObject kayneQuote = JObject.Parse(kayneResponse);

            return kayneQuote["quote"].ToString();
        }
    }
}
