using System;
using System.Text.RegularExpressions;

namespace _01.ExtractEmails
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var emails = Regex.Matches(input, @"(?<=\s)[a-z\d]+[\-\.\w]?[a-z\d]+@[a-z]+[\-]?[a-z]+(\.[a-z]+)+");

            foreach (var result in emails)
            {
                Console.WriteLine(result);
            }
        }
    }
}
