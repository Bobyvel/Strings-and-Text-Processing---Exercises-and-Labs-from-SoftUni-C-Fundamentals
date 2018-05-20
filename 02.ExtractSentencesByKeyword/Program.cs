using System;
using System.Text.RegularExpressions;

namespace _02.ExtractSentencesByKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            var keyword = Console.ReadLine();
            var sentences = Console.ReadLine();

            var matches = Regex.Matches(sentences, $@"[^!?.]*\W{keyword}\W[^!?.]*");

            foreach (var sentence in matches)
            {
                Console.WriteLine(sentence.ToString().Trim());
            }
        }
    }
}
