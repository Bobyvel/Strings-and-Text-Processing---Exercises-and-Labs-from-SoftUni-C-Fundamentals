using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace _08.Commits
{
    class Program
    {
        static void Main(string[] args)
        {
            var pattern = @"^https:\/\/github.com\/(?<user>[A-Za-z0-9-]+)\/(?<repo>[A-Za-z-_]+)\/commit\/(?<hash>[0-9A-Fa-f]{40}),(?<message>[^\n]*),(?<additions>\d+),(?<deletions>\d+)$";

            var result = new SortedDictionary<string, SortedDictionary<string, List<Commits>>>();

            var input = string.Empty;
            
            while ((input = Console.ReadLine()) != "git push")
            {
                var matches = Regex.Match(input, pattern);

                if (!matches.Success)
                {
                   continue; 
                }
                var user = matches.Groups["user"].Value;
                var repo = matches.Groups["repo"].Value;
                var hash = matches.Groups["hash"].Value;
                var message = matches.Groups["message"].Value;
                var additions = int.Parse(matches.Groups["additions"].Value);
                var deletions = int.Parse(matches.Groups["deletions"].Value);

                if (!result.ContainsKey(user)) //take the main key
                {
                    result[user] = new SortedDictionary<string, List<Commits>>();
                }

                if (!result[user].ContainsKey(repo)) //take the key of nested dictionary
                {
                    result[user][repo] = new List<Commits>();
                }

                var currentCommit = new Commits(hash, message, additions, deletions); 

                result[user][repo].Add(currentCommit); 

            }

            var additionsTotal = 0;
            var deletionsTotal = 0;

            foreach (var user in result)
            {
                Console.WriteLine($"{user.Key}:");

                foreach (var repo in result[user.Key])
                {
                    Console.WriteLine($"  {repo.Key}:");

                    foreach (var commit in repo.Value)
                    {
                        Console.WriteLine($"    commit {commit.Hash}: {commit.Message} ({commit.Additions} additions, {commit.Deletions} deletions)");

                        additionsTotal += commit.Additions;
                        deletionsTotal += commit.Deletions;
                    }

                    Console.WriteLine($"    Total: {additionsTotal} additions, {deletionsTotal} deletions");
                    additionsTotal = 0;
                    deletionsTotal = 0;
                }
            }
        }

        class Commits
        {
            public string Hash { get; set; }

            public string Message { get; set; }

            public int Additions { get; set; }

            public int Deletions { get; set; }

            public Commits(string hash, string message, int additions, int deletions)
            {
                this.Hash = hash;
                this.Message = message;
                this.Additions = additions;
                this.Deletions = deletions;
            }
        }
    }
}
