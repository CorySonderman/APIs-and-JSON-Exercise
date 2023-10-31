using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class RonVSKanyeAPI
    {
        public static void RonSwansonQuote()
        {
            var client = new HttpClient();
            var ronURL = "https://ron-swanson-quotes.herokuapp.com/v2/quotes";
            var ronResponse = client.GetStringAsync(ronURL).Result;
            var ronQuote = JArray.Parse(ronResponse).ToString().Replace('[', ' ').Replace(']', ' ').Trim();
            ronQuote = ronQuote.Trim('"');
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine($"Ron: {ronQuote}");
           Console.ResetColor();

        }

        public static void KanyeWestQuote()
        {
            var client = new HttpClient();
            var kanyeURL = "https://api.kanye.rest/";
            var kanyeResponse = client.GetStringAsync(kanyeURL).Result;
            var kanyeQuote = JObject.Parse(kanyeResponse).GetValue("quote").
                ToString();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"Kanye: {kanyeQuote}");
            Console.ResetColor();
        }
    }
}
