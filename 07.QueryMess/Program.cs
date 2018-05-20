using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _07.QueryMess
{
    class Program
    {
        static void Main(string[] args)
        {
            var result = new Dictionary<string, List<string>>();
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "END")
            {
                var matches = Regex.Matches(input, @"([^&?]+)=([^&?]+)");

                foreach (Match match in matches)
                {
                    var field = Regex.Replace(match.Groups[1].Value, @"(%20|\+)+"," ").Trim();
                    var value = Regex.Replace(match.Groups[2].Value, @"(%20|\+)+", " ").Trim();

                    if (!result.ContainsKey(field))
                    {
                        result[field] = new List<string>();
                    }

                    result[field].Add(value);
                }

                foreach (var output in result)
                {
                    Console.Write($"{output.Key}=[{string.Join(", ", output.Value)}]");
                }

                Console.WriteLine();
                result.Clear();
                
            }

        }
    }
}
