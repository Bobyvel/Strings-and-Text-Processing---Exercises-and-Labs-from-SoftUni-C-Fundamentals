using System;
using System.Text.RegularExpressions;

namespace _06.ValidUsernames
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var validUsernames = Regex.Matches(input, @"\b[A-Za-z]\w{2,24}\b");

            if (validUsernames.Count != 0)
            {

                var maxSum = 0;
                var longestUsernames = string.Empty;

                for (int i = 1; i < validUsernames.Count; i++)
                {
                    var sum = validUsernames[i - 1].Length + validUsernames[i].Length;

                    if (maxSum < sum)
                    {
                        maxSum = sum;
                        longestUsernames = validUsernames[i - 1].Value + Environment.NewLine + validUsernames[i].Value;

                    }
                }

                Console.WriteLine(longestUsernames);

            }


        }
    }
}
