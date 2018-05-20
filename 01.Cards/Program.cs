using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _01.Cards
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var validCards = new List<string>();

            var result = Regex.Matches(input, @"(?<power>[1]?[0-9JQKA])(?<suit>[SHDC])");
                                                    
            foreach (Match match in result)
            {
                
                if (int.TryParse(match.Groups["power"].Value, out var power))
                {
                    if (power < 2 || power > 10)
                    {
                        continue;
                    }
                }

                validCards.Add(match.Value);
            }

            Console.WriteLine(string.Join(", ", validCards));
        }
    }
}
