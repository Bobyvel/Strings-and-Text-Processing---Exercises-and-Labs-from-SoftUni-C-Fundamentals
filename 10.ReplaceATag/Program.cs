using System;
using System.Text.RegularExpressions;

namespace _10.ReplaceATag
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = string.Empty;

            while ((input = Console.ReadLine()) != "end")
            {
                var replace = Regex.Replace(input, @"<a.*href.*=(.*)>(.*)<\/a>", "[URL href=$1]$2[/URL]");

                Console.WriteLine(replace);


            }
        }
    }
}
