using Newtonsoft.Json.Linq;
using System.Text.Json.Nodes;

namespace APIsAndJSON
{
    public class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 5; i++)
            {
                RonVSKanyeAPI.KanyeWestQuote();
                RonVSKanyeAPI.RonSwansonQuote();
                Console.WriteLine();
            }

            for (int i = 0; i < 5; i++)
            {
                RonVSKanyeAPI.RonSwansonQuote();
                RonVSKanyeAPI.KanyeWestQuote();
                Console.WriteLine();
            }
        }
    }
}
