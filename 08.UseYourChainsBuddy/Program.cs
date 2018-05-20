using System;
using System.Text.RegularExpressions;

namespace _08.UseYourChainsBuddy
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var maches = Regex.Matches(input, @"<p>(?<text>.*?)<\/p>");

            foreach (Match text in maches)
            {
                var textSpace = Regex.Replace(text.Groups["text"].Value, @"[^a-z0-9]", " ");
                var validText = Regex.Replace(textSpace, @"\s+", " ").ToCharArray();

                for (int i = 0; i < validText.Length; i++)
                {
                    if (validText[i] >= 97 && validText[i] <= 109)
                    {
                        validText[i] = (char)(validText[i] + 13);
                    }
                    else if (validText[i] >= 110 && validText[i] <= 122)
                    {
                        validText[i] = (char)(validText[i] - 13);
                    }
                    
                }

                Console.Write(validText);

            }

            Console.WriteLine();
        }
    }
}
