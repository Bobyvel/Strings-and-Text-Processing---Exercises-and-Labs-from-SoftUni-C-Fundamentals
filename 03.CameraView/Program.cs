using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace _03.CameraView
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var toSkip = numbers[0];
            var toTake = numbers[1];

            var input = Console.ReadLine();
            var views = Regex.Matches(input, @"(?<=\|<)(.+?)(?=\|<|$)");

            var cameraViews = new List<string>();
            foreach (Match view in views)
            {
                cameraViews.Add(new string(view.Value.Skip(toSkip).Take(toTake).ToArray()));
            }

            Console.WriteLine(string.Join(", ", cameraViews));
        }
    }
}
