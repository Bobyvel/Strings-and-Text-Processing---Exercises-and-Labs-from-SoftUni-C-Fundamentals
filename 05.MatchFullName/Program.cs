using System;
using System.Text.RegularExpressions;

namespace _05.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var names = Regex.Matches(input, @"\b([A-Z][a-z]+) ([A-Z][a-z]+)\b");

            foreach (var match in names)
            {
                Console.Write(match + " ");
            }
        }
    }
}
