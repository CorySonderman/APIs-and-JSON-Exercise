using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.WebSockets;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class OpenWeatherMapAPI
    {
        public static double GetTemp(string apiCall)
        {
            var client = new HttpClient();
            var userInput = client.GetStringAsync(apiCall).Result;
            var temp = double.Parse(JObject.Parse(userInput)["main"]["temp"].ToString());
            return temp;
           
        }
        public static string GetCity(string apiCall)
        {
            var client = new HttpClient();
            var userInput = client.GetStringAsync(apiCall).Result;
            var city = JObject.Parse(userInput)["name"].ToString();
            return city;

        }

    }
}
