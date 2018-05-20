using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _07.MatchHexadecimalNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, @"\b[0x]*[0-9A-F]+\b").Cast<Match>().Select(m => m.ToString()).ToArray();

            Console.WriteLine(string.Join(" ", matches));
        }
    }
}
