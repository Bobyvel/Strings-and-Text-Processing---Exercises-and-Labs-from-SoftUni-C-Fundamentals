using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _07.CapitalizeWords
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"[a-zA-Z0-9']+";
            var input = Console.ReadLine();
            var result = new StringBuilder();
            while (input != "end")
            {
                var matches = Regex.Matches(input, pattern);

                foreach (Match match in matches)
                {
                    var word = match.ToString();

                    for (int i = 0; i < word.Length; i++)
                    {
                        if (i == 0)
                        {
                            result.Append(word[i].ToString().ToUpper());
                        }
                        else
                        {
                            result.Append(word[i].ToString().ToLower());
                        }

                        
                    }

                    result.Append(", ");
                }
                
                Console.WriteLine(result.Remove(result.Length-2, 2));
                result.Clear();

                input = Console.ReadLine();
            }
        }
    }
}
