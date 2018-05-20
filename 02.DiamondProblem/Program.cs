using System;
using System.Text.RegularExpressions;

namespace _02.DiamondProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            var hasDiamond = false;
            var matches = Regex.Matches(input, @"<\w+>");

            foreach (var match in matches)
            {
                var diamond = match.ToString();
                var carat = 0;
                for (int i = 0; i < diamond.Length; i++)
                {
                    if (char.IsDigit(diamond[i]))
                    {
                        carat += int.Parse(diamond[i].ToString());
                    }
                }

                hasDiamond = true;
                Console.WriteLine($"Found {carat} carat diamond");
                

            }

            if (!hasDiamond)
            {
                Console.WriteLine($"Better luck next time");
            }

        }
    }
}
