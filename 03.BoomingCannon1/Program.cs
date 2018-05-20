using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.BoomingCannon1
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

            var matches = Regex.Matches(text, @"(?<=\\<<<)(.+?)(?=\\<<<|$)");

            foreach (Match currentText in matches)
            {
                if (currentText.Length >= distance + elementsToDestroy)
                {
                    result.Add(currentText.Value.Substring(distance, elementsToDestroy));
                }
                else if (currentText.Length > distance)
                {
                    result.Add(currentText.Value.Substring(distance));
                }
            }

            Console.WriteLine(string.Join("/\\", result));
        }
    }
}
