using System;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

namespace _08.Mines
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();

            var matches = Regex.Matches(input, @"<..>");
            var result = new StringBuilder();
            result.Append(input);
            var counter = 0;
            foreach (Match mine in matches)
            {
                var minePower = Math.Abs(mine.ToString()[1] - mine.ToString()[2]);
                
                var index = input.IndexOf(mine.ToString(), counter);
                var startFromLeft = index - minePower;
                var endFromRight = 2* minePower + mine.Length;
                
                if (startFromLeft < 0)
                {
                    startFromLeft = 0;
                    endFromRight -= minePower - index; 
                }

                if (endFromRight + startFromLeft >= input.Length)
                {
                    endFromRight = input.Length - startFromLeft;
                    
                }
                result.Remove(startFromLeft, endFromRight);
                //var toReplace = input.Substring(startFromLeft, endFromRight);
               result.Insert(startFromLeft, "_", endFromRight);
               //input = input.Replace(toReplace, new string('_', toReplace.Length));
                counter += endFromRight;
            }

            Console.WriteLine(result);
        }
    }
}
