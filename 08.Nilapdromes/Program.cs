using System;
using System.Text.RegularExpressions;

namespace _08.Nilapdromes
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            

            while (input != "end")
            {
                var regex = Regex.Match(input, @"\b(?<border>\w+)(?<middle>\w+)(\k<border>)\b");
                if (regex.Success)
                {
                    var border = regex.Groups["border"].Value;
                    var middle = regex.Groups["middle"].Value;
                    var result = middle + border + middle;
                    Console.WriteLine(result);
                }
                

                input = Console.ReadLine();
            }
        }
    }
}
