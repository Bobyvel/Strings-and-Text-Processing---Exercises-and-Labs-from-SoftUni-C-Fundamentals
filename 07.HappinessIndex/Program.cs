using System;
using System.Text.RegularExpressions;

namespace _07.HappinessIndex
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var happyPattern = @"(?<happy>[c\*\[\(]:|:[\)D\]\}\*]|[\[];|;[\}\]\)])";
            var sadPattern = @"(?<sad>[D\)\]]:|:[\(\[\{c]|[\]];|;[\{\[\(])";

            var happyEmogi = Regex.Matches(input, happyPattern).Count;
            var sadEmogi = Regex.Matches(input, sadPattern).Count;

            var happyIndex = happyEmogi / (double)sadEmogi;
            var emogi = string.Empty;
            if (happyIndex >= 2)
            {
                emogi = ":D";
            }
            else if (happyIndex > 1)
            {
                emogi = ":)";
            }
            else if (happyIndex == 1)
            {
                emogi = ":|";
            }
            else
            {
                emogi = ":(";
            }

            Console.WriteLine($"Happiness index: {happyIndex:F2} {emogi}");
            Console.WriteLine($"[Happy count: {happyEmogi}, Sad count: {sadEmogi}]");
        }
    }
}
