using System;
using System.Linq;
using System.Text.RegularExpressions;

namespace _09.MatchNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var numbers = Regex.Matches(input, @"(^|(?<=\s))[\-]*[\d]+[\.]*[\d]*($|(?=\s))").Cast<Match>()
                .Select(m => m.ToString()).ToArray();

            Console.WriteLine(string.Join(" ", numbers));
        }
    }
}
