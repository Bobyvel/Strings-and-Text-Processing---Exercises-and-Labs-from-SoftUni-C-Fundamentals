using System;
using System.Text.RegularExpressions;

namespace _08.MatchDates
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var pattern = @"(?<day>[\d]{2})(\/|-|.)(?<month>[A-Z][a-z]+)\1(?<year>[\d]{4})";

            var matches = Regex.Matches(input, pattern);

            foreach (Match match in matches)
            {
                var day = match.Groups["day"].ToString();
                var month = match.Groups["month"].ToString();
                var year = match.Groups["year"].ToString();

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");

            }
        }
    }
}
