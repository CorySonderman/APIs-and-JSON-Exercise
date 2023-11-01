using Newtonsoft.Json.Linq;
using System.Reflection.Emit;
using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)

        {
            //RonVSKanyeVSMe
            //__________________________________________

            {
                // Code to create typing effect
                int typingSpeed = 25; 

                static void TypeOutText(Func<string> textFunction, int speed)
                {
                    string text = textFunction();
                    foreach (char c in text)
                    {
                        Console.Write(c);
                        Thread.Sleep(speed);
                    }
                    Console.WriteLine();
                }
                for (int i = 0; i < 3; i++)
                {
                    TypeOutText(() => RonVSKanyeAPI.KanyeWestQuote(), typingSpeed);
                    TypeOutText(() => RonVSKanyeAPI.RonSwansonQuote(), typingSpeed);
                    TypeOutText(() => MyQuotes.GetRandomQuote("Cory"), typingSpeed);
                    Console.WriteLine();
                   
                }

                for (int i = 0; i < 3; i++)
                {
                    TypeOutText(() => RonVSKanyeAPI.RonSwansonQuote(), typingSpeed);
                    TypeOutText(() => RonVSKanyeAPI.KanyeWestQuote(), typingSpeed);
                    TypeOutText(() => MyQuotes.GetRandomQuote("Cory"), typingSpeed);
                    Console.WriteLine();
                    
                }
            }

     

            //for (int i = 0; i < 5; i++)
            //{

            //    RonVSKanyeAPI.KanyeWestQuote();
            //    RonVSKanyeAPI.RonSwansonQuote();
            //    Console.WriteLine(MyQuotes.GetRandomQuote("Cory"));
            //    Console.WriteLine();
            //}

            //for (int i = 0; i < 5; i++)
            //{

            //    RonVSKanyeAPI.RonSwansonQuote();
            //    RonVSKanyeAPI.KanyeWestQuote();
            //    Console.WriteLine(MyQuotes.GetRandomQuote("Cory"));
            //    Console.WriteLine();
            //}

            //_______________________________________________

            //Weather Map
            var key = File.ReadAllText("appsettings.json");
            var APIKey = JObject.Parse(key).GetValue("APIKey").ToString();
            string zipCode;
            do
            {
                Console.WriteLine("Enter you zipcode and I will get the temperature for you. ");
                zipCode = Console.ReadLine();

                if (zipCode.Length != 5 || !int.TryParse(zipCode, out _))
                {
                    Console.WriteLine("That is not a valid zip code. Please enter your 5-digit zip code.");
                }
            } while (zipCode.Length != 5 || !int.TryParse(zipCode, out _));

            var apiCall = $"https://api.openweathermap.org/data/2.5/weather?zip={zipCode}&units=imperial&appid={APIKey}";
            var temp = OpenWeatherMapAPI.GetTemp(apiCall);
            var city = OpenWeatherMapAPI.GetCity(apiCall);

            Console.WriteLine();
            Console.WriteLine();

            if (temp >= 70)
            {
                Console.WriteLine($"It's currently {temp}° in {city}. Looks like t-shirt weather!");
            }
            else if (temp >= 40)
            {
                Console.WriteLine($"It's currently {temp}° in {city}. It's a little chilly, you might want a jacket or a long-sleeve shirt.");
            }
            else
            {
                Console.WriteLine($"It's currently {temp}° in {city}. It's pretty cold. Better grab your coat.");
            }
        }
    }
}
