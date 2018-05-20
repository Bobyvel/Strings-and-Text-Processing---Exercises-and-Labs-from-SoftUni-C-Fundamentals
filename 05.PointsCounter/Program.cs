using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _05.PointsCounter
{
    class Program
    {
        static void Main(string[] args)
        {
            var dictionary = new Dictionary<string, Dictionary<string, int>>();
            var input = Console.ReadLine();

            while (input != "Result")
            {
                input = input.Replace("@", string.Empty).Replace("%", string.Empty).Replace("$", string.Empty).Replace("*", string.Empty);

                var tolkens = input.Split('|');

                var player = string.Empty;
                var team = string.Empty;
                if (tolkens[0].Last() > 96)
                {
                    player = tolkens[0];
                    team = tolkens[1];
                }
                else
                {
                    player = tolkens[1];
                    team = tolkens[0];
                }

                var points = int.Parse(tolkens[2]);

                if (!dictionary.ContainsKey(team))
                {
                    dictionary.Add(team, new Dictionary<string, int>());
                }
                
                dictionary[team][player] = points;

                 
                input = Console.ReadLine(); 
            }

            foreach (var team in dictionary.OrderByDescending(t => t.Value.Values.Sum()))
            {
                Console.WriteLine($"{team.Key} => {team.Value.Values.Sum()}");

                foreach (var player in team.Value.OrderByDescending(t => t.Value).Take(1))
                {
                    Console.WriteLine($"Most points scored by {player.Key}");
                }
            }

        }
    }
}
