using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.EmailMe
{
    class Program
    {
        static void Main(string[] args)
        {
            var mail = Console.ReadLine();

            var matches = Regex.Match(mail, @"(?<before>.+)@(?<after>.+)");

            var sumBefore = matches.Groups["before"].ToString().Select(c => (int)c).Sum();
            var sumAfter = matches.Groups["after"].ToString().Select(c => (int)c).Sum();

            var result = (sumBefore - sumAfter) >= 0 ? "Call her!" : "She is not the one.";

            Console.WriteLine(result);


        }
    }
}
