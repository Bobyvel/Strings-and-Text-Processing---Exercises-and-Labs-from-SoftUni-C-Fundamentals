using System;
using System.Text.RegularExpressions;

namespace _05.OnlyLetters1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, @"(\d+)([A-Za-z])");

            foreach (Match match in matches)
            {
               input = Regex.Replace(input, match.Groups[1].ToString(), match.Groups[2].ToString());
            }

            Console.WriteLine(input);
        }
    }
}
