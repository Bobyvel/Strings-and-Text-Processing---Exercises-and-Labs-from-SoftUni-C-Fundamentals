using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _06.EmailStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var lines = int.Parse(Console.ReadLine());
            var validEmails = new Dictionary<string, HashSet<string>>();

            for (int i = 0; i < lines; i++)
            {
                var email = Console.ReadLine();
                var matches = Regex.Match(email, @"^([A-Za-z]{5,})@([a-z]{3,}(.com|.bg|.org)+)$");


                if (matches.Success)
                {
                    var username = matches.Groups[1].ToString();
                    var domain = matches.Groups[2].ToString();

                    if (!validEmails.ContainsKey(domain))
                    {
                        validEmails[domain] = new HashSet<string>();
                    }

                    validEmails[domain].Add(username);

                }

            }

            foreach (var domain in validEmails.OrderByDescending(d => d.Value.Count))
            {
                Console.WriteLine($"{domain.Key}:");

                foreach (var username in domain.Value)
                {
                    Console.WriteLine("### {0}", username);
                }
            }
        }
    }
}
