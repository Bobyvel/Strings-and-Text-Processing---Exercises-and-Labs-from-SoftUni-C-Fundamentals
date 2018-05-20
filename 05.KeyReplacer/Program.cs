using System;
using System.Text.RegularExpressions;

namespace _05.KeyReplacer
{
    class Program
    {
        static void Main(string[] args)
        {
            var keys = Console.ReadLine();
            var keyMathes = Regex.Match(keys, @"(?<startKey>[A-Za-z]+).+[\<\|\\](?<endKey>[A-Za-z]+)");

            var startKey = keyMathes.Groups["startKey"].Value;
            var endKey = keyMathes.Groups["endKey"].Value;

            var input = Console.ReadLine();
            var text = Regex.Matches(input, $@"{startKey}(?<text>\w*?){endKey}");
            var result = string.Empty;
            foreach (Match match in text)
            {
                result += match.Groups["text"].Value;
            }

            Console.WriteLine(result.Length == 0 ? "Empty result" : result);
        }
    }
}
