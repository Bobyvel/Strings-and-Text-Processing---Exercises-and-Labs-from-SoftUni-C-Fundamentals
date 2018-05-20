using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _02.WordEncounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var filter = Console.ReadLine();
            var words = new List<string>();
            var input = String.Empty;
            while ((input = Console.ReadLine()) != "end")
            {
                var validSentence = Regex.Match(input, @"^([A-Z].*[!\.\?])$");
                if (!validSentence.Success)
                {
                   continue; 
                }
                var matches = Regex.Matches(input, @"\w+");
                foreach (Match match in matches)
                {
                    var word = match.ToString();
                    var pattern = filter[0].ToString();
                    var filterCounter = int.Parse(filter[1].ToString());

                    var count = Regex.Matches(word, pattern).Count;
                    if (count >= filterCounter)
                    {
                        words.Add(word);
                    }
                }
               
            }

            Console.WriteLine(string.Join(", ", words));
        }
    }
}
