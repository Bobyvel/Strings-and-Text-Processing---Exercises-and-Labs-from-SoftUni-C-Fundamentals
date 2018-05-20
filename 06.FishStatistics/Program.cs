using System;
using System.Text;
using System.Text.RegularExpressions;

namespace _06.FishStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var fishes = Regex.Matches(input, @"(?<tail>>*)<(?<body>\(+)(?<eye>'|-|x)>");

            if (fishes.Count == 0)
            {
                Console.WriteLine("No fish found."); 
                return;
            }
            var counter = 1;
            
            foreach (Match fish in fishes)
            {
                var tail = fish.Groups["tail"].Value;
                var body = fish.Groups["body"].Value;
                var eye = fish.Groups["eye"].Value;

               var tailSize = tail.Length * 2;
                if (tail.Length > 5)
                {
                    tail = "Long";
                }
                else if(tail.Length > 1)
                {
                    tail = "Medium";
                }
                else if(tail.Length == 1)
                {
                    tail = "Short";
                }
                else if(tail.Length == 0)
                {
                    tail = "None";
                }

                var bodySize = body.Length * 2;
                if (body.Length > 10)
                {
                    body = "Long";
                }
                else if(body.Length > 5)
                {
                    body = "Medium";
                }
                else
                {
                    body = "Short";
                }

                switch (eye)
                {
                    case "'":
                        eye = "Awake";
                        break;
                    case "-":
                        eye = "Asleep";
                        break;
                    case "x":
                        eye = "Dead";
                        break;
                        
                }

                
                Console.WriteLine($"Fish {counter++}: {fish}");
                if (tailSize == 0)
                {
                    Console.WriteLine($"Tail type: {tail}");
                }
                else
                {
                    Console.WriteLine($"Tail type: {tail} ({tailSize} cm)"); 
                }
                Console.WriteLine($"Body type: {body} ({bodySize} cm)");
                Console.WriteLine($"Status: {eye}");

                
            }
        }
    }
}
