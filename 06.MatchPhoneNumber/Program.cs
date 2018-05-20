using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.MatchPhoneNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var phones = Regex.Matches(input, @"\+359 2 [\d+]{3} [\d+]{4}|\+359-2-[\d+]{3}-[\d+]{4}\b").Cast<Match>().Select(p => p.ToString()).ToArray();

            Console.WriteLine(string.Join(", ", phones));
        }
    }
}
