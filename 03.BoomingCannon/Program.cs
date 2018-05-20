using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.BoomingCannon
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var text = Console.ReadLine();
            
            var distance = input[0];
            var elementsToDestroy = input[1];
            var cannon = "\\<<<";
            var result = new List<string>();
            var counter = 0;

            
            while (true)
            {
                var index = text.IndexOf(cannon, counter);

                if (index == -1)
                {
                    break;
                }

                counter = index + 1;
                var nextIndex = text.IndexOf(cannon, counter);
                var startIndex = index + 4;
                var countChars = nextIndex - startIndex;
                var currentCannon = nextIndex != -1 ? text.Substring(startIndex, countChars) : text.Substring(startIndex);

                if (currentCannon.Length > distance)
                {
                   result.Add(new string(currentCannon.Skip(distance).Take(elementsToDestroy).ToArray()));
                }
               
            }

            Console.WriteLine(string.Join("/\\", result));
            
        }
    }
}
