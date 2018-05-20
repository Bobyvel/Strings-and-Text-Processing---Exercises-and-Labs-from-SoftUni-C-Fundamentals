using System;
using System.Diagnostics.Tracing;
using System.Linq;
using System.Text;

namespace _04.MorseCodeUpgraded
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine().Split('|');
            var result = new StringBuilder();
            for (int i = 0; i < input.Length; i++)
            {
                var letterCode = input[i].Select(l => int.Parse(l.ToString())).ToArray();
                
                var countOf1 = letterCode.Count(l => l== 1);
                var countOf0 = letterCode.Count(l => l == 0);

                var letterNumber = countOf1 * 5 + countOf0 * 3;
                var counter = 0;
                for (int j = 1; j <= letterCode.Length; j++)
                {
                    if (j == letterCode.Length)
                    {
                        letterNumber += counter;
                        break;
                    }

                    if (letterCode[j-1] == letterCode[j])
                    {
                        counter = 1;
                        letterNumber++;
                    }
                    else 
                    {
                        letterNumber += counter;
                        counter = 0;

                    }
                }

                
                result.Append((char) letterNumber);

               

            }

            Console.WriteLine(result);
        }
    }
}
