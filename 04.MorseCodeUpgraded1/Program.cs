using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _04.MorseCodeUpgraded1
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');
            var result = new StringBuilder();
            foreach (var word in input)
            {
              
                var countOf1 = Regex.Matches(word, "1").Count;
                var countOf0 = Regex.Matches(word, "0").Count;
                
                var sequences = Regex.Matches(word, @"(?<count1>1{2,})|(?<count2>0{2,})");

                var letterNumber = countOf1 * 5 + countOf0 * 3;

                foreach (Match group in sequences)
                {
                    letterNumber += group.Length;
                }

                result.Append((char) letterNumber);
            }

            Console.WriteLine(result);
        }
    }
}
