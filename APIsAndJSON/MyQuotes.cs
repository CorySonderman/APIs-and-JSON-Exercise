using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APIsAndJSON
{
    public class MyQuotes
    {
        private static List<string> cory = new List<string>
    {
        "Has anyone ever told you that you're not very bright?",
        "Well... If life was easy it would be boring.",
        "The secret to a happy life is easy... Learn to love detours.",
        "Life isn't fair... Never was, never is, and never will be. It's up to you to either accept it or use it as an excuse.",
        "You're so inspirational.",
        "Well my old Sensei used to always tell up. Suck it up butter cup."
    };

        private static List<string> quotes = new List<string>
    {
        "Has anyone ever told you that you're not very bright?",
        "Well... If life was easy it would be boring.",
        "The secret to a happy life is easy... Learn to love detours.",
        "Life isn't fair... Never was, never is, and never will be. It's up to you to either accept it or use it as an excuse.",
        "You're so inspirational."
    };

        private static Random random = new Random();

        public static string GetRandomQuote(string Cory)
        {
            int index = random.Next(quotes.Count);
            string quote = quotes[index];
            return $"{Cory}: {quote}";
        }
    }
}
